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
            this.dtgAmitPatient = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Po = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPathological = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnDeleteMedicine = new System.Windows.Forms.Button();
            this.btnAddMedicine = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dtgTest = new System.Windows.Forms.DataGridView();
            this.id_test = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.test = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtgMedicine = new System.Windows.Forms.DataGridView();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.time_of_day = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_medicine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAmitPatient)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTest)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMedicine)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtgAmitPatient);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(505, 637);
            this.panel1.TabIndex = 0;
            // 
            // dtgAmitPatient
            // 
            this.dtgAmitPatient.AllowUserToAddRows = false;
            this.dtgAmitPatient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgAmitPatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgAmitPatient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.fName,
            this.Po,
            this.Column6});
            this.dtgAmitPatient.Dock = System.Windows.Forms.DockStyle.Left;
            this.dtgAmitPatient.Location = new System.Drawing.Point(0, 0);
            this.dtgAmitPatient.Name = "dtgAmitPatient";
            this.dtgAmitPatient.RowHeadersVisible = false;
            this.dtgAmitPatient.RowHeadersWidth = 51;
            this.dtgAmitPatient.RowTemplate.Height = 24;
            this.dtgAmitPatient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgAmitPatient.Size = new System.Drawing.Size(499, 637);
            this.dtgAmitPatient.TabIndex = 0;
            this.dtgAmitPatient.SelectionChanged += new System.EventHandler(this.dtgAmitPatient_SelectionChanged);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "id";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            // 
            // fName
            // 
            this.fName.DataPropertyName = "full_name";
            this.fName.HeaderText = "Họ Tên";
            this.fName.MinimumWidth = 6;
            this.fName.Name = "fName";
            // 
            // Po
            // 
            this.Po.DataPropertyName = "pathological";
            this.Po.HeaderText = "Triệu chứng";
            this.Po.MinimumWidth = 6;
            this.Po.Name = "Po";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "id_bill";
            this.Column6.HeaderText = "Hoá đơn";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel9);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.panel8);
            this.panel2.Location = new System.Drawing.Point(514, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(721, 637);
            this.panel2.TabIndex = 1;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.label5);
            this.panel9.Controls.Add(this.txtPathological);
            this.panel9.Location = new System.Drawing.Point(6, 82);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(318, 122);
            this.panel9.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Triệu chứng";
            // 
            // txtPathological
            // 
            this.txtPathological.Location = new System.Drawing.Point(114, 23);
            this.txtPathological.Multiline = true;
            this.txtPathological.Name = "txtPathological";
            this.txtPathological.Size = new System.Drawing.Size(189, 81);
            this.txtPathological.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(587, 553);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(134, 81);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button3);
            this.panel4.Controls.Add(this.button4);
            this.panel4.Controls.Add(this.btnDeleteMedicine);
            this.panel4.Controls.Add(this.btnAddMedicine);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Location = new System.Drawing.Point(6, 210);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(712, 333);
            this.panel4.TabIndex = 11;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(552, 9);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 81);
            this.button3.TabIndex = 15;
            this.button3.Text = "Xoá";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(431, 6);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 81);
            this.button4.TabIndex = 14;
            this.button4.Text = "Thêm";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnDeleteMedicine
            // 
            this.btnDeleteMedicine.Location = new System.Drawing.Point(174, 3);
            this.btnDeleteMedicine.Name = "btnDeleteMedicine";
            this.btnDeleteMedicine.Size = new System.Drawing.Size(75, 81);
            this.btnDeleteMedicine.TabIndex = 13;
            this.btnDeleteMedicine.Text = "Xoá";
            this.btnDeleteMedicine.UseVisualStyleBackColor = true;
            this.btnDeleteMedicine.Click += new System.EventHandler(this.btnDeleteMedicine_Click);
            // 
            // btnAddMedicine
            // 
            this.btnAddMedicine.Location = new System.Drawing.Point(51, 0);
            this.btnAddMedicine.Name = "btnAddMedicine";
            this.btnAddMedicine.Size = new System.Drawing.Size(75, 81);
            this.btnAddMedicine.TabIndex = 12;
            this.btnAddMedicine.Text = "Thêm";
            this.btnAddMedicine.UseVisualStyleBackColor = true;
            this.btnAddMedicine.Click += new System.EventHandler(this.btnAddMedicine_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dtgTest);
            this.panel5.Location = new System.Drawing.Point(369, 90);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(340, 240);
            this.panel5.TabIndex = 11;
            // 
            // dtgTest
            // 
            this.dtgTest.AllowUserToAddRows = false;
            this.dtgTest.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgTest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgTest.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_test,
            this.test});
            this.dtgTest.Location = new System.Drawing.Point(3, 3);
            this.dtgTest.Name = "dtgTest";
            this.dtgTest.RowHeadersVisible = false;
            this.dtgTest.RowHeadersWidth = 51;
            this.dtgTest.RowTemplate.Height = 24;
            this.dtgTest.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgTest.Size = new System.Drawing.Size(334, 234);
            this.dtgTest.TabIndex = 0;
            // 
            // id_test
            // 
            this.id_test.HeaderText = "Mã Xét Nghiệm";
            this.id_test.MinimumWidth = 6;
            this.id_test.Name = "id_test";
            this.id_test.Visible = false;
            // 
            // test
            // 
            this.test.HeaderText = "Tên xét nghiệm";
            this.test.MinimumWidth = 6;
            this.test.Name = "test";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dtgMedicine);
            this.panel3.Location = new System.Drawing.Point(3, 90);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(360, 240);
            this.panel3.TabIndex = 10;
            // 
            // dtgMedicine
            // 
            this.dtgMedicine.AllowUserToAddRows = false;
            this.dtgMedicine.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgMedicine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMedicine.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_medicine,
            this.medicine,
            this.quantity,
            this.time_of_day});
            this.dtgMedicine.Location = new System.Drawing.Point(3, 3);
            this.dtgMedicine.Name = "dtgMedicine";
            this.dtgMedicine.RowHeadersVisible = false;
            this.dtgMedicine.RowHeadersWidth = 51;
            this.dtgMedicine.RowTemplate.Height = 24;
            this.dtgMedicine.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgMedicine.Size = new System.Drawing.Size(354, 234);
            this.dtgMedicine.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.label2);
            this.panel7.Controls.Add(this.txtID);
            this.panel7.Location = new System.Drawing.Point(6, -5);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(318, 81);
            this.panel7.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(84, 26);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(189, 22);
            this.txtID.TabIndex = 1;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.label1);
            this.panel8.Controls.Add(this.txtFname);
            this.panel8.Location = new System.Drawing.Point(330, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(306, 76);
            this.panel8.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ tên ";
            // 
            // txtFname
            // 
            this.txtFname.Location = new System.Drawing.Point(84, 26);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(189, 22);
            this.txtFname.TabIndex = 1;
            // 
            // time_of_day
            // 
            this.time_of_day.HeaderText = "Thờii gian sử dụng";
            this.time_of_day.MinimumWidth = 6;
            this.time_of_day.Name = "time_of_day";
            // 
            // quantity
            // 
            this.quantity.HeaderText = "Số lượng";
            this.quantity.MinimumWidth = 6;
            this.quantity.Name = "quantity";
            // 
            // medicine
            // 
            this.medicine.HeaderText = "Tên thuốc";
            this.medicine.MinimumWidth = 6;
            this.medicine.Name = "medicine";
            // 
            // id_medicine
            // 
            this.id_medicine.HeaderText = "ID thuốc";
            this.id_medicine.MinimumWidth = 6;
            this.id_medicine.Name = "id_medicine";
            this.id_medicine.Visible = false;
            // 
            // pPatients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "pPatients";
            this.Size = new System.Drawing.Size(1238, 643);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgAmitPatient)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgTest)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgMedicine)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtgAmitPatient;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPathological;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn fName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Po;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnDeleteMedicine;
        private System.Windows.Forms.Button btnAddMedicine;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dtgTest;
        private System.Windows.Forms.DataGridView dtgMedicine;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_test;
        private System.Windows.Forms.DataGridViewTextBoxColumn test;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_medicine;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicine;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn time_of_day;
    }
}
