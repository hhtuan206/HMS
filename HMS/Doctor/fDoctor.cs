using HMS.DAO;
using HMS.Doctor;
using System;
using System.Data;
using System.Windows.Forms;

namespace HMS
{
    public partial class fDoctor : Form
    {
        string iddoc = null;
        public fDoctor(string id = null)
        {
            InitializeComponent();
            pPatients.Instance.getAllPatient(id);
            loadFullName(id);
            iddoc = id;
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
            pDoctorInfo.Instance.getID(iddoc);
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

        private void tàiKhoảnToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            
            if (!pDoctor.Controls.Contains(pDoctorInfo.Instance))
            {
                pDoctor.Controls.Add(pDoctorInfo.Instance);
                pDoctorInfo.Instance.Dock = DockStyle.Fill;
                pDoctorInfo.Instance.BringToFront();
            }
            else
            {
                pDoctorInfo.Instance.BringToFront();
            }
        }
    }
    
}
