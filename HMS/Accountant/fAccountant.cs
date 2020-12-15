using System;
using System.Windows.Forms;

namespace HMS.Accountant
{
    public partial class fAccountant : Form
    {
        public fAccountant()
        {
            InitializeComponent();
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
    }
}
