namespace HMS.Doctor
{
    partial class fAddMedicine
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
            this.label2 = new System.Windows.Forms.Label();
            this.cbMedicine = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbTime_Of_Day = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.btnAddMore = new System.Windows.Forms.Button();
            this.bntAddOne = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(190, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Medicine";
            // 
            // cbMedicine
            // 
            this.cbMedicine.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbMedicine.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbMedicine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMedicine.FormattingEnabled = true;
            this.cbMedicine.Location = new System.Drawing.Point(311, 227);
            this.cbMedicine.Name = "cbMedicine";
            this.cbMedicine.Size = new System.Drawing.Size(121, 24);
            this.cbMedicine.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(190, 314);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Số lượng";
            // 
            // cbTime_Of_Day
            // 
            this.cbTime_Of_Day.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbTime_Of_Day.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbTime_Of_Day.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTime_Of_Day.FormattingEnabled = true;
            this.cbTime_Of_Day.Items.AddRange(new object[] {
            "1-1-1",
            "1-0-1",
            "1-1-0",
            "0-1-1",
            "0-0-1",
            "1-0-0",
            "0-1-0"});
            this.cbTime_Of_Day.Location = new System.Drawing.Point(311, 401);
            this.cbTime_Of_Day.Name = "cbTime_Of_Day";
            this.cbTime_Of_Day.Size = new System.Drawing.Size(121, 24);
            this.cbTime_Of_Day.TabIndex = 7;
            this.cbTime_Of_Day.SelectedIndexChanged += new System.EventHandler(this.cbTime_Of_Day_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(190, 401);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Time of day";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(311, 314);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(100, 22);
            this.txtQuantity.TabIndex = 8;
            this.txtQuantity.Text = "1";
            // 
            // btnAddMore
            // 
            this.btnAddMore.Location = new System.Drawing.Point(122, 585);
            this.btnAddMore.Name = "btnAddMore";
            this.btnAddMore.Size = new System.Drawing.Size(132, 53);
            this.btnAddMore.TabIndex = 9;
            this.btnAddMore.Text = "Lưu và thêm nữa";
            this.btnAddMore.UseVisualStyleBackColor = true;
            this.btnAddMore.Click += new System.EventHandler(this.btnAddMore_Click);
            // 
            // bntAddOne
            // 
            this.bntAddOne.Location = new System.Drawing.Point(413, 585);
            this.bntAddOne.Name = "bntAddOne";
            this.bntAddOne.Size = new System.Drawing.Size(128, 53);
            this.bntAddOne.TabIndex = 10;
            this.bntAddOne.Text = "Lưu và thoát";
            this.bntAddOne.UseVisualStyleBackColor = true;
            this.bntAddOne.Click += new System.EventHandler(this.bntAddOne_Click);
            // 
            // fAddMedicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 682);
            this.Controls.Add(this.bntAddOne);
            this.Controls.Add(this.btnAddMore);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.cbTime_Of_Day);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbMedicine);
            this.Controls.Add(this.label2);
            this.Name = "fAddMedicine";
            this.Text = "fAddMedicine";
            this.Load += new System.EventHandler(this.fAddMedicine_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbMedicine;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbTime_Of_Day;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Button btnAddMore;
        private System.Windows.Forms.Button bntAddOne;
    }
}