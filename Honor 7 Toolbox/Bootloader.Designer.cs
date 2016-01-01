#region Copyright Syncfusion Inc. 2001-2015.
// Copyright Syncfusion Inc. 2001-2015. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
namespace Honor_7_Toolbox
{
    partial class Bootloader
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
            this.unlockBootloaderBtn = new Syncfusion.Windows.Forms.ButtonAdv();
            this.lockBootloaderBtn = new Syncfusion.Windows.Forms.ButtonAdv();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.getCodeBtn = new Syncfusion.Windows.Forms.ButtonAdv();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // unlockBootloaderBtn
            // 
            this.unlockBootloaderBtn.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.unlockBootloaderBtn.BackColor = System.Drawing.Color.White;
            this.unlockBootloaderBtn.BeforeTouchSize = new System.Drawing.Size(159, 45);
            this.unlockBootloaderBtn.ForeColor = System.Drawing.Color.Black;
            this.unlockBootloaderBtn.IsBackStageButton = false;
            this.unlockBootloaderBtn.Location = new System.Drawing.Point(134, 133);
            this.unlockBootloaderBtn.Name = "unlockBootloaderBtn";
            this.unlockBootloaderBtn.Size = new System.Drawing.Size(159, 45);
            this.unlockBootloaderBtn.TabIndex = 1;
            this.unlockBootloaderBtn.Text = "Unlock Bootloader";
            this.unlockBootloaderBtn.Click += new System.EventHandler(this.unlockBootloaderBtn_Click);
            // 
            // lockBootloaderBtn
            // 
            this.lockBootloaderBtn.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.lockBootloaderBtn.BackColor = System.Drawing.Color.White;
            this.lockBootloaderBtn.BeforeTouchSize = new System.Drawing.Size(159, 45);
            this.lockBootloaderBtn.ForeColor = System.Drawing.Color.Black;
            this.lockBootloaderBtn.IsBackStageButton = false;
            this.lockBootloaderBtn.Location = new System.Drawing.Point(134, 226);
            this.lockBootloaderBtn.Name = "lockBootloaderBtn";
            this.lockBootloaderBtn.Size = new System.Drawing.Size(159, 45);
            this.lockBootloaderBtn.TabIndex = 2;
            this.lockBootloaderBtn.Text = "Lock Bootloader";
            this.lockBootloaderBtn.Click += new System.EventHandler(this.lockBootloaderBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Honor_7_Toolbox.Properties.Resources.unlockbootloader;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 217);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 80);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Honor_7_Toolbox.Properties.Resources.lockbootloader;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(317, 114);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(90, 80);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // getCodeBtn
            // 
            this.getCodeBtn.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.getCodeBtn.BackColor = System.Drawing.Color.White;
            this.getCodeBtn.BeforeTouchSize = new System.Drawing.Size(159, 53);
            this.getCodeBtn.ForeColor = System.Drawing.Color.Black;
            this.getCodeBtn.IsBackStageButton = false;
            this.getCodeBtn.Location = new System.Drawing.Point(134, 44);
            this.getCodeBtn.Name = "getCodeBtn";
            this.getCodeBtn.Size = new System.Drawing.Size(159, 53);
            this.getCodeBtn.TabIndex = 10;
            this.getCodeBtn.Text = "Get the Unlock Code and Instructions";
            this.getCodeBtn.Click += new System.EventHandler(this.getCodeBtn_Click);
            // 
            // Bootloader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 318);
            this.Controls.Add(this.getCodeBtn);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lockBootloaderBtn);
            this.Controls.Add(this.unlockBootloaderBtn);
            this.MaximumSize = new System.Drawing.Size(440, 354);
            this.MinimumSize = new System.Drawing.Size(440, 354);
            this.Name = "Bootloader";
            this.Text = "Bootloader";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.Windows.Forms.ButtonAdv unlockBootloaderBtn;
        private Syncfusion.Windows.Forms.ButtonAdv lockBootloaderBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Syncfusion.Windows.Forms.ButtonAdv getCodeBtn;
    }
}