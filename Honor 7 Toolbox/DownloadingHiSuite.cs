#region Copyright Syncfusion Inc. 2001-2015.
// Copyright Syncfusion Inc. 2001-2015. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace Honor_7_Toolbox
{
    public partial class DownloadingHiSuite : Syncfusion.Windows.Forms.MetroForm
    {
        
        public DownloadingHiSuite()
        {
            InitializeComponent();
        }

        private void DownloadingHiSuite_Load(object sender, EventArgs e)
        {
            
            StatusLabel.Text = "Downloading...";
            if (File.Exists(@"files\HiSuite.exe"))
            {
                completeLbL.Visible = true;
                installBtn.Visible = true;
                StatusLabel.Text = "Download Complete";
                downBtn.Visible = true;

            }
            else
            {
                using (WebClient wc = new WebClient())
                {

                    wc.DownloadProgressChanged += wc_DownloadProgressChanged;
                    wc.DownloadFileAsync(new System.Uri("https://copy.com/odjELiupzuLRLkPE/HiSuiteSetup_2.3.55.1.exe?download=1"),
                    @"files\HiSuite.exe");

                }
            }

            



        }

        void wc_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            
            progressBar.Value = e.ProgressPercentage;
            if (progressBar.Value >=100)
            {
                completeLbL.Visible = true;
                downBtn.Visible = true;
                StatusLabel.Text = "Download Complete";
                installBtn.Visible = true;

            }

          

        }

        private void installBtn_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(@"files\HiSuite.exe");
                this.Close();
            }
            catch
            {
                MessageBox.Show("File doesn't exists or its corrupt! Download it again!", "Error!");
            }
  

            
        }

        private void downBtn_Click(object sender, EventArgs e)
        {
            installBtn.Visible = false;
            completeLbL.Visible = false;
            StatusLabel.Text = "Downloading...";
            downBtn.Visible = false;
     
            using (WebClient wc = new WebClient())
            {

                wc.DownloadProgressChanged += wc_DownloadProgressChanged;
                wc.DownloadFileAsync(new System.Uri("https://copy.com/odjELiupzuLRLkPE/HiSuiteSetup_2.3.55.1.exe?download=1"),
                @"files\HiSuite.exe");

            }

        }
    }

}

