using HMS.DAO;
using HMS.Nurse;
using System;
using System.Data;
using System.Windows.Forms;

namespace HMS
{
    public partial class fNurse : Form
    {
        public fNurse(string id = null)
        {
            InitializeComponent();
            loadFullName(id);
            pNurrseInfo.Instance.getID(id);
        }

        public void loadFullName(string id)
        {
            DataTable data = StaffDAO.Instance.getInfoStaffByIdStaff(id);
            foreach (DataRow row in data.Rows)
            {
                txtNameStaff.Text = row["full_name"].ToString();
            }
        }

        private void thêmBệnhNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!pNurse.Controls.Contains(pAdmitPatient.Instance))
            {

                pNurse.Controls.Add(pAdmitPatient.Instance);
                pAdmitPatient.Instance.Dock = DockStyle.Fill;
                pAdmitPatient.Instance.BringToFront();
            }
            else
            {
                pAdmitPatient.Instance.BringToFront();
            }
        }



        private void TàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!pNurse.Controls.Contains(pNurrseInfo.Instance))
            {

                pNurse.Controls.Add(pNurrseInfo.Instance);
                pNurrseInfo.Instance.Dock = DockStyle.Fill;
                pNurrseInfo.Instance.BringToFront();
            }
            else
            {
                pNurrseInfo.Instance.BringToFront();
            }
        }
    }
}
