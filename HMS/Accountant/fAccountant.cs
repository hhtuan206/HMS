using HMS.DAO;
using System;
using System.Data;
using System.Windows.Forms;

namespace HMS.Accountant
{
    public partial class fAccountant : Form
    {
        string idacc = null;
        public fAccountant(string id = null)
        {
            InitializeComponent();
            loadFullName(id);
            pAcconutantInfo.Instance.getID(id);
            idacc = id;
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
            pPatient.Instance.loadBillUnpaid();
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

       

        private void lịchSửThanhToánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pHistoryPatientBill.Instance.loadHistoryPatientBill();
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

        private void tàiKhoảnToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

            if (!pAccountant.Controls.Contains(pAcconutantInfo.Instance))
            {
                pAcconutantInfo.Instance.getID(idacc);
                pAccountant.Controls.Add(pAcconutantInfo.Instance);
                pAcconutantInfo.Instance.Dock = DockStyle.Fill;
                pAcconutantInfo.Instance.BringToFront();
            }
            else
            {
                pAcconutantInfo.Instance.BringToFront();
            }
        }
    }
    
}
