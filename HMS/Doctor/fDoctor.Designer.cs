namespace HMS
{
    partial class fDoctor
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bệnhNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pDoctor = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bệnhNhânToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1262, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bệnhNhânToolStripMenuItem
            // 
            this.bệnhNhânToolStripMenuItem.Name = "bệnhNhânToolStripMenuItem";
            this.bệnhNhânToolStripMenuItem.Size = new System.Drawing.Size(92, 24);
            this.bệnhNhânToolStripMenuItem.Text = "Bệnh nhân";
            this.bệnhNhânToolStripMenuItem.Click += new System.EventHandler(this.bệnhNhânToolStripMenuItem_Click);
            // 
            // pDoctor
            // 
            this.pDoctor.Location = new System.Drawing.Point(12, 33);
            this.pDoctor.Name = "pDoctor";
            this.pDoctor.Size = new System.Drawing.Size(1238, 643);
            this.pDoctor.TabIndex = 1;
            // 
            // fDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.pDoctor);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fDoctor";
            this.Text = "fDoctor";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bệnhNhânToolStripMenuItem;
        private System.Windows.Forms.Panel pDoctor;
    }
}