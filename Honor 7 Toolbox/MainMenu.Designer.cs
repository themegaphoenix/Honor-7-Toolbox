#region Copyright Syncfusion Inc. 2001-2015.
// Copyright Syncfusion Inc. 2001-2015. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
namespace Honor_7_Toolbox
{
    partial class MainMenu
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
            this.tileLayout1 = new Syncfusion.Windows.Forms.Tools.TileLayout();
            this.StartBtn = new Syncfusion.Windows.Forms.ButtonAdv();
            this.bootloaderBtn = new Syncfusion.Windows.Forms.ButtonAdv();
            ((System.ComponentModel.ISupportInitialize)(this.tileLayout1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileLayout1.MainLayout)).BeginInit();
            this.SuspendLayout();
            // 
            // tileLayout1
            // 
            this.tileLayout1.AllowNewGroup = false;
            this.tileLayout1.AutoScroll = true;
            this.tileLayout1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tileLayout1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tileLayout1.ExitButtonImage = null;
            this.tileLayout1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileLayout1.Items = 0;
            this.tileLayout1.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.tileLayout1.MainLayout.ContainerControl = this.tileLayout1;
            this.tileLayout1.MainLayout.HGap = 75;
            this.tileLayout1.MainLayout.HorzNearMargin = 100;
            this.tileLayout1.MainLayout.LayoutMode = Syncfusion.Windows.Forms.Tools.FlowLayoutMode.Vertical;
            this.tileLayout1.MainLayout.TopMargin = 100;
            this.tileLayout1.MainLayout.VGap = 75;
            this.tileLayout1.Name = "tileLayout1";
            this.tileLayout1.NewGroupButtonImage = null;
            this.tileLayout1.NewGroupIndicatorColor = System.Drawing.Color.Black;
            this.tileLayout1.SetParentFormFlat = false;
            this.tileLayout1.ShowGroupTitle = false;
            this.tileLayout1.ShowItemPreview = false;
            this.tileLayout1.ShowPreviewButtonImage = null;
            this.tileLayout1.Size = new System.Drawing.Size(663, 479);
            this.tileLayout1.TabIndex = 0;
            this.tileLayout1.TextAlignment = Syncfusion.Windows.Forms.Tools.TextAlignment.Left;
            this.tileLayout1.TitleFont = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileLayout1.Transparency = 10;
            // 
            // StartBtn
            // 
            this.StartBtn.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.StartBtn.BackColor = System.Drawing.Color.Transparent;
            this.StartBtn.BackgroundImage = global::Honor_7_Toolbox.Properties.Resources.Tools;
            this.StartBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.StartBtn.BeforeTouchSize = new System.Drawing.Size(118, 122);
            this.StartBtn.Font = new System.Drawing.Font("Roboto Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartBtn.ForeColor = System.Drawing.Color.Black;
            this.StartBtn.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.StartBtn.IsBackStageButton = false;
            this.StartBtn.Location = new System.Drawing.Point(27, 51);
            this.StartBtn.MetroColor = System.Drawing.Color.White;
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(118, 122);
            this.StartBtn.TabIndex = 1;
            this.StartBtn.Text = "Install tools";
            this.StartBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.StartBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.StartBtn.UseVisualStyle = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // bootloaderBtn
            // 
            this.bootloaderBtn.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.bootloaderBtn.BackColor = System.Drawing.Color.Transparent;
            this.bootloaderBtn.BackgroundImage = global::Honor_7_Toolbox.Properties.Resources.Tools;
            this.bootloaderBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bootloaderBtn.BeforeTouchSize = new System.Drawing.Size(118, 122);
            this.bootloaderBtn.Font = new System.Drawing.Font("Roboto Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bootloaderBtn.ForeColor = System.Drawing.Color.Black;
            this.bootloaderBtn.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bootloaderBtn.IsBackStageButton = false;
            this.bootloaderBtn.Location = new System.Drawing.Point(192, 51);
            this.bootloaderBtn.MetroColor = System.Drawing.Color.White;
            this.bootloaderBtn.Name = "bootloaderBtn";
            this.bootloaderBtn.Size = new System.Drawing.Size(118, 122);
            this.bootloaderBtn.TabIndex = 2;
            this.bootloaderBtn.Text = "Bootloader";
            this.bootloaderBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bootloaderBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.bootloaderBtn.UseVisualStyle = true;
            this.bootloaderBtn.Click += new System.EventHandler(this.bootloaderBtn_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 479);
            this.Controls.Add(this.bootloaderBtn);
            this.Controls.Add(this.StartBtn);
            this.Controls.Add(this.tileLayout1);
            this.Name = "MainMenu";
            this.Text = "MetroForm1";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tileLayout1.MainLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileLayout1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.TileLayout tileLayout1;
        private Syncfusion.Windows.Forms.ButtonAdv StartBtn;
        private Syncfusion.Windows.Forms.ButtonAdv bootloaderBtn;
    }
}