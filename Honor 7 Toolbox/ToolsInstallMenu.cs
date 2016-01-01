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

namespace Honor_7_Toolbox
{
    public partial class ToolsInstallMenu : Syncfusion.Windows.Forms.MetroForm
    {
        private DownloadingHiSuite DownloadingHiSuite;
        private InstallingADB InstallingADB;
        

        public ToolsInstallMenu()
        {
            InitializeComponent();
        }

        private void InstallHiSuiteBtn_Click(object sender, EventArgs e)
        {
            DownloadingHiSuite = new DownloadingHiSuite();
            DownloadingHiSuite.Show();
        }

        private void buttonAdv1_Click(object sender, EventArgs e)
        {
            InstallingADB = new InstallingADB();
            InstallingADB.Show();
        }

        private void buttonAdv3_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(@"files\hue.bat");
                
                this.Close();
            }
            catch
            {
                MessageBox.Show("File doesn't exists or its corrupt! Download it again!", "Error!");
            }
        }

       

    }
}
