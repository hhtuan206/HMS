namespace HMS.Managerment
{
    partial class pPatientReport
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.USP_ReportPatientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.HMSDataSet = new HMS.Managerment.HMSDataSet();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDay = new System.Windows.Forms.TextBox();
            this.btnView = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.USP_ReportPatientTableAdapter = new HMS.Managerment.HMSDataSetTableAdapters.USP_ReportPatientTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.USP_ReportPatientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HMSDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // USP_ReportPatientBindingSource
            // 
            this.USP_ReportPatientBindingSource.DataMember = "USP_ReportPatient";
            this.USP_ReportPatientBindingSource.DataSource = this.HMSDataSet;
            // 
            // HMSDataSet
            // 
            this.HMSDataSet.DataSetName = "HMSDataSet";
            this.HMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtDay);
            this.panel1.Controls.Add(this.btnView);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1232, 75);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(129, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Số ngày";
            // 
            // txtDay
            // 
            this.txtDay.Location = new System.Drawing.Point(229, 29);
            this.txtDay.Name = "txtDay";
            this.txtDay.Size = new System.Drawing.Size(212, 22);
            this.txtDay.TabIndex = 6;
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(614, 3);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(75, 69);
            this.btnView.TabIndex = 5;
            this.btnView.Text = "Xem";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.reportViewer1);
            this.panel2.Location = new System.Drawing.Point(3, 84);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1232, 543);
            this.panel2.TabIndex = 1;
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "HMSDS";
            reportDataSource2.Value = this.USP_ReportPatientBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "HMS.Managerment.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 3);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1226, 511);
            this.reportViewer1.TabIndex = 0;
            // 
            // USP_ReportPatientTableAdapter
            // 
            this.USP_ReportPatientTableAdapter.ClearBeforeFill = true;
            // 
            // pPatientReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "pPatientReport";
            this.Size = new System.Drawing.Size(1238, 630);
            ((System.ComponentModel.ISupportInitialize)(this.USP_ReportPatientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HMSDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDay;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource USP_ReportPatientBindingSource;
        private HMSDataSet HMSDataSet;
        private HMSDataSetTableAdapters.USP_ReportPatientTableAdapter USP_ReportPatientTableAdapter;
    }
}
