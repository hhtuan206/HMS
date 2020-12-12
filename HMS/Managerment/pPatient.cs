
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HMS
{
    public partial class pStar : UserControl
    {
        private static pStar instance;
        List<Button> buttonList = new List<Button>();
        public pStar()
        {
            InitializeComponent();
            fillCbWard();
        }
        public static pStar Instance
        {
            get
            {
                if (instance == null) instance = new pStar();
                return instance;
            }
        }

        void LoadBed(int id)
        {

        }

        private void btn_click(object sender, EventArgs e)
        {

        }

        void ShowDeltail(int id)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int id_ward = (int)cbWard.SelectedValue;
        }

        void fillCbWard()
        {

        }

        //void fillCbBed(int id)
        //{
        //    List<Bed> list = BedDAO.Instance.LoadListBedByIdWard(id);
        //    cbIdBed.DataSource = list;
        //    cbIdBed.DisplayMember = "number_bed";
        //    cbIdBed.ValueMember = "id";
        //}

        private void cbWard_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*int id = 0;
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
            {
                return;
            }
            Ward select = cb.SelectedItem as Ward;
            id = select.Id;
            LoadBed(id);*/
            //fillCbBed(id);
        }

        private void flpBed_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
