
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

        public void insertPatient(string fname, DateTime birthday, string address, int phoneno, string sex, string hin)
        {
            DataProvider.Instance.ExecuteNonQuery("USP_InsertPatient @fname , @birthday , @address , @phoneno  , @sex , @hin", new object[] { fname, birthday, address, phoneno, sex, hin });

        }

        public DataTable getListPatient()
        {

            string query = "select * from patient";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;

        }

        public DataTable getAcpPatient()
        {
            string query = "select * from patient where status = 1";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;

        }

        public DataTable getWaitPatient()
        {
            string query = "select * from patient where status = 0";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }

        public void changeStatusPatient(int id, int status)
        {
            DataProvider.Instance.ExecuteNonQuery("UPDATE dbo.patient SET status = " + status + " Where id = " + id + "");
        }
    }
}
