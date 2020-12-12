using HMS.DAO;
using HMS.Doctor;
using System;
using System.Windows.Forms;
namespace HMS
{
    public partial class pPatients : UserControl
    {

        public BindingSource patient = new BindingSource();
        public pPatients()
        {
            InitializeComponent();
            loadAcpPatient();
            loadWaitPatient();
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



        public void loadAcpPatient()
        {
            dtgAcpPatient.DataSource = patient;
            patient.DataSource = PatientDAO.Instance.getAcpPatient();
        }

        public void loadWaitPatient()
        {
            dtgWaitPatient.DataSource = PatientDAO.Instance.getWaitPatient();
        }

        private void btnAcp_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dtgWaitPatient.SelectedRows[0].Cells["Id"].Value.ToString());
            PatientDAO.Instance.changeStatusPatient(id, 1);
            int id_bill = BillDAO.Instance.createBill();

            DetailPatientDAO.Instance.createDetailPatient(id, id_bill);
            loadAcpPatient();
            loadWaitPatient();

        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dtgAcpPatient.SelectedRows[0].Cells["Id"].Value.ToString());

            fMedical fMedical = new fMedical(id);
            this.Hide();
            fMedical.ShowDialog();
            this.Show();
        }
    }
}
