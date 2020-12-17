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

        public void createDetailPatient(int id_patient, int id_bill, int id_staff, int id_bed)
        {
            string query = "INSERT INTO dbo.detail_patient(id_patient,id_staff,id_bill,id_bed,start_time,end_time,check_out,hospitalization_status,status,create_at,update_at)VALUES(" + id_patient + "," + id_staff + "," + id_bill + "," + id_bed + ",GETDATE(),GETDATE(),NULL,NULL,NULL,GETDATE(),GETDATE() )";
            DataProvider.Instance.ExecuteNonQuery(query);
        }

        public DataTable getAllPatient()
        {
            string query = "SELECT dbo.patient.id, dbo.patient.full_name, dbo.patient.pathological FROM dbo.patient WH";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }


    }
}
