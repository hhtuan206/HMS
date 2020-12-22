namespace HMS.Accountant
{
    partial class pHistoryPatientBill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pHistoryPatientBill));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtgHistory = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtKeyWord = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnPrint = new System.Windows.Forms.Button();
            this.PrintBill = new System.Drawing.Printing.PrintDocument();
            this.fPrintBill = new System.Windows.Forms.PrintPreviewDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgHistory)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtgHistory);
            this.panel1.Location = new System.Drawing.Point(3, 122);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1011, 518);
            this.panel1.TabIndex = 0;
            // 
            // dtgHistory
            // 
            this.dtgHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.fName,
            this.address,
            this.phoneno});
            this.dtgHistory.Location = new System.Drawing.Point(3, 3);
            this.dtgHistory.MultiSelect = false;
            this.dtgHistory.Name = "dtgHistory";
            this.dtgHistory.ReadOnly = true;
            this.dtgHistory.RowHeadersVisible = false;
            this.dtgHistory.RowHeadersWidth = 51;
            this.dtgHistory.RowTemplate.Height = 24;
            this.dtgHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgHistory.Size = new System.Drawing.Size(1005, 512);
            this.dtgHistory.TabIndex = 0;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Mã bệnh nhân";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // fName
            // 
            this.fName.DataPropertyName = "full_name";
            this.fName.HeaderText = "Họ Tên";
            this.fName.MinimumWidth = 6;
            this.fName.Name = "fName";
            this.fName.ReadOnly = true;
            // 
            // address
            // 
            this.address.DataPropertyName = "address";
            this.address.HeaderText = "Địa chỉ";
            this.address.MinimumWidth = 6;
            this.address.Name = "address";
            this.address.ReadOnly = true;
            // 
            // phoneno
            // 
            this.phoneno.DataPropertyName = "phone_number";
            this.phoneno.HeaderText = "Số điện thoại";
            this.phoneno.MinimumWidth = 6;
            this.phoneno.Name = "phoneno";
            this.phoneno.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtKeyWord);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(529, 113);
            this.panel2.TabIndex = 1;
            // 
            // txtKeyWord
            // 
            this.txtKeyWord.Location = new System.Drawing.Point(194, 43);
            this.txtKeyWord.Name = "txtKeyWord";
            this.txtKeyWord.Size = new System.Drawing.Size(276, 22);
            this.txtKeyWord.TabIndex = 1;
            this.txtKeyWord.TextChanged += new System.EventHandler(this.txtKeyWord_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tìm kiếm";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnPrint);
            this.panel3.Location = new System.Drawing.Point(1020, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(215, 637);
            this.panel3.TabIndex = 2;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(69, 122);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(94, 91);
            this.btnPrint.TabIndex = 0;
            this.btnPrint.Text = "Xuẩt hoá đơn";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // PrintBill
            // 
            this.PrintBill.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintBill_PrintPage);
            // 
            // fPrintBill
            // 
            this.fPrintBill.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.fPrintBill.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.fPrintBill.ClientSize = new System.Drawing.Size(400, 300);
            this.fPrintBill.Enabled = true;
            this.fPrintBill.Icon = ((System.Drawing.Icon)(resources.GetObject("fPrintBill.Icon")));
            this.fPrintBill.Name = "fPrintBill";
            this.fPrintBill.Visible = false;
            // 
            // pHistoryPatientBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "pHistoryPatientBill";
            this.Size = new System.Drawing.Size(1238, 643);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgHistory)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtKeyWord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgHistory;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnPrint;
        private System.Drawing.Printing.PrintDocument PrintBill;
        private System.Windows.Forms.PrintPreviewDialog fPrintBill;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn fName;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneno;
    }
}
