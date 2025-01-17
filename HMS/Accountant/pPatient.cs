﻿using HMS.DAO;
using HMS.Properties;
using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace HMS.Accountant
{
    public partial class pPatient : UserControl
    {
        BindingSource bindingSource = new BindingSource();
        public pPatient()
        {
            InitializeComponent();
            loadBillUnpaid();
            bind();
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
        #region methods
        void bind()
        {
            txtID.DataBindings.Add(new Binding("Text", dtgPatient.DataSource, "id"));
            txtFname.DataBindings.Add(new Binding("Text", dtgPatient.DataSource, "full_name"));
            txtAddress.DataBindings.Add(new Binding("Text", dtgPatient.DataSource, "address"));
            txtPhoneno.DataBindings.Add(new Binding("Text", dtgPatient.DataSource, "phone_number"));
        }

        public void loadBillUnpaid()
        {

            bindingSource.DataSource = PatientDAO.Instance.getPatientCheckIn();
            dtgPatient.DataSource = bindingSource;
        }

        void loadServiceByID(string id)
        {
            try
            {
                if (dtgPatient.DataSource != null)
                {
                    int total = 0;
                    dtgMedicine.Rows.Clear();
                    dtgTest.Rows.Clear();
                    DataTable medicine = MedicineDAO.Instance.getAllMedicineByIdDetailPatient(id);
                    foreach (DataRow row in medicine.Rows)
                    {

                        string medicine_name = row["medicine_name"].ToString();
                        int quanntity = int.Parse(row["quantity"].ToString());
                        int cost = int.Parse(row["cost"].ToString());
                        int total_medicine = multiData(cost, quanntity);
                        total += total_medicine;
                        loadService(dtgMedicine, medicine_name, quanntity.ToString(), cost.ToString(), total_medicine.ToString());
                    }
                    DataTable test = TestDAO.Instance.getAllTestByIdDetailPatient(id);
                    foreach (DataRow row in test.Rows)
                    {
                        string test_name = row["test_name"].ToString();
                        int cost = int.Parse(row["cost"].ToString());
                        total += cost;
                        loadService(dtgTest, test_name, "1", cost.ToString(), cost.ToString());
                    }
                    CultureInfo culture = new CultureInfo("vi-VN");
                    txtTotal_money.Text = total.ToString("c", culture);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        public int multiData(int a, int b)
        {

            return a * b;
        }

        public void loadService(DataGridView dtg, string medicine, string quantity, string cost, string total)
        {
            try
            {
                string[] row = { medicine, quantity, cost, total };
                dtg.Rows.Add(row);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }


        #endregion
        #region events
        private void txtID_TextChanged(object sender, EventArgs e)
        {
            if (txtID.Text != "")
            {
                try
                {
                    loadServiceByID(txtID.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }

        }

        private void btnPrintBill_Click(object sender, EventArgs e)
        {
            try
            {

                string id_bed = BedDAO.Instance.getIdBedByIdDetailPatient(txtID.Text);
                BedDAO.Instance.changeStatusBed(id_bed,"0");
                BillDAO.Instance.changePatientBill(txtID.Text, "1",txtTotal_money.Text);

                printPreviewDialog1.Document = printDocument1;
                printPreviewDialog1.ShowDialog();

                loadBillUnpaid();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                Image image = Resources.download;
                e.Graphics.DrawImage(image, 0, 0, image.Width, image.Height);
                e.Graphics.DrawString("Hoá đơn dịch vụ bệnh viện", new Font("TimeNewRoman", 25, FontStyle.Bold), Brushes.Black, new Point(200, 75));

                e.Graphics.DrawString("Date: " + DateTime.Now, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(600, 200));

                e.Graphics.DrawString("Tên khách hàng: " + txtFname.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 260));
                e.Graphics.DrawString("Số điện thoại: " + txtPhoneno.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 290));
                e.Graphics.DrawString("Địa chỉ: " + txtAddress.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 320));
                e.Graphics.DrawString("-----------------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 350));
                e.Graphics.DrawString("Tên dịch vụ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(45, 370));
                e.Graphics.DrawString("Số lượng ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(350, 370));
                e.Graphics.DrawString("Giá tiền ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(525, 370));
                e.Graphics.DrawString("Thành tiền ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(675, 370));
                e.Graphics.DrawString("-----------------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 390));

                int yPos = 410;

                foreach (DataGridViewRow row in dtgMedicine.Rows)
                {

                    e.Graphics.DrawString(row.Cells["medicine"].Value.ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(45, yPos));
                    e.Graphics.DrawString(row.Cells["quantity"].Value.ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(375, yPos));
                    e.Graphics.DrawString(row.Cells["cost_medicine"].Value.ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(525, yPos));
                    e.Graphics.DrawString(row.Cells["total_money_medicine"].Value.ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(675, yPos));
                    yPos += 30;
                }
                foreach (DataGridViewRow row in dtgTest.Rows)
                {
                    e.Graphics.DrawString(row.Cells["test"].Value.ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(45, yPos));
                    e.Graphics.DrawString("1", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(375, yPos));
                    e.Graphics.DrawString(row.Cells["cost_test"].Value.ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(525, yPos));
                    e.Graphics.DrawString(row.Cells["total_money_test"].Value.ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(675, yPos));
                    yPos += 30;
                }

                e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, yPos + 20));

                e.Graphics.DrawString("Tổng tiền : " + txtTotal_money.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(625, yPos + 60));
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

            try
            {
                bindingSource.DataSource = PatientDAO.Instance.searchPatientCheckIn(txtKeyword.Text);
                dtgPatient.DataSource = bindingSource;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void dtgPatient_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void dtgMedicine_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void dtgTest_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        #endregion
    }
}
