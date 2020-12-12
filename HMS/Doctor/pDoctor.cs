using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HMS
{
    public partial class pDoctor : UserControl
    {

        private static pDoctor instance;
        List<String> svList = new List<string>();

        public pDoctor()
        {
            InitializeComponent();
        }

        public static pDoctor Instance
        {
            get
            {
                if (instance == null) instance = new pDoctor();
                return instance;
            }
        }

        public void getDataFormListView()
        {


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int i = 0;
            string text = "";
            foreach (DataGridViewRow row in dataService.Rows)
            {
                if (dataService.Rows.Count - 1 == i)
                {
                    break;
                }
                text += row.Cells[0].Value + ":" + row.Cells[1].Value + ";";
                i++;
            }
            txtName.Text = text;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

            string[] row = { txtNameS.Text, txtCost.Text };
            dataService.Rows.Add(row);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataService.SelectedRows)
            {
                dataService.Rows.RemoveAt(item.Index);
            }
        }
    }
}
