#region Copyright Syncfusion Inc. 2001-2015.
// Copyright Syncfusion Inc. 2001-2015. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
namespace Honor_7_Toolbox
{
    partial class Recovery
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
            this.stockRecoBtn = new Syncfusion.Windows.Forms.ButtonAdv();
            this.bootRecoBtn = new Syncfusion.Windows.Forms.ButtonAdv();
            this.twrpRecoBtn = new Syncfusion.Windows.Forms.ButtonAdv();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // stockRecoBtn
            // 
            this.stockRecoBtn.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.stockRecoBtn.BackColor = System.Drawing.Color.White;
            this.stockRecoBtn.BeforeTouchSize = new System.Drawing.Size(159, 45);
            this.stockRecoBtn.ForeColor = System.Drawing.Color.Black;
            this.stockRecoBtn.IsBackStageButton = false;
            this.stockRecoBtn.Location = new System.Drawing.Point(134, 133);
            this.stockRecoBtn.Name = "stockRecoBtn";
            this.stockRecoBtn.Size = new System.Drawing.Size(159, 45);
            this.stockRecoBtn.TabIndex = 1;
            this.stockRecoBtn.Text = "Flash Stock Recovery";
            this.stockRecoBtn.Click += new System.EventHandler(this.stockRecoBtn_Click);
            // 
            // bootRecoBtn
            // 
            this.bootRecoBtn.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.bootRecoBtn.BackColor = System.Drawing.Color.White;
            this.bootRecoBtn.BeforeTouchSize = new System.Drawing.Size(159, 45);
            this.bootRecoBtn.ForeColor = System.Drawing.Color.Black;
            this.bootRecoBtn.IsBackStageButton = false;
            this.bootRecoBtn.Location = new System.Drawing.Point(134, 226);
            this.bootRecoBtn.Name = "bootRecoBtn";
            this.bootRecoBtn.Size = new System.Drawing.Size(159, 45);
            this.bootRecoBtn.TabIndex = 2;
            this.bootRecoBtn.Text = "Boot to recovery";
            this.bootRecoBtn.Click += new System.EventHandler(this.bootRecoBtn_Click);
            // 
            // twrpRecoBtn
            // 
            this.twrpRecoBtn.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.twrpRecoBtn.BackColor = System.Drawing.Color.White;
            this.twrpRecoBtn.BeforeTouchSize = new System.Drawing.Size(159, 53);
            this.twrpRecoBtn.ForeColor = System.Drawing.Color.Black;
            this.twrpRecoBtn.IsBackStageButton = false;
            this.twrpRecoBtn.Location = new System.Drawing.Point(134, 44);
            this.twrpRecoBtn.Name = "twrpRecoBtn";
            this.twrpRecoBtn.Size = new System.Drawing.Size(159, 53);
            this.twrpRecoBtn.TabIndex = 10;
            this.twrpRecoBtn.Text = "Flash TWRP";
            this.twrpRecoBtn.Click += new System.EventHandler(this.twrpRecoBtn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(299, 30);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(108, 93);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 154);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 106);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Recovery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 318);
            this.Controls.Add(this.twrpRecoBtn);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bootRecoBtn);
            this.Controls.Add(this.stockRecoBtn);
            this.MaximumSize = new System.Drawing.Size(440, 354);
            this.MinimumSize = new System.Drawing.Size(440, 354);
            this.Name = "Recovery";
            this.Text = "Recovery";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.Windows.Forms.ButtonAdv stockRecoBtn;
        private Syncfusion.Windows.Forms.ButtonAdv bootRecoBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Syncfusion.Windows.Forms.ButtonAdv twrpRecoBtn;
    }
}