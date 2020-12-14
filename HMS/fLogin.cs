using HMS.DAO;
using System;
using System.Windows.Forms;

namespace HMS
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtUsername.Text;
            string passWord = txtPassword.Text;
            string role = StaffDAO.Instance.Login(userName, passWord);
            int id = StaffDAO.Instance.getIdByUsername(userName);
            if (role.Equals("Quản lý"))
            {
                fManager manager = new fManager();
                this.Hide();
                manager.ShowDialog();
                this.Show();
            }
            else if (role.Equals("Bác sĩ"))
            {
                fDoctor doctor = new fDoctor(id);
                this.Hide();
                doctor.ShowDialog();
                this.Show();
            }
            else if (role.Equals("Y tá"))
            {
                fNurse nurse = new fNurse();
                this.Hide();
                nurse.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!");
            }


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát chương trình", "Thông báo", MessageBoxButtons.OKCancel) != DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}
