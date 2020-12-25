
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

        public string createPatient(string fname, DateTime birthday, string address, string phoneno, string sex, string hin)
        {
            string id = "";
            DataTable data = DataProvider.Instance.ExecuteQuery("USP_CreatePatient @fname , @birthday , @address , @phoneno  , @sex , @hin", new object[] { fname, birthday, address, phoneno, sex, hin });
            foreach (DataRow row in data.Rows)
            {
                id = row["id"].ToString();
            }
            return id;
        }

        public DataTable getListPatientByIdStaff(string id_staff)
        {

            string query = "SELECT dbo.detail_patient.id, dbo.patient.full_name, dbo.detail_patient.pathological FROM dbo.patient INNER JOIN dbo.detail_patient ON detail_patient.id_patient = patient.id WHERE dbo.detail_patient.id_staff = "+id_staff+" AND dbo.detail_patient.status = 1";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;

        }

        public DataTable getListPatient()
        {
            string query = "SELECT * FROM dbo.patient";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }

        

        public DataTable getPatientCheckIn()
        {
            string query = "SELECT dbo.detail_patient.id, dbo.patient.full_name, dbo.patient.address, dbo.patient.phone_number FROM dbo.patient INNER JOIN dbo.detail_patient ON detail_patient.id_patient = patient.id INNER JOIN dbo.bill ON bill.id = detail_patient.id_bill WHERE dbo.bill.status = 0 AND dbo.detail_patient.status = 0";
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
            string query = "SELECT dbo.detail_patient.id, dbo.patient.full_name, dbo.patient.address, dbo.patient.phone_number FROM dbo.patient INNER JOIN dbo.detail_patient ON detail_patient.id_patient = patient.id INNER JOIN dbo.bill ON bill.id = detail_patient.id_bill WHERE ( dbo.patient.phone_number like '%" + keyword + "%' or dbo.patient.address like '%" + keyword + "%' or dbo.patient.full_name like N'%" + keyword + "%') AND dbo.bill.status = 0 AND dbo.detail_patient.status = 0";
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

        public void deletePatientByID(string id = null)
        {
            string query = "DELETE patient WHERE id = "+id+"";
            DataProvider.Instance.ExecuteNonQuery(query); 
        }

        public void updatePatientByID(string id, DateTime birthday, string fname = null, string address = null, string phoneno = null, string sex = null, string hin = null)
        {
            string query = "UPDATE [dbo].[patient] SET [full_name] = N'"+fname+"',[address] = N'"+address+"',[health_insurance_number] = '"+hin+"',[update_at] = GETDATE(),[sex] = N'"+sex+"',[phone_number] = '"+phoneno+"',[birthday] = '"+birthday+"' WHERE id = "+id+"";
            DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
