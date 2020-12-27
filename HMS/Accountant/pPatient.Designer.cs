namespace HMS.Accountant
{
    partial class pPatient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pPatient));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtgPatient = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPrintBill = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtgTest = new System.Windows.Forms.DataGridView();
            this.test = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cost_test = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_money_test = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgMedicine = new System.Windows.Forms.DataGridView();
            this.medicine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cost_medicine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_money_medicine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtTotal_money = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txtPhoneno = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.txtKeyword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPatient)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMedicine)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtgPatient);
            this.panel1.Location = new System.Drawing.Point(3, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(474, 563);
            this.panel1.TabIndex = 6;
            // 
            // dtgPatient
            // 
            this.dtgPatient.AllowUserToAddRows = false;
            this.dtgPatient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgPatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPatient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.fName,
            this.phoneno,
            this.address});
            this.dtgPatient.Location = new System.Drawing.Point(6, 3);
            this.dtgPatient.Name = "dtgPatient";
            this.dtgPatient.ReadOnly = true;
            this.dtgPatient.RowHeadersVisible = false;
            this.dtgPatient.RowHeadersWidth = 51;
            this.dtgPatient.RowTemplate.Height = 24;
            this.dtgPatient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgPatient.Size = new System.Drawing.Size(468, 557);
            this.dtgPatient.TabIndex = 0;
            this.dtgPatient.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dtgPatient_DataError);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "id";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // fName
            // 
            this.fName.DataPropertyName = "full_name";
            this.fName.HeaderText = "Họ Tên";
            this.fName.MinimumWidth = 6;
            this.fName.Name = "fName";
            this.fName.ReadOnly = true;
            // 
            // phoneno
            // 
            this.phoneno.DataPropertyName = "phone_number";
            this.phoneno.HeaderText = "Số điện thoại";
            this.phoneno.MinimumWidth = 6;
            this.phoneno.Name = "phoneno";
            this.phoneno.ReadOnly = true;
            // 
            // address
            // 
            this.address.DataPropertyName = "address";
            this.address.HeaderText = "Địa chỉ";
            this.address.MinimumWidth = 6;
            this.address.Name = "address";
            this.address.ReadOnly = true;
            // 
            // btnPrintBill
            // 
            this.btnPrintBill.Location = new System.Drawing.Point(60, 144);
            this.btnPrintBill.Name = "btnPrintBill";
            this.btnPrintBill.Size = new System.Drawing.Size(117, 75);
            this.btnPrintBill.TabIndex = 0;
            this.btnPrintBill.Text = "Thanh toán";
            this.btnPrintBill.UseVisualStyleBackColor = true;
            this.btnPrintBill.Click += new System.EventHandler(this.btnPrintBill_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtgTest);
            this.panel2.Controls.Add(this.dtgMedicine);
            this.panel2.Location = new System.Drawing.Point(483, 147);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(542, 401);
            this.panel2.TabIndex = 5;
            // 
            // dtgTest
            // 
            this.dtgTest.AllowUserToAddRows = false;
            this.dtgTest.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgTest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgTest.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.test,
            this.Column1,
            this.cost_test,
            this.total_money_test});
            this.dtgTest.Location = new System.Drawing.Point(3, 233);
            this.dtgTest.Name = "dtgTest";
            this.dtgTest.RowHeadersVisible = false;
            this.dtgTest.RowHeadersWidth = 51;
            this.dtgTest.RowTemplate.Height = 24;
            this.dtgTest.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgTest.Size = new System.Drawing.Size(536, 155);
            this.dtgTest.TabIndex = 1;
            this.dtgTest.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dtgTest_DataError);
            // 
            // test
            // 
            this.test.HeaderText = "Tên xét nghiệm";
            this.test.MinimumWidth = 6;
            this.test.Name = "test";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Số lượng";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // cost_test
            // 
            this.cost_test.HeaderText = "Giá tiền";
            this.cost_test.MinimumWidth = 6;
            this.cost_test.Name = "cost_test";
            // 
            // total_money_test
            // 
            this.total_money_test.HeaderText = "Thành tiền";
            this.total_money_test.MinimumWidth = 6;
            this.total_money_test.Name = "total_money_test";
            // 
            // dtgMedicine
            // 
            this.dtgMedicine.AllowUserToAddRows = false;
            this.dtgMedicine.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgMedicine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMedicine.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.medicine,
            this.quantity,
            this.cost_medicine,
            this.total_money_medicine});
            this.dtgMedicine.Location = new System.Drawing.Point(3, 6);
            this.dtgMedicine.Name = "dtgMedicine";
            this.dtgMedicine.RowHeadersVisible = false;
            this.dtgMedicine.RowHeadersWidth = 51;
            this.dtgMedicine.RowTemplate.Height = 24;
            this.dtgMedicine.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgMedicine.Size = new System.Drawing.Size(536, 189);
            this.dtgMedicine.TabIndex = 0;
            this.dtgMedicine.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dtgMedicine_DataError);
            // 
            // medicine
            // 
            this.medicine.HeaderText = "Tên thuốc";
            this.medicine.MinimumWidth = 6;
            this.medicine.Name = "medicine";
            // 
            // quantity
            // 
            this.quantity.HeaderText = "Số lượng";
            this.quantity.MinimumWidth = 6;
            this.quantity.Name = "quantity";
            // 
            // cost_medicine
            // 
            this.cost_medicine.HeaderText = "Giá tiền";
            this.cost_medicine.MinimumWidth = 6;
            this.cost_medicine.Name = "cost_medicine";
            // 
            // total_money_medicine
            // 
            this.total_money_medicine.HeaderText = "Thành tiền";
            this.total_money_medicine.MinimumWidth = 6;
            this.total_money_medicine.Name = "total_money_medicine";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnPrintBill);
            this.panel3.Location = new System.Drawing.Point(1034, 147);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(204, 398);
            this.panel3.TabIndex = 8;
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(149, 19);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(191, 22);
            this.txtID.TabIndex = 1;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtID);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(483, 7);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(363, 64);
            this.panel4.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txtFname);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Location = new System.Drawing.Point(483, 77);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(363, 64);
            this.panel5.TabIndex = 1;
            // 
            // txtFname
            // 
            this.txtFname.Location = new System.Drawing.Point(149, 19);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(191, 22);
            this.txtFname.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Họ Tên";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.txtTotal_money);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Location = new System.Drawing.Point(486, 560);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(536, 77);
            this.panel6.TabIndex = 7;
            // 
            // txtTotal_money
            // 
            this.txtTotal_money.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal_money.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtTotal_money.Location = new System.Drawing.Point(180, 20);
            this.txtTotal_money.Multiline = true;
            this.txtTotal_money.Name = "txtTotal_money";
            this.txtTotal_money.Size = new System.Drawing.Size(267, 39);
            this.txtTotal_money.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(77, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tổng tiền";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.txtAddress);
            this.panel7.Controls.Add(this.label4);
            this.panel7.Location = new System.Drawing.Point(852, 7);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(383, 64);
            this.panel7.TabIndex = 2;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(149, 19);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(210, 22);
            this.txtAddress.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Địa chỉ";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.txtPhoneno);
            this.panel8.Controls.Add(this.label5);
            this.panel8.Location = new System.Drawing.Point(852, 77);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(383, 64);
            this.panel8.TabIndex = 3;
            // 
            // txtPhoneno
            // 
            this.txtPhoneno.Location = new System.Drawing.Point(149, 19);
            this.txtPhoneno.Name = "txtPhoneno";
            this.txtPhoneno.Size = new System.Drawing.Size(210, 22);
            this.txtPhoneno.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Số điện thoại";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.txtKeyword);
            this.panel9.Controls.Add(this.label6);
            this.panel9.Location = new System.Drawing.Point(3, 7);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(474, 64);
            this.panel9.TabIndex = 4;
            // 
            // txtKeyword
            // 
            this.txtKeyword.Location = new System.Drawing.Point(149, 19);
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(191, 22);
            this.txtKeyword.TabIndex = 1;
            this.txtKeyword.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "TÌm kiếm";
            // 
            // pPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "pPatient";
            this.Size = new System.Drawing.Size(1238, 643);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgPatient)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgTest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMedicine)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtgPatient;
        private System.Windows.Forms.Button btnPrintBill;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtTotal_money;
        private System.Windows.Forms.Label label3;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox txtPhoneno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn fName;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneno;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridView dtgMedicine;
        private System.Windows.Forms.DataGridView dtgTest;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TextBox txtKeyword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicine;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn cost_medicine;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_money_medicine;
        private System.Windows.Forms.DataGridViewTextBoxColumn test;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cost_test;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_money_test;
    }
}
