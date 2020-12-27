using HMS.DAO;
using System;
using System.Windows.Forms;

namespace HMS.Managerment
{
    public partial class pBed : UserControl
    {
        BindingSource bindingSource = new BindingSource();
        private static pBed instance;
        public pBed()
        {
            InitializeComponent();
            fillCbWard();
            loadBed();
            Bind();
        }

        #region methods
        public static pBed Instance
        {
            get
            {
                if (instance == null) instance = new pBed();
                return instance;
            }
        }

        public void loadBed()
        {
            bindingSource.DataSource = BedDAO.Instance.LoadBedList();
            dtgBed.DataSource = bindingSource;
        }

        public void fillCbWard()
        {
            cbWard.DataSource = WardDAO.Instance.getAllWard();
            cbWard.DisplayMember = "name_ward";
            cbWard.ValueMember = "id";
        }
        void Bind()
        {
            txtID.DataBindings.Add(new Binding("Text", dtgBed.DataSource, "id"));
            txtNumber_Bed.DataBindings.Add(new Binding("Text", dtgBed.DataSource, "number_bed"));

        }
        #endregion
        #region event
        private void btnAdd_Click(object sender, System.EventArgs e)
        {
           
            try
            {
                int number_bed = int.Parse(txtNumber_Bed.Text);
                int id_ward = int.Parse(cbWard.SelectedValue.ToString());
                BedDAO.Instance.createBed(id_ward, number_bed);
                MessageBox.Show("Thêm thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            loadBed();
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
        #endregion
    }
}
