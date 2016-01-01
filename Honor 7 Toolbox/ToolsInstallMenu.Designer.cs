#region Copyright Syncfusion Inc. 2001-2015.
// Copyright Syncfusion Inc. 2001-2015. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
namespace Honor_7_Toolbox
{
    partial class ToolsInstallMenu
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
            this.InstallHiSuiteBtn = new Syncfusion.Windows.Forms.ButtonAdv();
            this.installADBbtn = new Syncfusion.Windows.Forms.ButtonAdv();
            this.hue = new Syncfusion.Windows.Forms.ButtonAdv();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // InstallHiSuiteBtn
            // 
            this.InstallHiSuiteBtn.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.InstallHiSuiteBtn.BackColor = System.Drawing.Color.White;
            this.InstallHiSuiteBtn.BeforeTouchSize = new System.Drawing.Size(159, 45);
            this.InstallHiSuiteBtn.ForeColor = System.Drawing.Color.Black;
            this.InstallHiSuiteBtn.IsBackStageButton = false;
            this.InstallHiSuiteBtn.Location = new System.Drawing.Point(219, 39);
            this.InstallHiSuiteBtn.Name = "InstallHiSuiteBtn";
            this.InstallHiSuiteBtn.Size = new System.Drawing.Size(159, 45);
            this.InstallHiSuiteBtn.TabIndex = 0;
            this.InstallHiSuiteBtn.Text = "Install HiSuite";
            this.InstallHiSuiteBtn.Click += new System.EventHandler(this.InstallHiSuiteBtn_Click);
            // 
            // installADBbtn
            // 
            this.installADBbtn.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.installADBbtn.BackColor = System.Drawing.Color.White;
            this.installADBbtn.BeforeTouchSize = new System.Drawing.Size(159, 45);
            this.installADBbtn.ForeColor = System.Drawing.Color.Black;
            this.installADBbtn.IsBackStageButton = false;
            this.installADBbtn.Location = new System.Drawing.Point(219, 130);
            this.installADBbtn.Name = "installADBbtn";
            this.installADBbtn.Size = new System.Drawing.Size(159, 45);
            this.installADBbtn.TabIndex = 1;
            this.installADBbtn.Text = "Install ADB";
            this.installADBbtn.Click += new System.EventHandler(this.buttonAdv1_Click);
            // 
            // hue
            // 
            this.hue.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.hue.BackColor = System.Drawing.Color.White;
            this.hue.BeforeTouchSize = new System.Drawing.Size(159, 45);
            this.hue.ForeColor = System.Drawing.Color.Black;
            this.hue.IsBackStageButton = false;
            this.hue.Location = new System.Drawing.Point(219, 222);
            this.hue.Name = "hue";
            this.hue.Size = new System.Drawing.Size(159, 45);
            this.hue.TabIndex = 9;
            this.hue.Text = "Install Huawei Update Extractor";
            this.hue.Click += new System.EventHandler(this.buttonAdv3_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::Honor_7_Toolbox.Properties.Resources.huawei;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(413, 212);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(101, 103);
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Honor_7_Toolbox.Properties.Resources.adb;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(12, 103);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(174, 92);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Honor_7_Toolbox.Properties.Resources.hisuite;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(397, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 89);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // ToolsInstallMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 328);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.hue);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.installADBbtn);
            this.Controls.Add(this.InstallHiSuiteBtn);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(552, 364);
            this.MinimumSize = new System.Drawing.Size(552, 364);
            this.Name = "ToolsInstallMenu";
            this.ShowMaximizeBox = false;
            this.Text = "Tools Installation Menu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.Windows.Forms.ButtonAdv InstallHiSuiteBtn;
        private Syncfusion.Windows.Forms.ButtonAdv installADBbtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Syncfusion.Windows.Forms.ButtonAdv hue;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}