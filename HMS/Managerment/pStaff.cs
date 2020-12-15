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
        }

        public static pStaff Instance
        {
            get
            {
                if (instance == null) instance = new pStaff();
                return instance;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string pwd = txtPwd.Text;
            string fname = txtFname.Text;
            string address = txtAddress.Text;
            int phoneno = int.Parse(txtPhoneno.Text);
            DateTime birthday = dtBirth.Value;
            string timeforwork = txtTW.Text;
            string department = cbDepartment.SelectedItem.ToString();
            string sex = cbSex.SelectedItem.ToString();
            StaffDAO.Instance.createStaff(email, pwd, fname, address, phoneno, birthday, timeforwork, department, sex);
            MessageBox.Show("Thành công");
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
