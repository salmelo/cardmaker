////////////////////////////////////////////////////////////////////////////////
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

namespace CardMaker.Forms
{
    partial class MDILayoutControl
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			this.groupBoxCardSet = new System.Windows.Forms.GroupBox();
			this.btnConfigureExport = new System.Windows.Forms.Button();
			this.btnConfigureSize = new System.Windows.Forms.Button();
			this.checkLoadAllReferences = new System.Windows.Forms.CheckBox();
			this.btnScale = new System.Windows.Forms.Button();
			this.resizeBtn = new System.Windows.Forms.Button();
			this.listViewElements = new Support.UI.ListViewDoubleBuffered();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.contextMenuElements = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pasteReferenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.detachReferenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pasteSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.checkCardSetDrawBorder = new System.Windows.Forms.CheckBox();
			this.numericCardSetDPI = new System.Windows.Forms.NumericUpDown();
			this.label8 = new System.Windows.Forms.Label();
			this.btnElementRename = new System.Windows.Forms.Button();
			this.btnElementUp = new System.Windows.Forms.Button();
			this.btnElementDown = new System.Windows.Forms.Button();
			this.numericCardSetBuffer = new System.Windows.Forms.NumericUpDown();
			this.label11 = new System.Windows.Forms.Label();
			this.btnDuplicate = new System.Windows.Forms.Button();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.btnRemoveElement = new System.Windows.Forms.Button();
			this.numericCardSetHeight = new System.Windows.Forms.NumericUpDown();
			this.numericCardSetWidth = new System.Windows.Forms.NumericUpDown();
			this.btnAddElement = new System.Windows.Forms.Button();
			this.btnGenCards = new System.Windows.Forms.Button();
			this.numericCardIndex = new System.Windows.Forms.NumericUpDown();
			this.lblIndex = new System.Windows.Forms.Label();
			this.groupBoxCardCount = new System.Windows.Forms.GroupBox();
			this.label2 = new System.Windows.Forms.Label();
			this.numericRowIndex = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBoxCardSet.SuspendLayout();
			this.contextMenuElements.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericCardSetDPI)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericCardSetBuffer)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericCardSetHeight)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericCardSetWidth)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericCardIndex)).BeginInit();
			this.groupBoxCardCount.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericRowIndex)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBoxCardSet
			// 
			this.groupBoxCardSet.Controls.Add(this.btnConfigureExport);
			this.groupBoxCardSet.Controls.Add(this.btnConfigureSize);
			this.groupBoxCardSet.Controls.Add(this.checkLoadAllReferences);
			this.groupBoxCardSet.Controls.Add(this.btnScale);
			this.groupBoxCardSet.Controls.Add(this.resizeBtn);
			this.groupBoxCardSet.Controls.Add(this.listViewElements);
			this.groupBoxCardSet.Controls.Add(this.checkCardSetDrawBorder);
			this.groupBoxCardSet.Controls.Add(this.numericCardSetDPI);
			this.groupBoxCardSet.Controls.Add(this.label8);
			this.groupBoxCardSet.Controls.Add(this.btnElementRename);
			this.groupBoxCardSet.Controls.Add(this.btnElementUp);
			this.groupBoxCardSet.Controls.Add(this.btnElementDown);
			this.groupBoxCardSet.Controls.Add(this.numericCardSetBuffer);
			this.groupBoxCardSet.Controls.Add(this.label11);
			this.groupBoxCardSet.Controls.Add(this.btnDuplicate);
			this.groupBoxCardSet.Controls.Add(this.label10);
			this.groupBoxCardSet.Controls.Add(this.label9);
			this.groupBoxCardSet.Controls.Add(this.btnRemoveElement);
			this.groupBoxCardSet.Controls.Add(this.numericCardSetHeight);
			this.groupBoxCardSet.Controls.Add(this.numericCardSetWidth);
			this.groupBoxCardSet.Controls.Add(this.btnAddElement);
			this.groupBoxCardSet.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBoxCardSet.Enabled = false;
			this.groupBoxCardSet.Location = new System.Drawing.Point(0, 57);
			this.groupBoxCardSet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBoxCardSet.Name = "groupBoxCardSet";
			this.groupBoxCardSet.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBoxCardSet.Size = new System.Drawing.Size(561, 635);
			this.groupBoxCardSet.TabIndex = 12;
			this.groupBoxCardSet.TabStop = false;
			this.groupBoxCardSet.Text = "Card Layout";
			// 
			// btnConfigureExport
			// 
			this.btnConfigureExport.Location = new System.Drawing.Point(343, 18);
			this.btnConfigureExport.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnConfigureExport.Name = "btnConfigureExport";
			this.btnConfigureExport.Size = new System.Drawing.Size(79, 27);
			this.btnConfigureExport.TabIndex = 35;
			this.btnConfigureExport.Text = "Settings";
			this.btnConfigureExport.UseVisualStyleBackColor = true;
			this.btnConfigureExport.Click += new System.EventHandler(this.btnConfigureExport_Click);
			// 
			// btnConfigureSize
			// 
			this.btnConfigureSize.Location = new System.Drawing.Point(343, 49);
			this.btnConfigureSize.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnConfigureSize.Name = "btnConfigureSize";
			this.btnConfigureSize.Size = new System.Drawing.Size(79, 27);
			this.btnConfigureSize.TabIndex = 34;
			this.btnConfigureSize.Text = "Resize";
			this.btnConfigureSize.UseVisualStyleBackColor = true;
			this.btnConfigureSize.Click += new System.EventHandler(this.btnConfigureSize_Click);
			// 
			// checkLoadAllReferences
			// 
			this.checkLoadAllReferences.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.checkLoadAllReferences.Location = new System.Drawing.Point(335, 82);
			this.checkLoadAllReferences.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.checkLoadAllReferences.Name = "checkLoadAllReferences";
			this.checkLoadAllReferences.Size = new System.Drawing.Size(184, 20);
			this.checkLoadAllReferences.TabIndex = 33;
			this.checkLoadAllReferences.Text = "Load All References";
			this.checkLoadAllReferences.UseVisualStyleBackColor = true;
			this.checkLoadAllReferences.CheckedChanged += new System.EventHandler(this.HandleCardSetValueChange);
			// 
			// btnScale
			// 
			this.btnScale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnScale.Location = new System.Drawing.Point(191, 576);
			this.btnScale.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnScale.Name = "btnScale";
			this.btnScale.Size = new System.Drawing.Size(80, 25);
			this.btnScale.TabIndex = 32;
			this.btnScale.Text = "Scale";
			this.btnScale.UseVisualStyleBackColor = true;
			this.btnScale.Click += new System.EventHandler(this.btnScale_Click);
			// 
			// resizeBtn
			// 
			this.resizeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.resizeBtn.Location = new System.Drawing.Point(191, 603);
			this.resizeBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.resizeBtn.Name = "resizeBtn";
			this.resizeBtn.Size = new System.Drawing.Size(80, 25);
			this.resizeBtn.TabIndex = 31;
			this.resizeBtn.Text = "Resize";
			this.resizeBtn.UseVisualStyleBackColor = true;
			this.resizeBtn.Click += new System.EventHandler(this.resize_Click);
			// 
			// listViewElements
			// 
			this.listViewElements.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.listViewElements.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.listViewElements.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
			this.listViewElements.ContextMenuStrip = this.contextMenuElements;
			this.listViewElements.FullRowSelect = true;
			this.listViewElements.GridLines = true;
			this.listViewElements.HideSelection = false;
			this.listViewElements.Location = new System.Drawing.Point(8, 110);
			this.listViewElements.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.listViewElements.Name = "listViewElements";
			this.listViewElements.ShowItemToolTips = true;
			this.listViewElements.Size = new System.Drawing.Size(545, 459);
			this.listViewElements.TabIndex = 30;
			this.listViewElements.UseCompatibleStateImageBehavior = false;
			this.listViewElements.View = System.Windows.Forms.View.Details;
			this.listViewElements.SelectedIndexChanged += new System.EventHandler(this.listViewElements_SelectedIndexChanged);
			this.listViewElements.DoubleClick += new System.EventHandler(this.listViewElements_DoubleClick);
			this.listViewElements.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listViewElements_KeyDown);
			this.listViewElements.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.listViewElements_KeyPress);
			this.listViewElements.Resize += new System.EventHandler(this.listViewElements_Resize);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Enabled";
			this.columnHeader1.Width = 55;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Element";
			this.columnHeader2.Width = 161;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Type";
			this.columnHeader3.Width = 92;
			// 
			// contextMenuElements
			// 
			this.contextMenuElements.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.contextMenuElements.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.pasteReferenceToolStripMenuItem,
            this.detachReferenceToolStripMenuItem,
            this.pasteSettingsToolStripMenuItem});
			this.contextMenuElements.Name = "contextMenuElements";
			this.contextMenuElements.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
			this.contextMenuElements.Size = new System.Drawing.Size(212, 124);
			this.contextMenuElements.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuElements_Opening);
			// 
			// copyToolStripMenuItem
			// 
			this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
			this.copyToolStripMenuItem.Size = new System.Drawing.Size(211, 24);
			this.copyToolStripMenuItem.Text = "Copy";
			this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
			// 
			// pasteToolStripMenuItem
			// 
			this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
			this.pasteToolStripMenuItem.Size = new System.Drawing.Size(211, 24);
			this.pasteToolStripMenuItem.Text = "Paste";
			this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
			// 
			// pasteReferenceToolStripMenuItem
			// 
			this.pasteReferenceToolStripMenuItem.Name = "pasteReferenceToolStripMenuItem";
			this.pasteReferenceToolStripMenuItem.Size = new System.Drawing.Size(211, 24);
			this.pasteReferenceToolStripMenuItem.Text = "Paste Reference(s)";
			this.pasteReferenceToolStripMenuItem.Click += new System.EventHandler(this.pasteReferenceToolStripMenuItem_Click);
			// 
			// detachReferenceToolStripMenuItem
			// 
			this.detachReferenceToolStripMenuItem.Name = "detachReferenceToolStripMenuItem";
			this.detachReferenceToolStripMenuItem.Size = new System.Drawing.Size(211, 24);
			this.detachReferenceToolStripMenuItem.Text = "Detach Reference(s)";
			this.detachReferenceToolStripMenuItem.Click += new System.EventHandler(this.detachReferenceToolStripMenuItem_Click);
			// 
			// pasteSettingsToolStripMenuItem
			// 
			this.pasteSettingsToolStripMenuItem.Name = "pasteSettingsToolStripMenuItem";
			this.pasteSettingsToolStripMenuItem.Size = new System.Drawing.Size(211, 24);
			this.pasteSettingsToolStripMenuItem.Text = "Paste Settings...";
			this.pasteSettingsToolStripMenuItem.Click += new System.EventHandler(this.pasteSettingsToolStripMenuItem_Click);
			// 
			// checkCardSetDrawBorder
			// 
			this.checkCardSetDrawBorder.Location = new System.Drawing.Point(12, 82);
			this.checkCardSetDrawBorder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.checkCardSetDrawBorder.Name = "checkCardSetDrawBorder";
			this.checkCardSetDrawBorder.Size = new System.Drawing.Size(184, 20);
			this.checkCardSetDrawBorder.TabIndex = 28;
			this.checkCardSetDrawBorder.Text = "Draw Border";
			this.checkCardSetDrawBorder.UseVisualStyleBackColor = true;
			this.checkCardSetDrawBorder.CheckedChanged += new System.EventHandler(this.HandleCardSetValueChange);
			// 
			// numericCardSetDPI
			// 
			this.numericCardSetDPI.Location = new System.Drawing.Point(260, 20);
			this.numericCardSetDPI.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.numericCardSetDPI.Maximum = new decimal(new int[] {
            6000,
            0,
            0,
            0});
			this.numericCardSetDPI.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
			this.numericCardSetDPI.Name = "numericCardSetDPI";
			this.numericCardSetDPI.Size = new System.Drawing.Size(75, 22);
			this.numericCardSetDPI.TabIndex = 27;
			this.numericCardSetDPI.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
			this.numericCardSetDPI.ValueChanged += new System.EventHandler(this.HandleCardSetValueChange);
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(163, 20);
			this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(89, 25);
			this.label8.TabIndex = 26;
			this.label8.Text = "Export DPI:";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnElementRename
			// 
			this.btnElementRename.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnElementRename.Location = new System.Drawing.Point(103, 603);
			this.btnElementRename.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnElementRename.Name = "btnElementRename";
			this.btnElementRename.Size = new System.Drawing.Size(80, 25);
			this.btnElementRename.TabIndex = 25;
			this.btnElementRename.Text = "Rename";
			this.btnElementRename.UseVisualStyleBackColor = true;
			this.btnElementRename.Click += new System.EventHandler(this.btnElementRename_Click);
			// 
			// btnElementUp
			// 
			this.btnElementUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnElementUp.Location = new System.Drawing.Point(483, 576);
			this.btnElementUp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnElementUp.Name = "btnElementUp";
			this.btnElementUp.Size = new System.Drawing.Size(71, 25);
			this.btnElementUp.TabIndex = 24;
			this.btnElementUp.Text = "Up";
			this.btnElementUp.UseVisualStyleBackColor = true;
			this.btnElementUp.Click += new System.EventHandler(this.btnElementChangeOrder_Click);
			// 
			// btnElementDown
			// 
			this.btnElementDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnElementDown.Location = new System.Drawing.Point(481, 605);
			this.btnElementDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnElementDown.Name = "btnElementDown";
			this.btnElementDown.Size = new System.Drawing.Size(72, 25);
			this.btnElementDown.TabIndex = 23;
			this.btnElementDown.Text = "Down";
			this.btnElementDown.UseVisualStyleBackColor = true;
			this.btnElementDown.Click += new System.EventHandler(this.btnElementChangeOrder_Click);
			// 
			// numericCardSetBuffer
			// 
			this.numericCardSetBuffer.Location = new System.Drawing.Point(72, 20);
			this.numericCardSetBuffer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.numericCardSetBuffer.Name = "numericCardSetBuffer";
			this.numericCardSetBuffer.Size = new System.Drawing.Size(75, 22);
			this.numericCardSetBuffer.TabIndex = 22;
			this.numericCardSetBuffer.ValueChanged += new System.EventHandler(this.HandleCardSetValueChange);
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(8, 20);
			this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(60, 25);
			this.label11.TabIndex = 21;
			this.label11.Text = "Buffer:";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnDuplicate
			// 
			this.btnDuplicate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnDuplicate.Location = new System.Drawing.Point(103, 576);
			this.btnDuplicate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnDuplicate.Name = "btnDuplicate";
			this.btnDuplicate.Size = new System.Drawing.Size(80, 25);
			this.btnDuplicate.TabIndex = 20;
			this.btnDuplicate.Text = "Dupe";
			this.btnDuplicate.UseVisualStyleBackColor = true;
			this.btnDuplicate.Click += new System.EventHandler(this.btnDuplicate_Click);
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(8, 50);
			this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(60, 25);
			this.label10.TabIndex = 18;
			this.label10.Text = "Width:";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(163, 50);
			this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(89, 25);
			this.label9.TabIndex = 17;
			this.label9.Text = "Height:";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnRemoveElement
			// 
			this.btnRemoveElement.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnRemoveElement.Location = new System.Drawing.Point(8, 603);
			this.btnRemoveElement.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnRemoveElement.Name = "btnRemoveElement";
			this.btnRemoveElement.Size = new System.Drawing.Size(87, 25);
			this.btnRemoveElement.TabIndex = 15;
			this.btnRemoveElement.Text = "Remove";
			this.btnRemoveElement.UseVisualStyleBackColor = true;
			this.btnRemoveElement.Click += new System.EventHandler(this.btnRemoveElement_Click);
			// 
			// numericCardSetHeight
			// 
			this.numericCardSetHeight.Location = new System.Drawing.Point(260, 50);
			this.numericCardSetHeight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.numericCardSetHeight.Maximum = new decimal(new int[] {
            65536,
            0,
            0,
            0});
			this.numericCardSetHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericCardSetHeight.Name = "numericCardSetHeight";
			this.numericCardSetHeight.Size = new System.Drawing.Size(75, 22);
			this.numericCardSetHeight.TabIndex = 14;
			this.numericCardSetHeight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericCardSetHeight.ValueChanged += new System.EventHandler(this.HandleCardSetValueChange);
			// 
			// numericCardSetWidth
			// 
			this.numericCardSetWidth.Location = new System.Drawing.Point(72, 50);
			this.numericCardSetWidth.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.numericCardSetWidth.Maximum = new decimal(new int[] {
            65536,
            0,
            0,
            0});
			this.numericCardSetWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericCardSetWidth.Name = "numericCardSetWidth";
			this.numericCardSetWidth.Size = new System.Drawing.Size(75, 22);
			this.numericCardSetWidth.TabIndex = 13;
			this.numericCardSetWidth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericCardSetWidth.ValueChanged += new System.EventHandler(this.HandleCardSetValueChange);
			// 
			// btnAddElement
			// 
			this.btnAddElement.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnAddElement.Location = new System.Drawing.Point(8, 576);
			this.btnAddElement.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnAddElement.Name = "btnAddElement";
			this.btnAddElement.Size = new System.Drawing.Size(87, 25);
			this.btnAddElement.TabIndex = 10;
			this.btnAddElement.Text = "Add";
			this.btnAddElement.UseVisualStyleBackColor = true;
			this.btnAddElement.Click += new System.EventHandler(this.btnAddElement_Click);
			// 
			// btnGenCards
			// 
			this.btnGenCards.Location = new System.Drawing.Point(8, 23);
			this.btnGenCards.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnGenCards.Name = "btnGenCards";
			this.btnGenCards.Size = new System.Drawing.Size(33, 25);
			this.btnGenCards.TabIndex = 22;
			this.btnGenCards.Text = "#";
			this.btnGenCards.UseVisualStyleBackColor = true;
			this.btnGenCards.Click += new System.EventHandler(this.btnGenCards_Click);
			// 
			// numericCardIndex
			// 
			this.numericCardIndex.Location = new System.Drawing.Point(124, 23);
			this.numericCardIndex.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.numericCardIndex.Name = "numericCardIndex";
			this.numericCardIndex.Size = new System.Drawing.Size(72, 22);
			this.numericCardIndex.TabIndex = 21;
			this.numericCardIndex.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numericCardIndex.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
			this.numericCardIndex.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericCardIndex.ValueChanged += new System.EventHandler(this.numericCardIndex_ValueChanged);
			// 
			// lblIndex
			// 
			this.lblIndex.Location = new System.Drawing.Point(199, 23);
			this.lblIndex.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblIndex.Name = "lblIndex";
			this.lblIndex.Size = new System.Drawing.Size(72, 25);
			this.lblIndex.TabIndex = 20;
			this.lblIndex.Text = "/";
			this.lblIndex.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// groupBoxCardCount
			// 
			this.groupBoxCardCount.Controls.Add(this.label2);
			this.groupBoxCardCount.Controls.Add(this.numericRowIndex);
			this.groupBoxCardCount.Controls.Add(this.label1);
			this.groupBoxCardCount.Controls.Add(this.btnGenCards);
			this.groupBoxCardCount.Controls.Add(this.lblIndex);
			this.groupBoxCardCount.Controls.Add(this.numericCardIndex);
			this.groupBoxCardCount.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBoxCardCount.Enabled = false;
			this.groupBoxCardCount.Location = new System.Drawing.Point(0, 0);
			this.groupBoxCardCount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBoxCardCount.Name = "groupBoxCardCount";
			this.groupBoxCardCount.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBoxCardCount.Size = new System.Drawing.Size(561, 57);
			this.groupBoxCardCount.TabIndex = 23;
			this.groupBoxCardCount.TabStop = false;
			this.groupBoxCardCount.Text = "Card Count";
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.Location = new System.Drawing.Point(411, 23);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(67, 26);
			this.label2.TabIndex = 25;
			this.label2.Text = "Row";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// numericRowIndex
			// 
			this.numericRowIndex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.numericRowIndex.Location = new System.Drawing.Point(481, 23);
			this.numericRowIndex.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.numericRowIndex.Name = "numericRowIndex";
			this.numericRowIndex.Size = new System.Drawing.Size(72, 22);
			this.numericRowIndex.TabIndex = 24;
			this.numericRowIndex.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numericRowIndex.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
			this.numericRowIndex.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericRowIndex.ValueChanged += new System.EventHandler(this.numericRowIndex_ValueChanged);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(49, 23);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(67, 26);
			this.label1.TabIndex = 23;
			this.label1.Text = "Card:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// MDILayoutControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(561, 692);
			this.Controls.Add(this.groupBoxCardSet);
			this.Controls.Add(this.groupBoxCardCount);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.MinimumSize = new System.Drawing.Size(434, 422);
			this.Name = "MDILayoutControl";
			this.ShowIcon = false;
			this.Text = " Layout Control";
			this.Load += new System.EventHandler(this.MDILayoutControl_Load);
			this.groupBoxCardSet.ResumeLayout(false);
			this.contextMenuElements.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numericCardSetDPI)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericCardSetBuffer)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericCardSetHeight)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericCardSetWidth)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericCardIndex)).EndInit();
			this.groupBoxCardCount.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numericRowIndex)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCardSet;
        private System.Windows.Forms.Button btnGenCards;
        private System.Windows.Forms.NumericUpDown numericCardIndex;
        private System.Windows.Forms.Label lblIndex;
        private System.Windows.Forms.CheckBox checkCardSetDrawBorder;
        private System.Windows.Forms.NumericUpDown numericCardSetDPI;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnElementRename;
        private System.Windows.Forms.Button btnElementUp;
        private System.Windows.Forms.Button btnElementDown;
        private System.Windows.Forms.NumericUpDown numericCardSetBuffer;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnDuplicate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnRemoveElement;
        private System.Windows.Forms.NumericUpDown numericCardSetHeight;
        private System.Windows.Forms.NumericUpDown numericCardSetWidth;
        private System.Windows.Forms.Button btnAddElement;
        private System.Windows.Forms.GroupBox groupBoxCardCount;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private Support.UI.ListViewDoubleBuffered listViewElements;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuElements;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.NumericUpDown numericRowIndex;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button resizeBtn;
        private System.Windows.Forms.Button btnScale;
        private System.Windows.Forms.CheckBox checkLoadAllReferences;
        private System.Windows.Forms.ToolStripMenuItem pasteSettingsToolStripMenuItem;
        private System.Windows.Forms.Button btnConfigureSize;
        private System.Windows.Forms.ToolStripMenuItem pasteReferenceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detachReferenceToolStripMenuItem;
        private System.Windows.Forms.Button btnConfigureExport;
    }
}