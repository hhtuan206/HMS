using HMS.DAO;
using HMS.Managerment;
using System;
using System.Data;
using System.Windows.Forms;

namespace HMS
{
    public partial class fManager : Form
    {
        public fManager(string id = null)
        {
            InitializeComponent();
            loadFullName(id);
        }

        public void loadFullName(string id)
        {
            DataTable data = StaffDAO.Instance.getInfoStaffByIdStaff(id);
            foreach (DataRow row in data.Rows)
            {
                txtNameStaff.Text = row["full_name"].ToString();
            }
        }

        #region events
        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!pManager.Controls.Contains(pStaff.Instance))
            {

                pManager.Controls.Add(pStaff.Instance);
                pStaff.Instance.Dock = DockStyle.Fill;
                pStaff.Instance.BringToFront();
            }
            else
            {
                pStaff.Instance.BringToFront();
            }
        }

        private void khuVựcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!pManager.Controls.Contains(pWard.Instance))
            {

                pManager.Controls.Add(pWard.Instance);
                pWard.Instance.Dock = DockStyle.Fill;
                pWard.Instance.BringToFront();
            }
            else
            {
                pWard.Instance.BringToFront();
            }
        }

        private void giườngBệnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!pManager.Controls.Contains(pBed.Instance))
            {

                pManager.Controls.Add(pBed.Instance);
                pBed.Instance.Dock = DockStyle.Fill;
                pBed.Instance.BringToFront();
            }
            else
            {
                pBed.Instance.BringToFront();
            }
        }

        private void thuốcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!pManager.Controls.Contains(pMedicine.Instance))
            {

                pManager.Controls.Add(pMedicine.Instance);
                pMedicine.Instance.Dock = DockStyle.Fill;
                pMedicine.Instance.BringToFront();
            }
            else
            {
                pMedicine.Instance.BringToFront();
            }
        }

        private void xétNghiệmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!pManager.Controls.Contains(pTest.Instance))
            {

                pManager.Controls.Add(pTest.Instance);
                pTest.Instance.Dock = DockStyle.Fill;
                pTest.Instance.BringToFront();
            }
            else
            {
                pTest.Instance.BringToFront();
            }
        }
        #endregion

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void bệnhNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!pManager.Controls.Contains(pPatientReport.Instance))
            {

                pManager.Controls.Add(pPatientReport.Instance);
                pPatientReport.Instance.Dock = DockStyle.Fill;
                pPatientReport.Instance.BringToFront();
            }
            else
            {
                pPatientReport.Instance.BringToFront();
            }
        }

        private void TàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!pManager.Controls.Contains(pManagementInfo.Instance))
            {

                pManager.Controls.Add(pManagementInfo.Instance);
                pManagementInfo.Instance.Dock = DockStyle.Fill;
                pManagementInfo.Instance.BringToFront();
            }
            else
            {
                pManagementInfo.Instance.BringToFront();
            }
        }
    }
}
