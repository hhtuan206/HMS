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

        private void btnView_Click(object sender, EventArgs e)
        {
            USP_ReportPatientTableAdapter.Fill(HMSDataSet.USP_ReportPatient, int.Parse(txtDay.Text));
            this.reportViewer1.RefreshReport();
        }
    }
}

