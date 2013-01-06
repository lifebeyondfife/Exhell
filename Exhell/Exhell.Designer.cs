/*
  Copyright © Iain McDonald 2011
  
  This file is part of Exhell.

    Foobar is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    Foobar is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with Exhell.  If not, see <http://www.gnu.org/licenses/>.
*/
namespace Exhell
{
    partial class Exhell
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Exhell));
            this.excelDate = new System.Windows.Forms.NotifyIcon(this.components);
            this.exhellContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exhellExit = new System.Windows.Forms.ToolStripMenuItem();
            this.exhellToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.exhellConvertClip = new System.Windows.Forms.ToolStripMenuItem();
            this.exhellContext.SuspendLayout();
            this.SuspendLayout();
            // 
            // excelDate
            // 
            this.excelDate.ContextMenuStrip = this.exhellContext;
            this.excelDate.Icon = ((System.Drawing.Icon)(resources.GetObject("excelDate.Icon")));
            this.excelDate.Text = "Exhell";
            this.excelDate.Visible = true;
            this.excelDate.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ConvertClipboardData);
            this.excelDate.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ExcelDate_MouseMove);
            // 
            // exhellContext
            // 
            this.exhellContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exhellExit,
            this.exhellToolStrip,
            this.exhellConvertClip});
            this.exhellContext.Name = "exhellContext";
            this.exhellContext.Size = new System.Drawing.Size(199, 70);
            // 
            // exhellExit
            // 
            this.exhellExit.Name = "exhellExit";
            this.exhellExit.Size = new System.Drawing.Size(198, 22);
            this.exhellExit.Text = "Exit Exhell";
            this.exhellExit.Click += new System.EventHandler(this.ExhellExit_Click);
            // 
            // exhellConfigure
            // 
            this.exhellToolStrip.Name = "exhellConfigure";
            this.exhellToolStrip.Size = new System.Drawing.Size(198, 22);
            this.exhellToolStrip.Text = "About Exhell";
            this.exhellToolStrip.Click += new System.EventHandler(this.ExhellAbout_Click);
            // 
            // exhellCopyClip
            // 
            this.exhellConvertClip.Name = "exhellCopyClip";
            this.exhellConvertClip.Size = new System.Drawing.Size(198, 22);
            this.exhellConvertClip.Text = "Convert Clipboard Data";
            this.exhellConvertClip.Click += new System.EventHandler(this.ConvertClipboardData);
            // 
            // Exhell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 83);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Exhell";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exhell - The Excel Date Converter";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Exhell_Closing);
            this.Shown += new System.EventHandler(this.Exhell_Shown);
            this.Resize += new System.EventHandler(this.ExhellResize);
            this.exhellContext.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
   
        private System.Windows.Forms.NotifyIcon excelDate;
        private System.Windows.Forms.ToolStripMenuItem exhellToolStrip;
        private System.Windows.Forms.ContextMenuStrip exhellContext;
        private System.Windows.Forms.ToolStripMenuItem exhellConvertClip;
        private System.Windows.Forms.ToolStripMenuItem exhellExit;
    }
}

