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
using System.Globalization;
using System.Reflection;
using System.Resources;
using AutoUpdaterDotNET;

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
            //Uncomment below line to see Russian version

            //AutoUpdater.CurrentCulture = CultureInfo.CreateSpecificCulture("ru-RU");

            //If you want to open download page when user click on download button uncomment below line.

            //AutoUpdater.OpenDownloadPage = true;

            //Don't want user to select remind later time in AutoUpdater notification window then uncomment 3 lines below so default remind later time will be set to 2 days.

            //AutoUpdater.LetUserSelectRemindLater = false;
            //AutoUpdater.RemindLaterTimeSpan = RemindLaterFormat.Days;
            //AutoUpdater.RemindLaterAt = 2;
            AutoUpdater.Start("https://copy.com/29WGqPWeh2hvpxw6");

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

        private void updateBtn_Click(object sender, EventArgs e)
        {
            //Uncomment below line to see Russian version

            //AutoUpdater.CurrentCulture = CultureInfo.CreateSpecificCulture("ru-RU");

            //If you want to open download page when user click on download button uncomment below line.

            AutoUpdater.OpenDownloadPage = true;

            //Don't want user to select remind later time in AutoUpdater notification window then uncomment 3 lines below so default remind later time will be set to 2 days.

            AutoUpdater.LetUserSelectRemindLater = false;
            //AutoUpdater.RemindLaterTimeSpan = RemindLaterFormat.Days;
            //AutoUpdater.RemindLaterAt = 2;
            AutoUpdater.Start("https://copy.com/29WGqPWeh2hvpxw6");
        }

        private void getRes(CultureInfo ci)
        {
           // Assembly a = Assembly.Load("Honor 7 Toolbox");
            ResourceManager rm = new ResourceManager("Honor 7 Toolbox.Lang.langres", Assembly.GetExecutingAssembly());
            StartBtn.Text = rm.GetString("startBtn", ci);
            bootloaderBtn.Text = rm.GetString("bootloader", ci);
            recoveryBtn.Text = rm.GetString("recovery", ci);
            updateBtn.Text = rm.GetString("update", ci);
        }
        private void enBtn_Click(object sender, EventArgs e)
        {
            CultureInfo ci = new CultureInfo("en-UK");
            getRes(ci);
        }

        private void buttonAdv1_Click(object sender, EventArgs e)
        {
            CultureInfo ci = new CultureInfo("fr-FR");
            getRes(ci);
        }
    }
    
}
