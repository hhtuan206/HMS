using System;
using System.Windows.Forms;

namespace HMS
{
    public partial class fManager : Form
    {
        public fManager()
        {
            InitializeComponent();

            loadpStar();
        }

        void loadpStar()
        {
            if (!pManager.Controls.Contains(pStar.Instance))
            {

                pManager.Controls.Add(pStar.Instance);
                pStar.Instance.Dock = DockStyle.Fill;
                pStar.Instance.BringToFront();
            }
            else
            {
                pStar.Instance.BringToFront();
            }
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

        }
    }
}
