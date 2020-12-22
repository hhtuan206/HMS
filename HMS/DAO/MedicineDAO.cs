using System.Data;

namespace HMS.DAO
{
    class MedicineDAO
    {

        private static MedicineDAO instance; // Ctrl + R + E

        public static MedicineDAO Instance
        {
            get { if (instance == null) instance = new MedicineDAO(); return MedicineDAO.instance; }
            private set { MedicineDAO.instance = value; }
        }

        public DataTable getAllMedicine()
        {
            string query = "select * from medicine_product";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }

        public void createMedicine(string id_detail_patient, string id_medicine, string quantity, string time_of_day)
        {
            string query = " INSERT INTO  medicine(id_detail_patient,id_medicine,quantity,time_of_days ,create_at, update_at) VALUES (" + id_detail_patient + "," + id_medicine + "," + quantity + ",'" + time_of_day + "',getdate(),getdate())";
            DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable getAllMedicineByIdDetailPatient(string id_detail_patient)
        {
            string query = "SELECT * FROM dbo.medicine WHERE id_detail_patient =" + id_detail_patient + "";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }

        public DataTable getMedicineByID(string id)
        {

            string query = "SELECT * FROM dbo.medicine_product WHERE id =" + id + "";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            return data;
        }

        public void createMedicineProduct(string name, float cost)
        {
            string query = "INSERT INTO dbo.medicine_product(medicine_name,cost,create_at,update_at) VALUES(N'" + name + "'," + cost + ",GETDATE(), GETDATE())";
            DataProvider.Instance.ExecuteQuery(query);
        }

        public void updateMedicineProduct(string id, string name, float cost)
        {
            string query = " UPDATE dbo.medicine_product SET medicine_name = N'" + name + "', cost = " + cost + ", update_at = GETDATE() WHERE id = " + id + "";
            DataProvider.Instance.ExecuteQuery(query);
        }

        public void deleteMedicineProduct(string id)
        {
            string query = "DELETE dbo.medicine_product WHERE id = " + id + "";
            DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable getMe(string id)
        {
            string query = "SELECT dbo.medicine_product.medicine_name, dbo.medicine.quantity,dbo.medicine_product.cost FROM dbo.medicine INNER JOIN dbo.medicine_product ON medicine_product.id = medicine.id_medicine WHERE id_detail_patient = "+id+"";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }
        

    }
}
