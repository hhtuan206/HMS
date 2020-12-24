using HMS.DAO;
using HMS.Properties;
using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace HMS.Accountant
{
    public partial class pHistoryPatientBill : UserControl
    {
        BindingSource bindingSource1 = new BindingSource();

        public pHistoryPatientBill()
        {
            InitializeComponent();
            loadHistoryPatientBill();
        }
        private static pHistoryPatientBill instance;
        public static pHistoryPatientBill Instance
        {
            get
            {
                if (instance == null) instance = new pHistoryPatientBill();
                return instance;
            }
        }
        void loadHistoryPatientBill()
        {
            bindingSource1.DataSource = PatientDAO.Instance.getPatientCheckOut();
            dtgHistory.DataSource = bindingSource1;
        }

        private void txtKeyWord_TextChanged(object sender, EventArgs e)
        {

            try
            {

                bindingSource1.DataSource = PatientDAO.Instance.searchPatientCheckOut(txtKeyWord.Text);
                dtgHistory.DataSource = bindingSource1;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void PrintBill_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                string id = null;
                int total_money = 0;
                Image image = Resources.download;
                e.Graphics.DrawImage(image, 0, 0, image.Width, image.Height);
                e.Graphics.DrawString("Hoá đơn dịch vụ bệnh viện", new Font("TimeNewRoman", 25, FontStyle.Bold), Brushes.Black, new Point(200, 75));

                e.Graphics.DrawString("Date: " + DateTime.Now, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(600, 200));
                foreach (DataGridViewRow row in dtgHistory.SelectedRows)
                {
                    id = row.Cells["id"].Value.ToString();
                    e.Graphics.DrawString("Tên khách hàng: " + row.Cells["fName"].Value.ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 260));
                    e.Graphics.DrawString("Số điện thoại: " + row.Cells["phoneno"].Value.ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 290));
                    e.Graphics.DrawString("Địa chỉ: " + row.Cells["address"].Value.ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 320));
                }
                DataTable medicine = MedicineDAO.Instance.getAllMedicineByIdDetailPatient(id);
                DataTable test = TestDAO.Instance.getAllTestByIdDetailPatient(id);
                e.Graphics.DrawString("-----------------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 350));
                e.Graphics.DrawString("Tên dịch vụ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(45, 370));
                e.Graphics.DrawString("Số lượng ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(350, 370));
                e.Graphics.DrawString("Giá tiền ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(525, 370));
                e.Graphics.DrawString("Thành tiền ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(675, 370));
                e.Graphics.DrawString("-----------------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 390));

                int yPos = 410;

                foreach (DataRow row in medicine.Rows)
                {
                    int total_money_medicine = int.Parse(row["quantity"].ToString()) * int.Parse(row["cost"].ToString());
                    e.Graphics.DrawString(row["medicine_name"].ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(45, yPos));
                    e.Graphics.DrawString(row["quantity"].ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(375, yPos));
                    e.Graphics.DrawString(row["cost"].ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(525, yPos));
                    e.Graphics.DrawString(total_money_medicine.ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(675, yPos));
                    yPos += 30;
                    total_money += total_money_medicine;
                }
                foreach (DataRow row in test.Rows)
                {
                    int total_money_test = int.Parse(row["cost"].ToString());
                    e.Graphics.DrawString(row["test_name"].ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(45, yPos));
                    e.Graphics.DrawString("1", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(375, yPos));
                    e.Graphics.DrawString(row["cost"].ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(525, yPos));
                    e.Graphics.DrawString(row["cost"].ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(675, yPos));
                    yPos += 30;
                    total_money += total_money_test;
                }
                CultureInfo culture = new CultureInfo("vi-VN");

                e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, yPos + 20));

                e.Graphics.DrawString("Tổng tiền : " + total_money.ToString("c", culture), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(625, yPos + 60));
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            fPrintBill.Document = PrintBill;
            fPrintBill.ShowDialog();
        }
    }
}
