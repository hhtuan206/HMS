using Microsoft.Reporting.WinForms;
using System;
using System.Windows.Forms;

namespace HMS.Managerment
{
    public partial class pPatientReport : UserControl
    {
        public pPatientReport()
        {
            InitializeComponent();
        }


        private static pPatientReport instance;
        public static pPatientReport Instance
        {
            get
            {
                if (instance == null) instance = new pPatientReport();
                return instance;
            }
        }
        private void btnReport_Click(object sender, EventArgs e)
        {
            ReportParameter[] param = new ReportParameter[1];
            param[0] = new ReportParameter("param1", dtStart.Text);
            param[0] = new ReportParameter("param2", dtEnd.Text);
            this.rp.LocalReport.SetParameters(param);
            this.rp.RefreshReport();
        }
    }
}

