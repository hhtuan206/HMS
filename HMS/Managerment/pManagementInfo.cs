using System;
using System.Windows.Forms;

namespace HMS.Managerment
{
    public partial class pManagementInfo : UserControl
    {
        public pManagementInfo()
        {
            InitializeComponent();
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


    }
}
