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

namespace Honor_7_Toolbox
{
    public partial class MainMenu : Syncfusion.Windows.Forms.MetroForm
    {
        private ToolsInstallMenu ToolsInstallMenu;
        private Bootloader Bootloader;
        private Recovery Recovery;
        public MainMenu()
        {
            InitializeComponent();
        }

        

        private void MainMenu_Load(object sender, EventArgs e)
        {
            this.Text = "Honor 7 Toolbox " + Application.ProductVersion.ToString() + " by TheMegaPhoenix";
            
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            ToolsInstallMenu = new ToolsInstallMenu();
            ToolsInstallMenu.Show();
            

        }

        private void bootloaderBtn_Click(object sender, EventArgs e)
        {
            Bootloader = new Bootloader();
            Bootloader.Show();
            
        }

        private void recoveryBtn_Click(object sender, EventArgs e)
        {
            Recovery = new Recovery();
            Recovery.Show();
        }
    }
    
}
