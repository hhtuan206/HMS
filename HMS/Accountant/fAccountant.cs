using HMS.DAO;
using System;
using System.Data;
using System.Windows.Forms;

namespace HMS.Accountant
{
    public partial class fAccountant : Form
    {
        public fAccountant(string id = null)
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
        private void thanhToánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!pAccountant.Controls.Contains(pPatient.Instance))
            {

                pAccountant.Controls.Add(pPatient.Instance);
                pPatient.Instance.Dock = DockStyle.Fill;
                pPatient.Instance.BringToFront();
            }
            else
            {
                pPatient.Instance.BringToFront();
            }
        }

        private void tàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lịchSửThanhToánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!pAccountant.Controls.Contains(pHistoryPatientBill.Instance))
            {

                pAccountant.Controls.Add(pHistoryPatientBill.Instance);
                pHistoryPatientBill.Instance.Dock = DockStyle.Fill;
                pHistoryPatientBill.Instance.BringToFront();
            }
            else
            {
                pHistoryPatientBill.Instance.BringToFront();
            }
        }
    }
}
