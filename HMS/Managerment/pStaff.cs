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
            StaffDAO.Instance.InsertStaff(email, pwd, fname, address, phoneno, birthday, timeforwork, department, sex);
            MessageBox.Show("Thành công");
        }

        private void btnDel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPwd_TextChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void txtTW_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dtBirth_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txtPhoneno_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void txtFname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
