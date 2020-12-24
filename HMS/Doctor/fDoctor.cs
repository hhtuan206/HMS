using HMS.DAO;
using System;
using System.Data;
using System.Windows.Forms;

namespace HMS
{
    public partial class fDoctor : Form
    {
        public fDoctor(string id = null)
        {
            InitializeComponent();
            pPatients.Instance.Id_staff = id;
            pPatients.Instance.getAllPatient(id);
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
        private void bệnhNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!pDoctor.Controls.Contains(pPatients.Instance))
            {
                pDoctor.Controls.Add(pPatients.Instance);
                pPatients.Instance.Dock = DockStyle.Fill;
                pPatients.Instance.BringToFront();
            }
            else
            {
                pPatients.Instance.BringToFront();
            }
        }

        private void TàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
