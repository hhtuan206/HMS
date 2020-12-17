
using System;
using System.Data;
namespace HMS.DAO
{
    class PatientDAO
    {
        private static PatientDAO instance; // Ctrl + R + E

        public static PatientDAO Instance
        {
            get { if (instance == null) instance = new PatientDAO(); return PatientDAO.instance; }
            private set { PatientDAO.instance = value; }
        }

        public int createPatient(string fname, DateTime birthday, string address, int phoneno, string sex, string hin)
        {
            int id = 0;
            DataTable data = DataProvider.Instance.ExecuteQuery("USP_CreatePatient @fname , @birthday , @address , @phoneno  , @sex , @hin", new object[] { fname, birthday, address, phoneno, sex, hin });
            foreach (DataRow item in data.Rows)
            {
                id = int.Parse(item["id"].ToString());
            }
            return id;
        }

        public DataTable getListPatient(int id_staff)
        {

            string query = "SELECT dbo.detail_patient.id, dbo.patient.full_name, dbo.patient.pathological FROM dbo.patient INNER JOIN dbo.detail_patient ON detail_patient.id_patient = patient.id WHERE dbo.detail_patient.id_staff = " + id_staff + " AND dbo.patient.status = 1";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;

        }

        public void changeStatusPatient(int id, int status)
        {
            string query = "UPDATE dbo.patient SET status = " + status + " FROM dbo.patient INNER JOIN dbo.detail_patient ON detail_patient.id_patient = patient.id WHERE dbo.detail_patient.id = " + id + "";
            DataProvider.Instance.ExecuteNonQuery(query);
        }

        public DataTable getPatientCheckIn()
        {
            string query = "SELECT dbo.detail_patient.id, dbo.patient.full_name,dbo.patient.phone_number,dbo.patient.address FROM dbo.patient INNER JOIN dbo.detail_patient ON detail_patient.id_patient = patient.id WHERE dbo.patient.status = 0";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }

        public DataTable searchPatientCheckInByName(string name)
        {
            string query = "SELECT dbo.detail_patient.id, dbo.patient.full_name,dbo.patient.phone_number,dbo.patient.address FROM dbo.patient INNER JOIN dbo.detail_patient ON detail_patient.id_patient = patient.id AND dbo.patient.status = 0 WHERE dbo.patient.full_name LIKE N'%"+name+"%'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }
    }
}
