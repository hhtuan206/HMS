using HMS.DAO;
using System;
using System.Data;
using System.Windows.Forms;

namespace HMS
{
    public partial class pAdmitPatient : UserControl
    {
        BindingSource bindingSource = new BindingSource();
        public pAdmitPatient()
        {
            InitializeComponent();
            initData();
            initDoc();
            bind();
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
            bindingSource.DataSource = PatientDAO.Instance.getListPatient();
            dtgPatient.DataSource = bindingSource;
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

        void bind()
        {
            txtID.DataBindings.Add(new Binding("Text", dtgPatient.DataSource, "id"));
            txtFname.DataBindings.Add(new Binding("Text", dtgPatient.DataSource, "full_name"));
            txtAddress.DataBindings.Add(new Binding("Text", dtgPatient.DataSource, "address"));
            txtHIN.DataBindings.Add(new Binding("Text", dtgPatient.DataSource, "health_insurance_number"));
            txtPhoneno.DataBindings.Add(new Binding("Text", dtgPatient.DataSource, "phone_number"));
            cbSex.DataBindings.Add(new Binding("Text",dtgPatient.DataSource,"sex"));
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string fname = txtFname.Text;
                string address = txtAddress.Text;
                string phoneno = txtPhoneno.Text;
                DateTime birthday = dtBirth.Value;
                string sex = cbSex.SelectedItem.ToString();
                string hin = txtHIN.Text;
                string pathological = txtPa.Text;
                string id_bed = cbBed.SelectedValue.ToString();
                int id_staff = int.Parse(cbDoc.SelectedValue.ToString());
                string id_patient = PatientDAO.Instance.createPatient(fname, birthday, address, phoneno, sex, hin);
                int id_bill = BillDAO.Instance.createBill();
                BedDAO.Instance.changeStatusBed(id_bed,"1");
                DetailPatientDAO.Instance.createDetailPatient(id_patient, id_bill, id_staff, id_bed,pathological);
                MessageBox.Show("Thêm mới thành công");
                initData();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

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

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                string id = txtID.Text;
                PatientDAO.Instance.deletePatientByID(id);
                MessageBox.Show("Xoá thành công");
                initData();
            } catch (Exception ex) { MessageBox.Show(ex.Message); }
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                string id = txtID.Text;
                string fname = txtFname.Text;
                string address = txtAddress.Text;
                string phoneno = txtPhoneno.Text;
                DateTime birthday = dtBirth.Value;
                string sex = cbSex.SelectedItem.ToString();
                string hin = txtHIN.Text;
                PatientDAO.Instance.updatePatientByID(id, birthday, fname,address,phoneno,sex,hin);
                MessageBox.Show("Cập nhật thành công");
                initData();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void btnAgain_Click(object sender, EventArgs e)
        {
            try
            {
                string id = txtID.Text;
                string pathological = txtPa.Text;
                string id_bed = cbBed.SelectedValue.ToString();
                int id_staff = int.Parse(cbDoc.SelectedValue.ToString());
                int id_bill = BillDAO.Instance.createBill();
                BedDAO.Instance.changeStatusBed(id_bed, "1");
                DetailPatientDAO.Instance.createDetailPatient(id, id_bill, id_staff, id_bed, pathological);
                MessageBox.Show("Lên lịch khám thành công");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void txtPhoneno_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtPhoneno.Text, "[^0-9]"))
            {
                MessageBox.Show("Chỉ nhập số.");
                txtPhoneno.Text = txtPhoneno.Text.Remove(txtPhoneno.Text.Length - 1);
            }
        }

        private void txtKeyWord_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string keyword = txtKeyWord.Text;
                bindingSource.DataSource = PatientDAO.Instance.searchPatient(keyword);
                dtgPatient.DataSource = bindingSource;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }


}
