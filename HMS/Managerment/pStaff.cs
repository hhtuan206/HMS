using HMS.DAO;
using System;
using System.Windows.Forms;

namespace HMS
{
    public partial class pStaff : UserControl
    {
        BindingSource bindingSource = new BindingSource();
        private static pStaff instance;
        public pStaff()
        {
            InitializeComponent();
            loadStaff();
            bind();
            cbSex.SelectedIndex = 0;
            cbDepartment.SelectedIndex = 0;
        }

        public static pStaff Instance
        {
            get
            {
                if (instance == null) instance = new pStaff();
                return instance;
            }
        }

        void bind()
        {
            txtID.DataBindings.Add(new Binding("Text",dtgStaff.DataSource,"id"));
            txtAddress.DataBindings.Add(new Binding("Text", dtgStaff.DataSource, "address"));
            txtEmail.DataBindings.Add(new Binding("Text", dtgStaff.DataSource, "email"));
            txtFname.DataBindings.Add(new Binding("Text", dtgStaff.DataSource, "full_name"));
            txtPhoneno.DataBindings.Add(new Binding("Text", dtgStaff.DataSource, "phone_number"));
            cbSex.DataBindings.Add(new Binding("Text", dtgStaff.DataSource, "sex"));
            cbDepartment.DataBindings.Add(new Binding("Text", dtgStaff.DataSource, "department"));
            txtTW.DataBindings.Add(new Binding("Text", dtgStaff.DataSource, "time_for_work"));
        }

        public void loadStaff()
        {
            bindingSource.DataSource = StaffDAO.Instance.getAllStaff();
            dtgStaff.DataSource = bindingSource;
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string email = txtEmail.Text;
                string pwd = txtPwd.Text;
                string fname = txtFname.Text;
                string address = txtAddress.Text;
                string phoneno = txtPhoneno.Text;
                DateTime birthday = dtBirth.Value;
                string timeforwork = txtTW.Text;
                string department = cbDepartment.SelectedItem.ToString();
                string sex = cbSex.SelectedItem.ToString();
                StaffDAO.Instance.createStaff(email, pwd, fname, address, phoneno, birthday, timeforwork, department, sex);
                MessageBox.Show("Thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            loadStaff();
        }

        public void clearTextBox()
        {
            txtAddress.Text = "";
            txtID.Text = "";
            txtFname.Text = "";
            txtEmail.Text = "";
            txtPhoneno.Text = "";
            txtTW.Text = "";
            txtPwd.Text = "";
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            try
            {
                string id = txtID.Text;
                string email = txtEmail.Text;
                string fullName = txtFname.Text;
                string passWord = txtPwd.Text;
                string addRess = txtAddress.Text;
                DateTime birth = dtBirth.Value;
                string timeForWord = txtTW.Text;
                string sex = cbSex.SelectedItem.ToString();
                string departMent = cbDepartment.SelectedItem.ToString();
                string phoneno =txtPhoneno.Text;
                StaffDAO.Instance.updateStaff(id, email, fullName, passWord, birth, addRess, sex, phoneno, timeForWord, departMent);
                MessageBox.Show("Cập nhật thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            loadStaff(); loadStaff();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            try
            {
                int id = int.Parse(txtID.Text);
                StaffDAO.Instance.deleteStaff(id);
                MessageBox.Show("Xoá thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            loadStaff();
        }

        private void txtPhoneno_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtPhoneno.Text, "[^0-9]"))
            {
                MessageBox.Show("Chỉ nhập số.");
                txtPhoneno.Text = txtPhoneno.Text.Remove(txtPhoneno.Text.Length - 1);
            }
        }

        private void txtKeyWord_TextChanged(object sender, EventArgs e)
        {
            try {
                string keyword = txtKeyWord.Text;
                bindingSource.DataSource = StaffDAO.Instance.searchStaff(keyword);
                dtgStaff.DataSource = bindingSource;
            } catch(Exception ex) { MessageBox.Show(ex.Message); }
            
        }
    }
}
