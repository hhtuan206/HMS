using HMS.DAO;
using System;
using System.Windows.Forms;

namespace HMS
{
    public partial class pWard : UserControl
    {
        BindingSource bindingSource = new BindingSource();
        private static pWard instance;
        public pWard()
        {
            InitializeComponent();
            loadWard();
            Bind();
        }


        public static pWard Instance
        {
            get
            {
                if (instance == null) instance = new pWard();
                return instance;
            }
        }

        void loadWard()
        {
            bindingSource.DataSource = WardDAO.Instance.getAllWard();
            dtgWard.DataSource = bindingSource;
        }

        void Bind()
        {
            txtID.DataBindings.Add(new Binding("Text", dtgWard.DataSource, "id"));
            txtNameWard.DataBindings.Add(new Binding("Text", dtgWard.DataSource, "name_ward"));
        }

        private void btnAdd_Click(object sender, System.EventArgs e)
        {
           
            try
            {
                string nameWard = txtNameWard.Text;
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
            
            try
            {
                int id = int.Parse(txtID.Text);
                string nameWard = txtNameWard.Text;
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
            try
            {
                int id = int.Parse(txtID.Text);
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
