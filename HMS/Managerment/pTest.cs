using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HMS.DAO;

namespace HMS.Managerment
{
    public partial class pTest : UserControl
    {
        BindingSource bindingSource = new BindingSource();

        private static pTest instance;
        public pTest()
        {
            InitializeComponent();
            loadTest();
            Bind();
        }
        #region methods
        
        public static pTest Instance
        {
            get
            {
                if (instance == null) instance = new pTest();
                return instance;
            }
        }

        void loadTest()
        {
            bindingSource.DataSource = TestDAO.Instance.getAllTest();
            dtgTest.DataSource = bindingSource;
        }

        void Bind()
        {
            txtID.DataBindings.Add(new Binding("Text", dtgTest.DataSource, "id"));
            txtNameTest.DataBindings.Add(new Binding("Text", dtgTest.DataSource, "test_name"));
            txtCost.DataBindings.Add(new Binding("Text", dtgTest.DataSource, "cost"));
        }

        #endregion
        #region events
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtNameTest.Text;
                float cost = float.Parse(txtCost.Text);
                TestDAO.Instance.createTestProduct(name, cost);
                MessageBox.Show("Thêm thành công");
                loadTest();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                string id = txtID.Text;
                string name = txtNameTest.Text;
                float cost = float.Parse(txtCost.Text);
                TestDAO.Instance.updateTestProduct(id,name, cost);
                MessageBox.Show("Sửa thành công");
                loadTest();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                string id = txtID.Text;
                TestDAO.Instance.deleteTestProduct(id);
                MessageBox.Show("Xoá thành công");
                loadTest();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
    }
}
