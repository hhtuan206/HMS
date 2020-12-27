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

namespace HMS.Nurse
{
    public partial class pNurrseInfo : UserControl
    {
        public pNurrseInfo()
        {
            InitializeComponent();
        }

        private static pNurrseInfo instance;

        public static pNurrseInfo Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new pNurrseInfo();
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
        }
        void updateNurse()
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
                StaffDAO.Instance.updateStaffInfo(id, email,fname,pwd, birth,address,sex,phone);
                MessageBox.Show("Cập nhật thành công");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
           
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            updateNurse();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            getID(txtID.Text);
        }
    }
}
