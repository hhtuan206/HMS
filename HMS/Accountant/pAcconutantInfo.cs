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
using System.Globalization;

namespace HMS.Accountant
{
    public partial class pAcconutantInfo : UserControl
    {
        public pAcconutantInfo()
        {
            InitializeComponent();
        }

        private static pAcconutantInfo instance;

        public static pAcconutantInfo Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new pAcconutantInfo();
                }
                return instance;
            }

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
            cbSex.SelectedIndex = 0;
        }
       
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string id = txtID.Text;
                string fname = txtFName.Text;
                string address = txtAddress.Text;
                string phone = txtPhoneNo.Text;
                string sex = cbSex.SelectedItem.ToString();
                DateTime birth = dtpBirth.Value;
                string email = txtEmail.Text;
                string pwd = txtPwd.Text;
                StaffDAO.Instance.updateStaffInfo(id, email, fname, pwd, birth, address, sex, phone);
                MessageBox.Show("Cập nhật thành công");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            
        }

        private void btnResset_Click(object sender, EventArgs e)
        {
            getID(txtID.Text);
            txtPwd.Text = "";
        }
    }
}
