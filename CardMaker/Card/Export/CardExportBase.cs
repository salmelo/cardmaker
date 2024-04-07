﻿////////////////////////////////////////////////////////////////////////////////
// The MIT License (MIT)
//
// Copyright (c) 2024 Tim Stair
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.
////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using CardMaker.Data;
using CardMaker.Events.Managers;
using CardMaker.XML;
#if !MONO_BUILD
using SkiaSharp;
using SkiaSharp.Views.Desktop;
#endif
using Support.Progress;
using Support.UI;

namespace CardMaker.Card.Export
{
    public abstract class CardExportBase
    {
        protected Bitmap m_zExportCardBuffer;
        protected int[] ExportLayoutIndices { get; private set; }
        protected CardRenderer CardRenderer { get; }
        
        public IProgressReporter ProgressReporter { get; set; }

        protected CardExportBase(int nLayoutStartIndex, int nLayoutEndIndex) : this(Enumerable.Range(nLayoutStartIndex, nLayoutEndIndex - nLayoutStartIndex).ToArray())
        {
        }

        protected CardExportBase(int[] arrayExportLayoutIndices)
        {
            ExportLayoutIndices = arrayExportLayoutIndices;
            CardRenderer = new CardRenderer
            {
                CurrentDeck = new Deck()
            };
        }

        /// <summary>
        /// Changes the layout to the specified index in the project
        /// </summary>
        /// <param name="nIdx"></param>
        protected void ChangeExportLayoutIndex(int nIdx)
        {
            // based on the currently loaded project get the layout based on the index
            var zLayout = ProjectManager.Instance.LoadedProject.Layout[nIdx];
            CurrentDeck.SetAndLoadLayout(zLayout ?? CurrentDeck.CardLayout, true, 
                new ProgressReporterProxy()
                {
                    ProgressIndex = ProgressReporter.GetProgressIndex(ProgressName.REFERENCE_DATA),
                    ProgressReporter = ProgressReporter,
                    ProxyOwnsReporter = false
                });
        }

        protected Deck CurrentDeck => CardRenderer.CurrentDeck;

        ~CardExportBase()
        {
            m_zExportCardBuffer?.Dispose();
        }

        /// <summary>
        /// Updates the existing buffer image if necessary
        /// </summary>
        /// <param name="nWidth"></param>
        /// <param name="nHeight"></param>
        /// <param name="zGraphics"></param>
        protected virtual void UpdateBufferBitmap(int nWidth, int nHeight)
        {
            if (null == m_zExportCardBuffer ||
                nWidth != m_zExportCardBuffer.Width ||
                nHeight != m_zExportCardBuffer.Height)
            {
                m_zExportCardBuffer?.Dispose();
                m_zExportCardBuffer = new Bitmap(nWidth, nHeight);
            }
        }

        /// <summary>
        /// Rotates the export buffer based on the Layout exportRotation setting
        /// </summary>
        /// <param name="zBuffer">The buffer to rotate</param>
        /// <param name="zLayout">The layout containing the rotation settings</param>
        /// <param name="reverseRotation">Flags to perform the reverse rotation transform</param>
        protected void ProcessRotateExport(Bitmap zBuffer, ProjectLayout zLayout, bool reverseRotation)
        {
            switch (zLayout.exportRotation)
            {
                case 90:
                    zBuffer.RotateFlip(reverseRotation ? RotateFlipType.Rotate270FlipNone : RotateFlipType.Rotate90FlipNone);
                    break;
                case -90:
                    zBuffer.RotateFlip(reverseRotation ? RotateFlipType.Rotate90FlipNone : RotateFlipType.Rotate270FlipNone);
                    break;
                case 180:
                    zBuffer.RotateFlip(RotateFlipType.Rotate180FlipNone);
                    break;
            }
        }

        /// <summary>
        /// The primary entry point for the export processing
        /// </summary>
        public abstract void ExportThread();

        protected List<int> GetSubLayouts()
        {
            var listSubLayouts = new List<int>();

            var nIdx = 0;
            var dictionaryLayoutNameToLayout =
                ProjectManager.Instance.LoadedProject.Layout.ToDictionary(layout => layout.Name.ToUpper(), layout => nIdx++);
            foreach(var zElement in CurrentDeck.CardLayout.Element.Where(e => e.type == ElementType.SubLayout.ToString()))
            {
                if (dictionaryLayoutNameToLayout.TryGetValue(zElement.variable.ToUpper(), out var nLayoutIdx))
                {
                    listSubLayouts.Add(nLayoutIdx);
                }
                else
                {
                    ProgressReporter.AddIssue(
                        $"Invalid layout specified {zElement.variable} in element {zElement.name}");
                }
            }

            return listSubLayouts;
        }

        public void Save(Bitmap zBmp, string sPath, FileCardExporterFactory.CardMakerExportImageFormat eImageFormat, int nTargetDPI)
        {
            switch (eImageFormat)
            {
                // Note: SkiaSharp does not support DPI on Webp files (!)
#if !MONO_BUILD
                case FileCardExporterFactory.CardMakerExportImageFormat.Webp:
                    var zEncoderOptions = new SKWebpEncoderOptions(
                        CardMakerSettings.ExportWebPLossless
                            ? SKWebpEncoderCompression.Lossless
                            : SKWebpEncoderCompression.Lossy,
                        CardMakerSettings.ExportWebPLossless
                            ? 100
                            : CardMakerSettings.ExportWebPQuality);
                    using (var outFile = new FileInfo(sPath).Create())
                    {
                        zBmp.ToSKBitmap().PeekPixels()
                            .Encode(zEncoderOptions)
                            .SaveTo(outFile);
                    }
                    break;
#endif
                default:
                    
                    var nOriginalHorizontalResolution = zBmp.HorizontalResolution;
                    var nOriginalVerticalResolution = zBmp.VerticalResolution;
                    var eExportImageFormat =
                        FileCardExporterFactory.CardMakerImageExportFormatToImageFormatDictionary[eImageFormat];
                    if (eExportImageFormat == null)
                    {
                        ProgressReporter.AddIssue("Unsupported image format detected (likely a bug): {0}".FormatString(eImageFormat.ToString()));
                        return;
                    }

                    // resolution is only set after everything is rendered to the bitmap (and then reverted after save)
                    zBmp.SetResolution(nTargetDPI, nTargetDPI);
                    zBmp.Save(sPath, eExportImageFormat);
                    zBmp.SetResolution(nOriginalHorizontalResolution, nOriginalVerticalResolution);
                    break;
            }
        }
    }
}
