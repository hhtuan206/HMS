using HMS.Managerment;
using System;
using System.Windows.Forms;

namespace HMS
{
    public partial class fManager : Form
    {
        public fManager()
        {
            InitializeComponent();


        }


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
    }
}
