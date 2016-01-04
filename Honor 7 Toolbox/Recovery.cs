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
    public partial class Recovery : Syncfusion.Windows.Forms.MetroForm
    {
        

        public Recovery()
        {
            InitializeComponent();
        }

        private void twrpRecoBtn_Click(object sender, EventArgs e)
        {

            try
            {
                System.Diagnostics.Process.Start(@"files\flashTWRP.bat");

                this.Close();
            }
            catch
            {
                MessageBox.Show("File 'flashTWRP.bat' does not exit!", "Error!");
            }
        }

        private void stockRecoBtn_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(@"files\flashStock.bat");
                
                this.Close();
            }
            catch
            {
                MessageBox.Show("File 'flashStock.bat' does not exit!", "Error!");
            }
        }

        private void bootRecoBtn_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(@"files\bootReco.bat");
                MessageBox.Show("Booting to recovery.", "Recovery");
                this.Close();
            }
            catch
            {
                MessageBox.Show("File 'bootReco.bat' does not exit!", "Error!"); ;
            }
        }

        
    }
    
}
