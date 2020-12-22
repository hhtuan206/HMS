
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
            string query = "SELECT dbo.detail_patient.id, dbo.patient.full_name, dbo.patient.address, dbo.patient.phone_number FROM dbo.patient INNER JOIN dbo.detail_patient ON detail_patient.id_patient = patient.id INNER JOIN dbo.bill ON bill.id = detail_patient.id_bill WHERE dbo.bill.status = 0";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }

        public DataTable getPatientCheckOut()
        {
            string query = "SELECT dbo.detail_patient.id, dbo.patient.full_name, dbo.patient.address, dbo.patient.phone_number FROM dbo.patient INNER JOIN dbo.detail_patient ON detail_patient.id_patient = patient.id INNER JOIN dbo.bill ON bill.id = detail_patient.id_bill WHERE dbo.bill.status = 1";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }
        public DataTable searchPatientCheckIn(string keyword)
        {
            string query = "SELECT dbo.detail_patient.id, dbo.patient.full_name, dbo.patient.address, dbo.patient.phone_number FROM dbo.patient INNER JOIN dbo.detail_patient ON detail_patient.id_patient = patient.id INNER JOIN dbo.bill ON bill.id = detail_patient.id_bill WHERE ( dbo.patient.phone_number like '%" + keyword + "%' or dbo.patient.address like '%" + keyword + "%' or dbo.patient.full_name like N'%" + keyword + "%') AND dbo.bill.status = 0";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }

        public DataTable getPatientReport(DateTime start, DateTime end)
        {
            string query = "SELECT dbo.patient.full_name, dbo.patient.birthday,dbo.patient.address,dbo.patient.phone_number,dbo.patient.pathological,dbo.detail_patient.start_time FROM dbo.patient INNER JOIN dbo.detail_patient ON detail_patient.id_patient = patient.id WHERE dbo.detail_patient.start_time > '" + start + "' AND dbo.detail_patient.start_time <= '" + end + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }

        public DataTable searchPatientCheckOut(string keyword)
        {
            string query = "SELECT dbo.detail_patient.id, dbo.patient.full_name, dbo.patient.address, dbo.patient.phone_number FROM dbo.patient INNER JOIN dbo.detail_patient ON detail_patient.id_patient = patient.id INNER JOIN dbo.bill ON bill.id = detail_patient.id_bill WHERE (dbo.patient.phone_number like '%" + keyword + "%' or dbo.patient.address like '%" + keyword + "%' or dbo.patient.full_name like N'%" + keyword + "%') AND dbo.bill.status = 1";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }
    }
}
