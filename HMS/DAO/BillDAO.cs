using System.Data;

namespace HMS.DAO
{
    class BillDAO
    {

        private static BillDAO instance; // Ctrl + R + E

        public static BillDAO Instance
        {
            get { if (instance == null) instance = new BillDAO(); return BillDAO.instance; }
            private set { BillDAO.instance = value; }
        }

        private BillDAO() { }


        public DataTable GetBillInfoByID(int id)
        {
            string query = "SELECT * FROM dbo.detail_patient JOIN dbo.patient ON patient.id = detail_patient.id_patient JOIN dbo.bed ON bed.id = detail_patient.id_bed JOIN dbo.bill ON bill.id = detail_patient.id_bill WHERE dbo.bed.id = " + id + " and dbo.bed.status = 1";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }

        public string getDetailBillByIdPatient(int id_patient)
        {
            string service = "";
            string query = "SELECT bill.service_list FROM dbo.bill INNER JOIN dbo.detail_patient ON detail_patient.id_bill = bill.id WHERE id_patient = " + id_patient + "";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                service = item["service_list"].ToString();
            }
            return service;

        }

        public void updateServiceList(string service, int id)
        {
            DataProvider.Instance.ExecuteNonQuery("UPDATE dbo.bill SET service_list = N'" + service + "' FROM dbo.bill INNER JOIN dbo.detail_patient ON detail_patient.id_bill = bill.id WHERE dbo.detail_patient.id_patient =" + id + " AND dbo.bill.status = 0");
        }

        public int createBill()
        {
            int id = 0;
            DataTable data = DataProvider.Instance.ExecuteQuery("INSERT INTO dbo.bill(total_money,create_at,update_at,status) OUTPUT Inserted.id VALUES( 0, GETDATE(), GETDATE(), 0)");
            foreach (DataRow item in data.Rows)
            {
                id = int.Parse(item["id"].ToString());
            }
            return id;
        }


        public void changePatientBill(string id, string status)
        {
            string query = "UPDATE dbo.bill SET status = " + status + " FROM dbo.bill INNER JOIN dbo.detail_patient ON detail_patient.id_bill = bill.id WHERE dbo.detail_patient.id = " + id + "";
            DataProvider.Instance.ExecuteNonQuery(query);
        }

    }
}
