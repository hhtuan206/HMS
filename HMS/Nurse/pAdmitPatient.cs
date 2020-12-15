using HMS.DAO;
using System;
using System.Data;
using System.Windows.Forms;

namespace HMS
{
    public partial class pAdmitPatient : UserControl
    {
        public pAdmitPatient()
        {

            InitializeComponent();
            initData();
            initDoc();



        }

        private static pAdmitPatient instance;
        public static pAdmitPatient Instance
        {
            get
            {
                if (instance == null) instance = new pAdmitPatient();
                return instance;
            }
        }

        void initData()
        {
            dtgPatient.DataSource = PatientDAO.Instance.getListPatient(1);
        }

        void initDoc()
        {
            cbDoc.DataSource = StaffDAO.Instance.getDoctorID();
            cbDoc.DisplayMember = "full_name";
            cbDoc.ValueMember = "id";
        }

        void fillCbWard()
        {
            DataTable dt = WardDAO.Instance.getAllWard();
            cbWard.DataSource = dt;
            cbWard.DisplayMember = "name_ward";
            cbWard.ValueMember = "id";

        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            string fname = txtFname.Text;
            string address = txtAddress.Text;
            int phoneno = int.Parse(txtPhoneno.Text);
            DateTime birthday = dtBirth.Value;
            string sex = cbSex.SelectedItem.ToString();
            string hin = txtHIN.Text;
            int id_bed = int.Parse(cbBed.SelectedValue.ToString());
            int id_staff = int.Parse(cbDoc.SelectedValue.ToString());
            int id_patient = PatientDAO.Instance.createPatient(fname, birthday, address, phoneno, sex, hin);
            int id_bill = BillDAO.Instance.createBill();
            BedDAO.Instance.changeStatusBed(id_bed);
            DetailPatientDAO.Instance.createDetailPatient(id_patient, id_bill, id_staff, id_bed);
            MessageBox.Show("Thành công");
            initData();
        }


        void fillCbBed(int id_ward)
        {
            cbBed.DataSource = BedDAO.Instance.getAllBedInWardByWardID(id_ward);
            cbBed.DisplayMember = "number_bed";
            cbBed.ValueMember = "id";

        }



        private void cbWard_SelectedIndexChanged(object sender, EventArgs e)
        {

            string i = cbWard.SelectedValue.ToString();
            if (!i.Equals("System.Data.DataRowView"))
            {
                fillCbBed(int.Parse(i));
            }


        }

        private void btnLoadWard_Click(object sender, EventArgs e)
        {
            cbWard.Enabled = true;
            fillCbWard();
        }
    }

    public class foo
    {
        public int id { get; set; }
        private string name_ward { get; set; }
    }
}
