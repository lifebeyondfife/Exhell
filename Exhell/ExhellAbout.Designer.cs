/*
  Copyright © Iain McDonald 2011
  
  This file is part of Exhell.

    Exhell is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    Exhell is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with Exhell.  If not, see <http://www.gnu.org/licenses/>.
*/
namespace Exhell
{
    partial class ExhellAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExhellAbout));
            this.exhellCopyLabel = new System.Windows.Forms.Label();
            this.exhellAboutLink = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // exhellCopyLabel
            // 
            this.exhellCopyLabel.AutoSize = true;
            this.exhellCopyLabel.Location = new System.Drawing.Point(101, 61);
            this.exhellCopyLabel.Name = "exhellCopyLabel";
            this.exhellCopyLabel.Size = new System.Drawing.Size(162, 13);
            this.exhellCopyLabel.TabIndex = 2;
            this.exhellCopyLabel.Text = "Copyright © Iain McDonald 2011";
            // 
            // exhellAboutLink
            // 
            this.exhellAboutLink.ActiveLinkColor = System.Drawing.Color.Blue;
            this.exhellAboutLink.AutoSize = true;
            this.exhellAboutLink.Location = new System.Drawing.Point(12, 9);
            this.exhellAboutLink.Name = "exhellAboutLink";
            this.exhellAboutLink.Size = new System.Drawing.Size(155, 13);
            this.exhellAboutLink.TabIndex = 3;
            this.exhellAboutLink.TabStop = true;
            this.exhellAboutLink.Text = "http://www.lifebeyondfife.com/";
            this.exhellAboutLink.UseWaitCursor = true;
            this.exhellAboutLink.VisitedLinkColor = System.Drawing.Color.Blue;
            this.exhellAboutLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ExhellAboutLink_LinkClicked);
            // 
            // ExhellAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 83);
            this.Controls.Add(this.exhellAboutLink);
            this.Controls.Add(this.exhellCopyLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ExhellAbout";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exhell - The Excel Date Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label exhellCopyLabel;
        private System.Windows.Forms.LinkLabel exhellAboutLink;
    }
}