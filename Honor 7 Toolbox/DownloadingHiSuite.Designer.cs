#region Copyright Syncfusion Inc. 2001-2015.
// Copyright Syncfusion Inc. 2001-2015. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
namespace Honor_7_Toolbox
{
    partial class DownloadingHiSuite
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
            this.progressBar = new Syncfusion.Windows.Forms.Tools.ProgressBarAdv();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.installBtn = new Syncfusion.Windows.Forms.ButtonAdv();
            this.completeLbL = new System.Windows.Forms.Label();
            this.downBtn = new Syncfusion.Windows.Forms.ButtonAdv();
            ((System.ComponentModel.ISupportInitialize)(this.progressBar)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBar
            // 
            this.progressBar.BackGradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.progressBar.BackGradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.progressBar.BackgroundStyle = Syncfusion.Windows.Forms.Tools.ProgressBarBackgroundStyles.Gradient;
            this.progressBar.BackMultipleColors = new System.Drawing.Color[0];
            this.progressBar.BackSegments = false;
            this.progressBar.BackTubeEndColor = System.Drawing.Color.White;
            this.progressBar.BackTubeStartColor = System.Drawing.Color.LightGray;
            this.progressBar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(149)))), ((int)(((byte)(152)))));
            this.progressBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.progressBar.CustomText = null;
            this.progressBar.CustomWaitingRender = false;
            this.progressBar.FontColor = System.Drawing.Color.White;
            this.progressBar.ForegroundImage = null;
            this.progressBar.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.progressBar.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.progressBar.Location = new System.Drawing.Point(57, 74);
            this.progressBar.MultipleColors = new System.Drawing.Color[0];
            this.progressBar.Name = "progressBar";
            this.progressBar.ProgressStyle = Syncfusion.Windows.Forms.Tools.ProgressBarStyles.Metro;
            this.progressBar.SegmentWidth = 12;
            this.progressBar.Size = new System.Drawing.Size(259, 38);
            this.progressBar.TabIndex = 1;
            this.progressBar.Text = "progressBar";
            this.progressBar.ThemesEnabled = false;
            this.progressBar.TubeEndColor = System.Drawing.Color.Black;
            this.progressBar.TubeStartColor = System.Drawing.Color.Red;
            this.progressBar.Value = 0;
            this.progressBar.WaitingGradientWidth = 400;
            // 
            // StatusLabel
            // 
            this.StatusLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Font = new System.Drawing.Font("Roboto Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusLabel.Location = new System.Drawing.Point(107, 35);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(120, 25);
            this.StatusLabel.TabIndex = 2;
            this.StatusLabel.Text = "Downloading";
            // 
            // installBtn
            // 
            this.installBtn.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.installBtn.BackColor = System.Drawing.Color.White;
            this.installBtn.BeforeTouchSize = new System.Drawing.Size(174, 44);
            this.installBtn.ForeColor = System.Drawing.Color.Black;
            this.installBtn.IsBackStageButton = false;
            this.installBtn.Location = new System.Drawing.Point(103, 241);
            this.installBtn.MetroColor = System.Drawing.Color.White;
            this.installBtn.Name = "installBtn";
            this.installBtn.Size = new System.Drawing.Size(174, 44);
            this.installBtn.TabIndex = 3;
            this.installBtn.Text = "Install HiSuite";
            this.installBtn.Visible = false;
            this.installBtn.Click += new System.EventHandler(this.installBtn_Click);
            // 
            // completeLbL
            // 
            this.completeLbL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.completeLbL.AutoSize = true;
            this.completeLbL.Font = new System.Drawing.Font("Roboto Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.completeLbL.Location = new System.Drawing.Point(12, 198);
            this.completeLbL.Name = "completeLbL";
            this.completeLbL.Size = new System.Drawing.Size(369, 25);
            this.completeLbL.TabIndex = 4;
            this.completeLbL.Text = "Press the install button to start installation";
            this.completeLbL.Visible = false;
            // 
            // downBtn
            // 
            this.downBtn.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.downBtn.BackColor = System.Drawing.Color.White;
            this.downBtn.BeforeTouchSize = new System.Drawing.Size(174, 44);
            this.downBtn.ForeColor = System.Drawing.Color.Black;
            this.downBtn.IsBackStageButton = false;
            this.downBtn.Location = new System.Drawing.Point(103, 118);
            this.downBtn.MetroColor = System.Drawing.Color.White;
            this.downBtn.Name = "downBtn";
            this.downBtn.Size = new System.Drawing.Size(174, 44);
            this.downBtn.TabIndex = 5;
            this.downBtn.Text = "Download it again";
            this.downBtn.Visible = false;
            this.downBtn.Click += new System.EventHandler(this.downBtn_Click);
            // 
            // DownloadingHiSuite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 297);
            this.Controls.Add(this.downBtn);
            this.Controls.Add(this.completeLbL);
            this.Controls.Add(this.installBtn);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.progressBar);
            this.Name = "DownloadingHiSuite";
            this.Text = "HiSuite Installation";
            this.Load += new System.EventHandler(this.DownloadingHiSuite_Load);
            ((System.ComponentModel.ISupportInitialize)(this.progressBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.ProgressBarAdv progressBar;
        private System.Windows.Forms.Label StatusLabel;
        private Syncfusion.Windows.Forms.ButtonAdv installBtn;
        private System.Windows.Forms.Label completeLbL;
        private Syncfusion.Windows.Forms.ButtonAdv downBtn;
    }
}