using HMS.DAO;
using System;
using System.Windows.Forms;

namespace HMS
{
    public partial class pStaff : UserControl
    {

        private static pStaff instance;
        public pStaff()
        {
            InitializeComponent();
            loadStaff();
        }

        public static pStaff Instance
        {
            get
            {
                if (instance == null) instance = new pStaff();
                return instance;
            }
        }

        public void loadStaff()
        {
            dtgStaff.DataSource = StaffDAO.Instance.getAllStaff();
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
                dtgStaff.DataSource = StaffDAO.Instance.searchStaff(keyword);
            } catch(Exception ex) { MessageBox.Show(ex.Message); }
            
        }
    }
}
