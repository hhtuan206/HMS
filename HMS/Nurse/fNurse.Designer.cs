﻿namespace HMS
{
    partial class fNurse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fNurse));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.thêmBệnhNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pNurse = new System.Windows.Forms.Panel();
            this.txtNameStaff = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmBệnhNhânToolStripMenuItem,
            this.TàiKhoảnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1262, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // thêmBệnhNhânToolStripMenuItem
            // 
            this.thêmBệnhNhânToolStripMenuItem.Name = "thêmBệnhNhânToolStripMenuItem";
            this.thêmBệnhNhânToolStripMenuItem.Size = new System.Drawing.Size(161, 24);
            this.thêmBệnhNhânToolStripMenuItem.Text = "Tiếp nhận bệnh nhân";
            this.thêmBệnhNhânToolStripMenuItem.Click += new System.EventHandler(this.thêmBệnhNhânToolStripMenuItem_Click);
            // 
            // TàiKhoảnToolStripMenuItem
            // 
            this.TàiKhoảnToolStripMenuItem.Name = "TàiKhoảnToolStripMenuItem";
            this.TàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.TàiKhoảnToolStripMenuItem.Text = "Tài khoản";
            this.TàiKhoảnToolStripMenuItem.Click += new System.EventHandler(this.TàiKhoảnToolStripMenuItem_Click);
            // 
            // pNurse
            // 
            this.pNurse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pNurse.Location = new System.Drawing.Point(12, 31);
            this.pNurse.Name = "pNurse";
            this.pNurse.Size = new System.Drawing.Size(1238, 643);
            this.pNurse.TabIndex = 1;
            // 
            // txtNameStaff
            // 
            this.txtNameStaff.Enabled = false;
            this.txtNameStaff.Location = new System.Drawing.Point(1095, 0);
            this.txtNameStaff.Name = "txtNameStaff";
            this.txtNameStaff.Size = new System.Drawing.Size(155, 22);
            this.txtNameStaff.TabIndex = 2;
            this.txtNameStaff.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // fNurse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.txtNameStaff);
            this.Controls.Add(this.pNurse);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "fNurse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Y tá";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem thêmBệnhNhânToolStripMenuItem;
        private System.Windows.Forms.Panel pNurse;
        private System.Windows.Forms.ToolStripMenuItem TàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.TextBox txtNameStaff;
    }
}