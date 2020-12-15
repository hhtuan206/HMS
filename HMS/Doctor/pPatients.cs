using HMS.DAO;
using System;
using System.Data;
using System.Windows.Forms;
namespace HMS
{
    public partial class pPatients : UserControl
    {

        private int id_staff;

        public int Id_staff { get => id_staff; set => id_staff = value; }
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

        public void getAllPatient(int id)
        {
            DataTable data = PatientDAO.Instance.getListPatient(id);
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

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            loadService(int.Parse(txtID.Text));
        }

        void loadService(int id)
        {
            dtgService.Rows.Clear();
            string dt = BillDAO.Instance.getDetailBillByIdPatient(id);
            string[] services = dt.Split(';');
            for (int i = 0; i < services.Length - 1; i++)
            {
                string[] service = services[i].Split(':');
                string[] row = { service[0].ToString(), service[1].ToString() };
                dtgService.Rows.Add(row);
            }
        }


        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            string[] row = { txtSname.Text, txtCost.Text };
            dtgService.Rows.Add(row);
        }

        private void btnDel_Click_1(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dtgService.SelectedRows)
            {
                dtgService.Rows.RemoveAt(item.Index);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            string text = "";
            foreach (DataGridViewRow row in dtgService.Rows)
            {

                text += row.Cells[0].Value + ":" + row.Cells[1].Value + ";";

            }
            BillDAO.Instance.updateServiceList(text, int.Parse(txtID.Text));
            PatientDAO.Instance.changeStatusPatient(int.Parse(txtID.Text), 0);
            MessageBox.Show("Thành công");
        }
    }
}
