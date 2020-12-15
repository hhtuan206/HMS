using HMS.DAO;
using HMS.Properties;
using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace HMS.Accountant
{
    public partial class pPatient : UserControl
    {
        public pPatient()
        {
            InitializeComponent();
            loadBillUnpaid();
        }

        private static pPatient instance;
        public static pPatient Instance
        {
            get
            {
                if (instance == null) instance = new pPatient();
                return instance;
            }
        }

        public void loadBillUnpaid()
        {
            dtgPatient.DataSource = PatientDAO.Instance.getPatientCheckIn();
        }

        void loadService(int id)
        {
            dtgBill.Rows.Clear();
            float total_money = 0;
            string dt = BillDAO.Instance.getDetailBillByIdPatient(id);
            string[] services = dt.Split(';');
            for (int i = 0; i < services.Length - 1; i++)
            {
                string[] service = services[i].Split(':');
                string[] row = { service[0].ToString(), service[1].ToString() };
                total_money += float.Parse(service[1].ToString());
                dtgBill.Rows.Add(row);
            }
            CultureInfo culture = new CultureInfo("vi-VN");
            txtTotal_money.Text = total_money.ToString("c", culture);
        }


        private void txtID_TextChanged(object sender, EventArgs e)
        {
            loadService(int.Parse(txtID.Text));
        }

        private void dtgPatient_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in dtgPatient.SelectedRows)
            {
                txtID.Text = item.Cells["ID"].Value.ToString();
                txtFname.Text = item.Cells["fName"].Value.ToString();
                txtPhoneno.Text = item.Cells["phoneno"].Value.ToString();
                txtAddress.Text = item.Cells["address"].Value.ToString();
            }
        }

        private void btnPrintBill_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Image image = Resources._130920995_742064956439546_7414517176641460971_n;
            e.Graphics.DrawImage(image, 0, 0, image.Width, image.Height);

            e.Graphics.DrawString("Date: " + DateTime.Now, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 260));

            e.Graphics.DrawString("Tên khách hàng: " + txtFname.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(350, 260));

            e.Graphics.DrawString("--------------------------------------------------------------------------------------------------", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 290));

            e.Graphics.DrawString("Tên dịch vụ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 320));
            e.Graphics.DrawString("Giá tiền ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(320, 320));

            e.Graphics.DrawString("--------------------------------------------------------------------------------------------------", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 350));

            int yPos = 375;

            foreach (DataGridViewRow row in dtgBill.Rows)
            {

                e.Graphics.DrawString(row.Cells[0].Value.ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, yPos));

                e.Graphics.DrawString(row.Cells[1].Value.ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(320, yPos));
                yPos += 30;
            }

            e.Graphics.DrawString("--------------------------------------------------------------------------------------------------", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, yPos + 30));

            e.Graphics.DrawString("Tổng tiền : " + txtTotal_money.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(350, yPos + 60));

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
