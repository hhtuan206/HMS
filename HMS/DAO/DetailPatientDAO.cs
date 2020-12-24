using System.Data;

namespace HMS.DAO
{
    class DetailPatientDAO
    {
        private static DetailPatientDAO instance;
        public static DetailPatientDAO Instance
        {
            get { if (instance == null) instance = new DetailPatientDAO(); return DetailPatientDAO.instance; }
            private set { DetailPatientDAO.instance = value; }
        }

        public void createDetailPatient(string id_patient, int id_bill, int id_staff, string id_bed, string pathological)
        {
            string query = "INSERT INTO dbo.detail_patient(id_patient,id_staff,id_bill,id_bed,start_time,end_time,check_out,pathological,status,create_at,update_at)VALUES(" + id_patient + "," + id_staff + "," + id_bill + "," + id_bed + ",GETDATE(),NULL,'"+pathological+"',1,GETDATE(),GETDATE() )";
            DataProvider.Instance.ExecuteNonQuery(query);
        }

        public DataTable getAllPatient()
        {
            string query = "SELECT dbo.patient.id, dbo.patient.full_name, dbo.patient.pathological FROM dbo.patient WH";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }

        public void changeStatusPatient(int id, int status)
        {
            string query = "UPDATE dbo.detail_patient SET status = " + status + " FROM  dbo.detail_patient WHERE dbo.detail_patient.id = " + id + "";
            DataProvider.Instance.ExecuteNonQuery(query);
        }

        public string getStatusPatient(string id_detail_patient)
        {
            string status = null;
            string query = "SELECT dbo.detail_patient.status FROM dbo.detail_patient WHERE id = "+id_detail_patient+"";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                status = row["status"].ToString();
            }
            return status;
        }


    }
}
