using System;
using System.Windows.Forms;

namespace HMS
{
    public partial class fDoctor : Form
    {
        public fDoctor(int id)
        {
            InitializeComponent();
            pPatients.Instance.Id_staff = id;
            pPatients.Instance.getAllPatient(id);
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
