﻿/*
 * Copyright (c) 2011 WinBMA/Andrew Moore
 *
 * LICENSED UNDER THE MIT LICENSE
 *
 * Permission is hereby granted, free of charge, to any person obtaining a copy of
 * this software and associated documentation files (the "Software"), to deal in
 * the Software without restriction, including without limitation the rights to use,
 * copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the
 * Software, and to permit persons to whom the Software is furnished to do so,
 * subject to the following conditions:
 *
 * The above copyright notice and this permission notice shall be included in all
 * copies or substantial portions of the Software.
 *
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS
 * FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR
 * COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER
 * IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
 * WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
 */

using System;
using System.Windows;

namespace WinBMA.UI
{
    public partial class AboutWindow : Window
    {
        public AboutWindow()
        {
            InitializeComponent();

            TEXTBLOCK_Version.Text = App.Version.ToString();
            TEXTBLOCK_BuildDate.Text = GetFormattedBuildDate();

            TEXT_License.Text = Utilities.TextResourceReader.GetFromResources("/WinBMA;component/Resources/License.txt");

            LINK_HomePage.Click += new RoutedEventHandler(LINK_HomePage_Click);

            BUTTON_Donate.Click += new RoutedEventHandler(BUTTON_Donate_Click);
            BUTTON_Ok.Click += new RoutedEventHandler(BUTTON_Ok_Click);
        }

        private void BUTTON_Donate_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.paypal.com/cgi-bin/webscr?cmd=_donations&business=andrewm.finewolf@gmail.com&item_name=WinBMA%20Donation&currency_code=CAD&bn=PP%2dDonationsBF");
        }

        private void BUTTON_Ok_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
            this.Close();
        }

        private string GetFormattedBuildDate()
        {
            return String.Format("{0:ddd, dd MMM yyyy HH':'mm':'ss zzz}", App.BuildDate.ToLocalTime());
        }

        private void LINK_HomePage_Click(object sender, RoutedEventArgs e)
        {
            Utilities.UpdateChecker.OpenBrowserToHomePage();
        }
    }
}