using HMS.DAO;
using System;
using System.Windows.Forms;
namespace HMS.Doctor
{
    public partial class fMedical : Form
    {

        public fMedical(int id)
        {
            InitializeComponent();
            loadService(id);
            txtID.Text = id.ToString();
        }



        void loadService(int id)
        {
            dtgService.Rows.Clear();
            string dt = BillDAO.Instance.getServiceList(id);
            string[] services = dt.Split(';');
            for (int i = 0; i < services.Length - 1; i++)
            {
                string[] service = services[i].Split(':');
                string[] row = { service[0].ToString(), service[1].ToString() };
                dtgService.Rows.Add(row);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string[] row = { txtSname.Text, txtCost.Text };
            dtgService.Rows.Add(row);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int i = 0;
            string text = "";
            foreach (DataGridViewRow row in dtgService.Rows)
            {
                if (dtgService.Rows.Count - 1 == i)
                {
                    break;
                }
                text += row.Cells[0].Value + ":" + row.Cells[1].Value + ";";
                i++;
            }
            BillDAO.Instance.updateServiceList(text, int.Parse(txtID.Text));
            MessageBox.Show("Thành công");
            this.Dispose();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dtgService.SelectedRows)
            {
                dtgService.Rows.RemoveAt(item.Index);
            }
        }
    }
}
