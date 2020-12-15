using HMS.DAO;
using System;
using System.Windows.Forms;

namespace HMS.Managerment
{
    public partial class pBed : UserControl
    {
        public pBed()
        {
            InitializeComponent();
            loadBed();
        }

        private static pBed instance;


        public static pBed Instance
        {
            get
            {
                if (instance == null) instance = new pBed();
                return instance;
            }
        }
        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            int number_bed = int.Parse(txtNumber_Bed.Text);
            int id_ward = int.Parse(cbWard.SelectedValue.ToString());
            try
            {
                BedDAO.Instance.createBed(id_ward, number_bed);
                MessageBox.Show("Thêm thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            loadBed();
        }

        public void loadBed()
        {
            dtgBed.DataSource = BedDAO.Instance.LoadBedList();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            int number_bed = int.Parse(txtNumber_Bed.Text);
            int id_ward = int.Parse(cbWard.SelectedValue.ToString());
            try
            {
                BedDAO.Instance.updateBed(id, id_ward, number_bed);
                MessageBox.Show("Cập nhật thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            loadBed();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            int number_bed = int.Parse(txtNumber_Bed.Text);
            try
            {
                BedDAO.Instance.deleteBed(number_bed);
                MessageBox.Show("Xoá thành công thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            loadBed();
        }
    }
}
