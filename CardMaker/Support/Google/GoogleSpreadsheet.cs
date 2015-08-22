////////////////////////////////////////////////////////////////////////////////
// The MIT License (MIT)
//
// Copyright (c) 2015 Tim Stair
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

using System.Linq;
using Google.GData.Client;
using Google.GData.Spreadsheets;
using Support.IO;
using System.Collections.Generic;

namespace Support.UI
{
    public static class GoogleSpreadsheet
    {
        const string SCOPE = "https://spreadsheets.google.com/feeds";

        // API KEY etc. config here: https://console.developers.google.com/project

        public static SpreadsheetsService GetSpreadsheetsService(string sAppName, string sClientId, 
            string sGoogleAccessToken)
        {
            var zAuthParameters = new OAuth2Parameters()
            {
                ClientId = sClientId,
                Scope = SCOPE,
                AccessToken = sGoogleAccessToken
            };

            var spreadsheetsService = new SpreadsheetsService(sAppName);
            spreadsheetsService.RequestFactory = new GOAuth2RequestFactory(null, sAppName, zAuthParameters);

            return spreadsheetsService;
        }

        // TODO: all callers of this method should handle exceptions (InvalidCredentialsException etc.)
        public static List<List<string>> GetSpreadsheet(SpreadsheetsService zSpreadsheetService, string sSpreadsheetName, string sSheetName)
        {
            var listLines = new List<List<string>>();

            // get all spreadsheets

            var query = new SpreadsheetQuery
            {
                // only ask for the spreadsheet by the given name
                Title = sSpreadsheetName
            };
            var feed = zSpreadsheetService.Query(query);

            var bFoundSpreadsheet = false;
            foreach (var entry in feed.Entries)
            {
                if (entry.Title.Text == sSpreadsheetName)
                {
                    bFoundSpreadsheet = true;
                    Logger.AddLogLine("Google: Found spreadsheet: " + sSpreadsheetName);

                    var link = entry.Links.FindService(GDataSpreadsheetsNameTable.WorksheetRel, null);

                    var wsquery = new WorksheetQuery(link.HRef.ToString())
                    {
                        Title = sSheetName
                    };
                    var wsfeed = zSpreadsheetService.Query(wsquery);

                    var bFoundSheet = false;

                    foreach (var worksheet in wsfeed.Entries)
                    {
                        //System.Diagnostics.Trace.WriteLine(worksheet.Title.Text);

                        if (worksheet.Title.Text == sSheetName)
                        {
                            bFoundSheet = true;
                            Logger.AddLogLine("Google: Found sheet: " + sSheetName);

                            var cellFeedLink = worksheet.Links.FindService(GDataSpreadsheetsNameTable.CellRel, null);

                            var cquery = new CellQuery(cellFeedLink.HRef.ToString());
                            var cfeed = zSpreadsheetService.Query(cquery);

                            //System.Diagnostics.Trace.WriteLine("Cells in this worksheet:");
                            uint uRow = 1;
                            uint uCol = 1;
                            var listRow = new List<string>();
                            foreach (var curCell in cfeed.Entries.OfType<CellEntry>())
                            {
                                // NOTE: This completely ignores blank lines in the spreadsheet
                                if (uRow != curCell.Cell.Row)
                                {
                                    // new row, flush the previous
                                    listLines.Add(listRow);
                                    listRow = new List<string>();
                                    uRow = curCell.Cell.Row;
                                    uCol = 1;
                                }

                                // fill in any missing columns with empty strings
                                if (uCol != curCell.Cell.Column)
                                {
                                    while (uCol < curCell.Cell.Column)
                                    {
                                        listRow.Add(string.Empty);
                                        uCol++;
                                    }
                                }

                                listRow.Add(curCell.Cell.Value);
                                uCol++;
                            }
                            // always flush the last line
                            listLines.Add(listRow);
                        }
                        if (bFoundSheet)
                            break;
                    }
                    if (!bFoundSheet)
                        Logger.AddLogLine("Google: Failed to find sheet: " + sSheetName);

                }
                if (bFoundSpreadsheet)
                    break;
            }

            if (!bFoundSpreadsheet)
                Logger.AddLogLine("Google: Failed to find spreadsheet: " + sSpreadsheetName);

            return listLines;
        }

        public static AtomEntryCollection GetSpreadsheetList(SpreadsheetsService zSpreadsheetService)
        {
            // get all spreadsheet names
            var query = new SpreadsheetQuery
            {
            };
            var feed = zSpreadsheetService.Query(query);
            return feed.Entries;
        }

        public static AtomEntryCollection GetSheetNames(SpreadsheetsService zSpreadsheetService, AtomEntry zSheetEntry)
        {
            var link = zSheetEntry.Links.FindService(GDataSpreadsheetsNameTable.WorksheetRel, null);

            var wsquery = new WorksheetQuery(link.HRef.ToString())
            {
            };
            var wsfeed = zSpreadsheetService.Query(wsquery);
            return wsfeed.Entries;
        }
    }
}