using System;
using System.Windows.Forms;

namespace HMS
{
    public partial class fNurse : Form
    {
        public fNurse()
        {
            InitializeComponent();
        }

        private void thêmBệnhNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!pNurse.Controls.Contains(pPatient.Instance))
            {

                pNurse.Controls.Add(pPatient.Instance);
                pPatient.Instance.Dock = DockStyle.Fill;
                pPatient.Instance.BringToFront();
            }
            else
            {
                pPatient.Instance.BringToFront();
            }
        }
    }
}
