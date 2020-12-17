namespace HMS.Doctor
{
    partial class fAddTest
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
            this.bntAddOne = new System.Windows.Forms.Button();
            this.btnAddMore = new System.Windows.Forms.Button();
            this.cbTest = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bntAddOne
            // 
            this.bntAddOne.Location = new System.Drawing.Point(384, 515);
            this.bntAddOne.Name = "bntAddOne";
            this.bntAddOne.Size = new System.Drawing.Size(128, 53);
            this.bntAddOne.TabIndex = 20;
            this.bntAddOne.Text = "Lưu và thoát";
            this.bntAddOne.UseVisualStyleBackColor = true;
            this.bntAddOne.Click += new System.EventHandler(this.bntAddOne_Click);
            // 
            // btnAddMore
            // 
            this.btnAddMore.Location = new System.Drawing.Point(93, 515);
            this.btnAddMore.Name = "btnAddMore";
            this.btnAddMore.Size = new System.Drawing.Size(132, 53);
            this.btnAddMore.TabIndex = 19;
            this.btnAddMore.Text = "Lưu và thêm nữa";
            this.btnAddMore.UseVisualStyleBackColor = true;
            this.btnAddMore.Click += new System.EventHandler(this.btnAddMore_Click);
            // 
            // cbTest
            // 
            this.cbTest.FormattingEnabled = true;
            this.cbTest.Location = new System.Drawing.Point(270, 310);
            this.cbTest.Name = "cbTest";
            this.cbTest.Size = new System.Drawing.Size(121, 24);
            this.cbTest.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 310);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Test";
            // 
            // fAddTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 647);
            this.Controls.Add(this.bntAddOne);
            this.Controls.Add(this.btnAddMore);
            this.Controls.Add(this.cbTest);
            this.Controls.Add(this.label2);
            this.Name = "fAddTest";
            this.Text = "fAddTest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntAddOne;
        private System.Windows.Forms.Button btnAddMore;
        private System.Windows.Forms.ComboBox cbTest;
        private System.Windows.Forms.Label label2;
    }
}