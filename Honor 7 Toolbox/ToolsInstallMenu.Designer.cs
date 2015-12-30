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
            this.buttonAdv1 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.buttonAdv2 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.SuspendLayout();
            // 
            // InstallHiSuiteBtn
            // 
            this.InstallHiSuiteBtn.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.InstallHiSuiteBtn.BackColor = System.Drawing.Color.White;
            this.InstallHiSuiteBtn.BeforeTouchSize = new System.Drawing.Size(159, 45);
            this.InstallHiSuiteBtn.ForeColor = System.Drawing.Color.Black;
            this.InstallHiSuiteBtn.IsBackStageButton = false;
            this.InstallHiSuiteBtn.Location = new System.Drawing.Point(170, 91);
            this.InstallHiSuiteBtn.Name = "InstallHiSuiteBtn";
            this.InstallHiSuiteBtn.Size = new System.Drawing.Size(159, 45);
            this.InstallHiSuiteBtn.TabIndex = 0;
            this.InstallHiSuiteBtn.Text = "Install HiSuite";
            this.InstallHiSuiteBtn.Click += new System.EventHandler(this.InstallHiSuiteBtn_Click);
            // 
            // buttonAdv1
            // 
            this.buttonAdv1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.buttonAdv1.BackColor = System.Drawing.Color.White;
            this.buttonAdv1.BeforeTouchSize = new System.Drawing.Size(159, 45);
            this.buttonAdv1.ForeColor = System.Drawing.Color.Black;
            this.buttonAdv1.IsBackStageButton = false;
            this.buttonAdv1.Location = new System.Drawing.Point(170, 164);
            this.buttonAdv1.Name = "buttonAdv1";
            this.buttonAdv1.Size = new System.Drawing.Size(159, 45);
            this.buttonAdv1.TabIndex = 1;
            this.buttonAdv1.Text = "Install ADB";
            this.buttonAdv1.Click += new System.EventHandler(this.buttonAdv1_Click);
            // 
            // buttonAdv2
            // 
            this.buttonAdv2.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.buttonAdv2.BackColor = System.Drawing.Color.White;
            this.buttonAdv2.BeforeTouchSize = new System.Drawing.Size(159, 45);
            this.buttonAdv2.ForeColor = System.Drawing.Color.Black;
            this.buttonAdv2.IsBackStageButton = false;
            this.buttonAdv2.Location = new System.Drawing.Point(170, 232);
            this.buttonAdv2.Name = "buttonAdv2";
            this.buttonAdv2.Size = new System.Drawing.Size(159, 45);
            this.buttonAdv2.TabIndex = 2;
            this.buttonAdv2.Text = "Go Back";
            // 
            // ToolsInstallMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 375);
            this.Controls.Add(this.buttonAdv2);
            this.Controls.Add(this.buttonAdv1);
            this.Controls.Add(this.InstallHiSuiteBtn);
            this.Name = "ToolsInstallMenu";
            this.Text = "Tools Installation Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.Windows.Forms.ButtonAdv InstallHiSuiteBtn;
        private Syncfusion.Windows.Forms.ButtonAdv buttonAdv1;
        private Syncfusion.Windows.Forms.ButtonAdv buttonAdv2;
    }
}