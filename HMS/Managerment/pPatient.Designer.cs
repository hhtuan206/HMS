namespace HMS
{
    partial class pStar
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
            this.flpBed = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbIdBed = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbWard = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listService = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpBed
            // 
            this.flpBed.Location = new System.Drawing.Point(3, 3);
            this.flpBed.Name = "flpBed";
            this.flpBed.Size = new System.Drawing.Size(645, 624);
            this.flpBed.TabIndex = 0;
            this.flpBed.Paint += new System.Windows.Forms.PaintEventHandler(this.flpBed_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbIdBed);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbWard);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Location = new System.Drawing.Point(654, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(581, 84);
            this.panel1.TabIndex = 1;
            // 
            // cbIdBed
            // 
            this.cbIdBed.FormattingEnabled = true;
            this.cbIdBed.Location = new System.Drawing.Point(124, 17);
            this.cbIdBed.Name = "cbIdBed";
            this.cbIdBed.Size = new System.Drawing.Size(263, 24);
            this.cbIdBed.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Khu vực";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã giường";
            // 
            // cbWard
            // 
            this.cbWard.FormattingEnabled = true;
            this.cbWard.Location = new System.Drawing.Point(124, 57);
            this.cbWard.Name = "cbWard";
            this.cbWard.Size = new System.Drawing.Size(263, 24);
            this.cbWard.TabIndex = 2;
            this.cbWard.SelectedIndexChanged += new System.EventHandler(this.cbWard_SelectedIndexChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(488, 14);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 52);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Xem";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.listService);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtPrice);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtName);
            this.panel2.Location = new System.Drawing.Point(654, 90);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(581, 537);
            this.panel2.TabIndex = 2;
            // 
            // listService
            // 
            this.listService.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader4});
            this.listService.HideSelection = false;
            this.listService.Location = new System.Drawing.Point(0, 71);
            this.listService.Name = "listService";
            this.listService.Size = new System.Drawing.Size(575, 463);
            this.listService.TabIndex = 5;
            this.listService.UseCompatibleStateImageBehavior = false;
            this.listService.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Dịch vụ";
            this.columnHeader1.Width = 244;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "GIá tiền";
            this.columnHeader4.Width = 106;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(291, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tổng tiền";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(291, 43);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(188, 22);
            this.txtPrice.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Họ Tên";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(3, 43);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(188, 22);
            this.txtName.TabIndex = 1;
            // 
            // pStar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flpBed);
            this.Name = "pStar";
            this.Size = new System.Drawing.Size(1238, 630);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpBed;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbWard;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cbIdBed;
        private System.Windows.Forms.ListView listService;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}
