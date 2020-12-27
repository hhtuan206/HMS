using HMS.DAO;
using System;
using System.Data;
using System.Windows.Forms;

namespace HMS.Managerment
{
    public partial class pManagementInfo : UserControl
    {
        public pManagementInfo()
        {
            InitializeComponent();
            
           
        }
        public void getID(string id = null)
        {
            txtID.Text = id;
            DataTable data = StaffDAO.Instance.getInfoStaffByIdStaff(txtID.Text);
            foreach (DataRow row in data.Rows)
            {
                txtFName.Text = row["full_name"].ToString();
                txtEmail.Text = row["email"].ToString();
                txtPhoneNo.Text = row["phone_number"].ToString();
                txtAddress.Text = row["address"].ToString();

            }
        }

        private static pManagementInfo instance;

        public static pManagementInfo Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new pManagementInfo();
                }
                return instance;
            }

        }

        private void txtPhoneNo_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtPhoneNo.Text, "[^0-9]"))
            {
                MessageBox.Show("Chỉ nhập số !!!");
                txtPhoneNo.Text = txtPhoneNo.Text.Remove(txtPhoneNo.Text.Length - 1);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                StaffDAO.Instance.updateStaffInfo(txtID.Text, txtEmail.Text, txtFName.Text, txtPwd.Text, dtpBirth.Value, txtAddress.Text, cbSex.SelectedItem.ToString(), txtPhoneNo.Text);
                MessageBox.Show("Cập nhật thành công");

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            getID(txtID.Text);
        }
    }
}
