using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS.Managerment
{
    public partial class pPatientByTime : UserControl
    {
        public pPatientByTime()
        {
            InitializeComponent();
        }

        private static pPatientByTime instance;
        public static pPatientByTime Instance
        {
            get
            {
                if (instance == null) instance = new pPatientByTime();
                return instance;
            }
        }


        private void btnView_Click(object sender, EventArgs e)
        {
            
            this.USP_PatientReportByTimeTableAdapter.Fill(this.HMSDataSet.USP_PatientReportByTime, dtpStart.Value,dtpEnd.Value);
            this.rp.RefreshReport();
        }
    }
}
