namespace HMS.Managerment
{
    partial class pPatientByTime
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.rp = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btnView = new System.Windows.Forms.Button();
            this.HMSDataSet = new HMS.Managerment.HMSDataSet();
            this.USP_PatientReportByTimeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.USP_PatientReportByTimeTableAdapter = new HMS.Managerment.HMSDataSetTableAdapters.USP_PatientReportByTimeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.HMSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.USP_PatientReportByTimeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rp
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.USP_PatientReportByTimeBindingSource;
            this.rp.LocalReport.DataSources.Add(reportDataSource1);
            this.rp.LocalReport.ReportEmbeddedResource = "HMS.Managerment.Report2.rdlc";
            this.rp.Location = new System.Drawing.Point(3, 130);
            this.rp.Name = "rp";
            this.rp.ServerReport.BearerToken = null;
            this.rp.Size = new System.Drawing.Size(1347, 504);
            this.rp.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(205, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Từ";
            // 
            // dtpStart
            // 
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStart.Location = new System.Drawing.Point(336, 68);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(200, 22);
            this.dtpStart.TabIndex = 2;
            // 
            // dtpEnd
            // 
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEnd.Location = new System.Drawing.Point(752, 68);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(200, 22);
            this.dtpEnd.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(621, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "đến";
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(1060, 56);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(75, 44);
            this.btnView.TabIndex = 5;
            this.btnView.Text = "Xem";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // HMSDataSet
            // 
            this.HMSDataSet.DataSetName = "HMSDataSet";
            this.HMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // USP_PatientReportByTimeBindingSource
            // 
            this.USP_PatientReportByTimeBindingSource.DataMember = "USP_PatientReportByTime";
            this.USP_PatientReportByTimeBindingSource.DataSource = this.HMSDataSet;
            // 
            // USP_PatientReportByTimeTableAdapter
            // 
            this.USP_PatientReportByTimeTableAdapter.ClearBeforeFill = true;
            // 
            // pPatientByTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rp);
            this.Name = "pPatientByTime";
            this.Size = new System.Drawing.Size(1353, 637);
            ((System.ComponentModel.ISupportInitialize)(this.HMSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.USP_PatientReportByTimeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.BindingSource USP_PatientReportByTimeBindingSource;
        private HMSDataSet HMSDataSet;
        private HMSDataSetTableAdapters.USP_PatientReportByTimeTableAdapter USP_PatientReportByTimeTableAdapter;
    }
}
