﻿using HMS.DAO;
using System;
using System.Windows.Forms;

namespace HMS.Managerment
{
    public partial class pMedicine : UserControl
    {
        BindingSource bindingSource = new BindingSource();
        private static pMedicine instance;
        public pMedicine()
        {
            InitializeComponent();
            loadMedicine();
            Bind();
        }

        public static pMedicine Instance
        {
            get
            {
                if (instance == null) instance = new pMedicine();
                return instance;
            }
        }

        public void loadMedicine()
        {
            bindingSource.DataSource = MedicineDAO.Instance.getAllMedicine();
            dtgMedicine.DataSource = bindingSource;
        }

        void Bind()
        {
            txtID.DataBindings.Add(new Binding("Text", dtgMedicine.DataSource, "id"));
            txtNameTest.DataBindings.Add(new Binding("Text", dtgMedicine.DataSource, "medicine_name"));
            txtCost.DataBindings.Add(new Binding("Text", dtgMedicine.DataSource, "cost"));
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            try
            {
                string name = txtNameTest.Text;
                float cost = float.Parse(txtCost.Text);
                MedicineDAO.Instance.createMedicineProduct(name, cost);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            loadMedicine();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            try
            {
                string id = txtID.Text;
                string name = txtNameTest.Text;
                float cost = float.Parse(txtCost.Text);
                MedicineDAO.Instance.updateMedicineProduct(id, name, cost);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            loadMedicine();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                string id = txtID.Text;
                MedicineDAO.Instance.deleteMedicineProduct(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            loadMedicine();
        }

        private void txtKeyWord_TextChanged(object sender, EventArgs e)
        {
            try {
                string keyword = txtKeyWord.Text;
                bindingSource.DataSource = MedicineDAO.Instance.searchMedicineProduct(keyword);
                dtgMedicine.DataSource = bindingSource;
            } catch (Exception ex) { MessageBox.Show(ex.Message); }
           
        }
    }
}
