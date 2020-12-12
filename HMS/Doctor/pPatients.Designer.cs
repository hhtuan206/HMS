namespace HMS
{
    partial class pPatients
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtgAcpPatient = new System.Windows.Forms.DataGridView();
            this.btnAcp = new System.Windows.Forms.Button();
            this.btnDetail = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtgWaitPatient = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAcpPatient)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgWaitPatient)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtgAcpPatient);
            this.panel1.Location = new System.Drawing.Point(3, 154);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(602, 486);
            this.panel1.TabIndex = 0;
            // 
            // dtgAcpPatient
            // 
            this.dtgAcpPatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgAcpPatient.Dock = System.Windows.Forms.DockStyle.Left;
            this.dtgAcpPatient.Location = new System.Drawing.Point(0, 0);
            this.dtgAcpPatient.Name = "dtgAcpPatient";
            this.dtgAcpPatient.RowHeadersWidth = 51;
            this.dtgAcpPatient.RowTemplate.Height = 24;
            this.dtgAcpPatient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgAcpPatient.Size = new System.Drawing.Size(597, 486);
            this.dtgAcpPatient.TabIndex = 0;
            // 
            // btnAcp
            // 
            this.btnAcp.Location = new System.Drawing.Point(861, 88);
            this.btnAcp.Name = "btnAcp";
            this.btnAcp.Size = new System.Drawing.Size(75, 23);
            this.btnAcp.TabIndex = 2;
            this.btnAcp.Text = "Accept";
            this.btnAcp.UseVisualStyleBackColor = true;
            this.btnAcp.Click += new System.EventHandler(this.btnAcp_Click);
            // 
            // btnDetail
            // 
            this.btnDetail.Location = new System.Drawing.Point(226, 88);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(112, 23);
            this.btnDetail.TabIndex = 3;
            this.btnDetail.Text = "DetailPatient";
            this.btnDetail.UseVisualStyleBackColor = true;
            this.btnDetail.Click += new System.EventHandler(this.btnDetail_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtgWaitPatient);
            this.panel2.Location = new System.Drawing.Point(623, 154);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(602, 486);
            this.panel2.TabIndex = 4;
            // 
            // dtgWaitPatient
            // 
            this.dtgWaitPatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgWaitPatient.Dock = System.Windows.Forms.DockStyle.Left;
            this.dtgWaitPatient.Location = new System.Drawing.Point(0, 0);
            this.dtgWaitPatient.Name = "dtgWaitPatient";
            this.dtgWaitPatient.RowHeadersWidth = 51;
            this.dtgWaitPatient.RowTemplate.Height = 24;
            this.dtgWaitPatient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgWaitPatient.Size = new System.Drawing.Size(597, 486);
            this.dtgWaitPatient.TabIndex = 0;
            // 
            // pPatients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnDetail);
            this.Controls.Add(this.btnAcp);
            this.Controls.Add(this.panel1);
            this.Name = "pPatients";
            this.Size = new System.Drawing.Size(1238, 643);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgAcpPatient)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgWaitPatient)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtgAcpPatient;
        private System.Windows.Forms.Button btnAcp;
        private System.Windows.Forms.Button btnDetail;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dtgWaitPatient;
    }
}
