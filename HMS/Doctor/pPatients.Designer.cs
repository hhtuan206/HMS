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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPathological = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtgService = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSname = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Po = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAmitPatient)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgService)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
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
            this.dtgAmitPatient.RowHeadersWidth = 51;
            this.dtgAmitPatient.RowTemplate.Height = 24;
            this.dtgAmitPatient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgAmitPatient.Size = new System.Drawing.Size(499, 637);
            this.dtgAmitPatient.TabIndex = 0;
            this.dtgAmitPatient.SelectionChanged += new System.EventHandler(this.dtgAmitPatient_SelectionChanged);
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
            this.btnSave.Location = new System.Drawing.Point(6, 546);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(635, 81);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnDel);
            this.panel4.Controls.Add(this.btnAdd);
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Location = new System.Drawing.Point(6, 210);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(635, 333);
            this.panel4.TabIndex = 11;
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(511, 230);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 81);
            this.btnDel.TabIndex = 6;
            this.btnDel.Text = "Xoá";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click_1);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(511, 112);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 81);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dtgService);
            this.panel3.Location = new System.Drawing.Point(3, 90);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(494, 240);
            this.panel3.TabIndex = 10;
            // 
            // dtgService
            // 
            this.dtgService.AllowUserToAddRows = false;
            this.dtgService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgService.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dtgService.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgService.Location = new System.Drawing.Point(0, 0);
            this.dtgService.Name = "dtgService";
            this.dtgService.RowHeadersWidth = 51;
            this.dtgService.RowTemplate.Height = 24;
            this.dtgService.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgService.Size = new System.Drawing.Size(494, 240);
            this.dtgService.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "a";
            this.Column1.HeaderText = "Tên dịch vụ";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "b";
            this.Column2.HeaderText = "Giá cả";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.txtCost);
            this.panel6.Location = new System.Drawing.Point(324, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(306, 81);
            this.panel6.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Đơn giá";
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(100, 26);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(189, 22);
            this.txtCost.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.txtSname);
            this.panel5.Location = new System.Drawing.Point(7, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(311, 81);
            this.panel5.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên dịch vụ";
            // 
            // txtSname
            // 
            this.txtSname.Location = new System.Drawing.Point(100, 26);
            this.txtSname.Name = "txtSname";
            this.txtSname.Size = new System.Drawing.Size(189, 22);
            this.txtSname.TabIndex = 1;
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
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgService)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
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
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dtgService;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSname;
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
    }
}
