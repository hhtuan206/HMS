using HMS.DAO;
using System;
using System.Windows.Forms;

namespace HMS
{
    public partial class pPatient : UserControl
    {
        public pPatient()
        {
            InitializeComponent();
            fillCbWard();
            initData();
            initDoc();
            

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

        void initData()
        {
            dtgPatient.DataSource = PatientDAO.Instance.getListPatient();

        }

        void initDoc()
        {
            cbDoc.DataSource = StaffDAO.Instance.getDoctorID();
            cbDoc.DisplayMember = "full_name";
            cbDoc.ValueMember = "id";
        }

        void fillCbWard()
        {

            cbWard.DataSource = WardDAO.Instance.getAllWard();
            cbWard.DisplayMember = "name_ward";
            cbWard.ValueMember = "id";
        }

        void fillCbBed(int id_ward)
        {
            cbBed.DataSource = BedDAO.Instance.getAllBedInWardByWardID(id_ward);
            cbBed.DisplayMember = "number_bed";
            cbBed.ValueMember = "id";
        }



        private void btnAdd_Click(object sender, EventArgs e)
        {
            string fname = txtFname.Text;
            string address = txtAddress.Text;
            int phoneno = int.Parse(txtPhoneno.Text);
            DateTime birthday = dtBirth.Value;
            string sex = cbSex.SelectedItem.ToString();
            string hin = txtHIN.Text;
            PatientDAO.Instance.insertPatient(fname, birthday, address, phoneno, sex, hin);
            MessageBox.Show("Thành công");
            initData();
        }

        private void cbWard_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbWard.SelectedItem == null)
                return;
            /*int id = combo.SelectedIndex;
            */
            //fillCbBed(id);
            MessageBox.Show(cbWard.SelectedValue.ToString());



        }
    }
}
