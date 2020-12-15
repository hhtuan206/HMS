using HMS.DAO;
using System;
using System.Windows.Forms;

namespace HMS
{
    public partial class pWard : UserControl
    {
        private static pWard instance;
        public pWard()
        {
            InitializeComponent();
            loadWard();
        }


        public static pWard Instance
        {
            get
            {
                if (instance == null) instance = new pWard();
                return instance;
            }
        }

        public void loadWard()
        {
            dtgWard.DataSource = WardDAO.Instance.getAllWard();
        }

        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            string nameWard = txtNameWard.Text;
            try
            {
                WardDAO.Instance.createWard(nameWard);
                MessageBox.Show("Thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            loadWard();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            string nameWard = txtNameWard.Text;
            try
            {
                WardDAO.Instance.updateWard(id, nameWard);
                MessageBox.Show("Thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            loadWard();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            try
            {
                WardDAO.Instance.deleteWard(id);
                MessageBox.Show("Thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            loadWard();
        }
    }

}
