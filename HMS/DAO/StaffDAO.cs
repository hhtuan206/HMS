using System;
using System.Data;

namespace HMS.DAO
{
    public class StaffDAO
    {
        private static StaffDAO instance; // Ctrl + R + E

        public static StaffDAO Instance
        {
            get { if (instance == null) instance = new StaffDAO(); return StaffDAO.instance; }
            private set { StaffDAO.instance = value; }
        }



        public string Login(string userName, string passWord)
        {
            string role = "";
            string query = "SELECT * FROM dbo.Staff WHERE Email = N'" + userName + "' AND Password = N'" + passWord + "' ";

            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in result.Rows)
            {
                role = item["department"].ToString();
            }
            return role;
        }

        public void InsertStaff(string email, string pwd, string fname, string address, int phoneno, DateTime birthday, string timeforwork, string department, string sex)
        {
            DataProvider.Instance.ExecuteNonQuery("USP_InsertStaff @email , @pwd , @fname , @address , @phoneno , @birthday , @timeforwork , @department , @sex", new object[] { email, pwd, fname, address, phoneno, birthday, timeforwork, department, sex });
        }

        public DataTable getDoctorID()
        {

            string query = "SELECT dbo.staff.id, dbo.staff.full_name FROM dbo.staff WHERE dbo.staff.department =N'bác sĩ'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            return data;
        }

        public int getIdByUsername(string username)
        {
            int id = 0;
            string query = "SELECT id FROM dbo.Staff WHERE Email = N'" + username + "'";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in result.Rows)
            {
                id = int.Parse(item["id"].ToString());
            }
            return id;
        }
    }
}
