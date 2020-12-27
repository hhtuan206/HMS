using HMS.DAO;
using System;
using System.Windows.Forms;

namespace HMS.Doctor
{
    public partial class fAddMedicine : Form
    {
        public fAddMedicine()
        {
            InitializeComponent();
            fillCbMedicine();
        }

        void fillCbMedicine()
        {
            cbMedicine.DisplayMember = "medicine_name";
            cbMedicine.ValueMember = "id";
            cbMedicine.DataSource = MedicineDAO.Instance.getAllMedicine();
            cbTime_Of_Day.SelectedIndex = 1;
        }

        private void btnAddMore_Click(object sender, EventArgs e)
        {
            try
            {
                string medicine = cbMedicine.Text;
                string id_medicine = cbMedicine.SelectedValue.ToString();
                string quantity = txtQuantity.Text;
                string time_of_day = cbTime_Of_Day.SelectedItem.ToString();
                pPatients.Instance.loadMedicine(id_medicine, medicine, quantity, time_of_day);
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void bntAddOne_Click(object sender, EventArgs e)
        {
            try {
                string id_medicine = cbMedicine.SelectedValue.ToString();
                string medicine = cbMedicine.Text;
                string quantity = txtQuantity.Text;
                string time_of_day = cbTime_Of_Day.SelectedItem.ToString();
                pPatients.Instance.loadMedicine(id_medicine, medicine, quantity, time_of_day);
                this.Dispose();
            } catch (Exception ex) { MessageBox.Show(ex.Message); }
            
        }

    }
}
