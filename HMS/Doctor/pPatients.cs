using HMS.DAO;
using HMS.Doctor;
using System;
using System.Data;
using System.Windows.Forms;
namespace HMS
{
    public partial class pPatients : UserControl
    {



        public pPatients()
        {
            InitializeComponent();

        }

        private static pPatients instance;
        public static pPatients Instance
        {
            get
            {
                if (instance == null) instance = new pPatients();
                return instance;
            }
        }
        string iddoc = null;
        

        public void getAllPatient(string id)
        {
            iddoc = id;
            DataTable data = PatientDAO.Instance.getListPatientByIdStaff(id);
            dtgAmitPatient.DataSource = data;
        }

        private void dtgAmitPatient_SelectionChanged(object sender, EventArgs e)
        {

            foreach (DataGridViewRow item in dtgAmitPatient.SelectedRows)
            {
                txtID.Text = item.Cells["ID"].Value.ToString();
                txtFname.Text = item.Cells["fName"].Value.ToString();
                txtPathological.Text = item.Cells["po"].Value.ToString();
            }

        }


        public void loadMedicine(string id_medicine, string medicine, string quantity, string time_of_day)
        {
            string[] row = { id_medicine, medicine, quantity, time_of_day };
            dtgMedicine.Rows.Add(row);
        }

        public void loadTest(string id_test, string test)
        {
            string[] row = { id_test, test };
            dtgTest.Rows.Add(row);
        }


        private void btnAddMedicine_Click(object sender, EventArgs e)
        {
            fAddMedicine addMedicine = new fAddMedicine();
            addMedicine.ShowDialog();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dtgMedicine.Rows)
                {
                    string id_detail_patient = txtID.Text;
                    string id_medicine = row.Cells["id_medicine"].Value.ToString();
                    string quantity = row.Cells["quantity"].Value.ToString();
                    string time_of_day = row.Cells["time_of_day"].Value.ToString();
                    MedicineDAO.Instance.createMedicine(id_detail_patient, id_medicine, quantity, time_of_day);
                }

                foreach (DataGridViewRow row in dtgTest.Rows)
                {
                    string id_detail_patient = txtID.Text;
                    string id_test = row.Cells["id_test"].Value.ToString();
                    TestDAO.Instance.createTest(id_detail_patient, id_test);
                }
                DetailPatientDAO.Instance.changeStatusPatient(int.Parse(txtID.Text), 0);
                MessageBox.Show("Thành công");
                getAllPatient(iddoc);
                dtgMedicine.Rows.Clear();
                dtgTest.Rows.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnDeleteMedicine_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dtgMedicine.SelectedRows)
            {
                dtgMedicine.Rows.RemoveAt(item.Index);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dtgTest.SelectedRows)
            {
                dtgTest.Rows.RemoveAt(item.Index);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            fAddTest addTest = new fAddTest();
            addTest.ShowDialog();
        }

       
    }
}
