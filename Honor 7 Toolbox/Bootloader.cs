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
    public partial class Bootloader : Syncfusion.Windows.Forms.MetroForm
    {
        

        public Bootloader()
        {
            InitializeComponent();
        }

        private void getCodeBtn_Click(object sender, EventArgs e)
        {
            
            System.Diagnostics.Process.Start("https://www.emui.com/plugin.php?id=unlock&mod=detail");
            System.Diagnostics.Process.Start("http://forum.xda-developers.com/honor-7/general/bootloader-unlocking-t3196243");
        }

        private void unlockBootloaderBtn_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(@"files\unlockboot.bat");
                
                this.Close();
            }
            catch
            {
                MessageBox.Show("File 'unlockboot.bat' does not exit!", "Error!");
            }
        }

        private void lockBootloaderBtn_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(@"files\lockboot.bat");

                this.Close();
            }
            catch
            {
                MessageBox.Show("File 'lockboot.bat' does not exit!", "Error!");
            }
        }
    }
    
}
