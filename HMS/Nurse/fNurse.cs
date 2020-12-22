using System;
using System.Windows.Forms;

namespace HMS
{
    public partial class fNurse : Form
    {
        public fNurse()
        {
            InitializeComponent();
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

        }
    }
}
