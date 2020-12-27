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

        public void createStaff(string email, string pwd, string fname, string address, string phoneno, DateTime birthday, string timeforwork, string department, string sex)
        {
            DataProvider.Instance.ExecuteNonQuery("USP_InsertStaff @email , @pwd , @fname , @address , @phoneno , @birthday , @timeforwork , @department , @sex", new object[] { email, pwd, fname, address, phoneno, birthday, timeforwork, department, sex });
        }

        public DataTable getDoctorID()
        {
            string query = "SELECT dbo.staff.id, dbo.staff.full_name FROM dbo.staff WHERE dbo.staff.department =N'bác sĩ'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }

        public string getIdByUsername(string username)
        {
            string id = "";
            string query = "SELECT id FROM dbo.Staff WHERE Email = N'" + username + "'";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in result.Rows)
            {
                id = row["id"].ToString();
            }
            return id;
        }

        public DataTable getInfoStaffByIdStaff(string id)
        {
            string query = "SELECT * FROM dbo.staff WHERE id = " + id + "";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }

        public void updateStaff(string id, string email, string full_name, string password, DateTime birth, string address, string sex, string phone_no, string time_for_work,string department = null)
        {
            string query = "UPDATE dbo.staff SET email = N'" + email + "', full_name = N'" + full_name + "', password = N'" + password + "', birthday = '" + birth + "', address = N'" + address + "', sex = '" + sex + "',phone_number = '" + phone_no + "',time_for_work =N'" + time_for_work + "',department = N'"+department+"', update_at = getDate() WHERE id = " + id + "";
            DataProvider.Instance.ExecuteQuery(query);
        }

        public void updateStaffInfo(string id, string email, string full_name, string password, DateTime birth, string address, string sex, string phone_no)
        {
            string query = "UPDATE dbo.staff SET email = N'" + email + "', full_name = N'" + full_name + "', password = N'" + password + "', birthday = '" + birth + "', address = N'" + address + "', sex = '" + sex + "',phone_number = '" + phone_no + "', update_at = getDate() WHERE id = " + id + "";
            DataProvider.Instance.ExecuteQuery(query);
        }

        public void deleteStaff(int id)
        {
            string query = "DELETE dbo.staff WHERE id =" + id + "";
            DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable getAllStaff()
        {
            string query = "SELECT dbo.staff.id,dbo.staff.email,dbo.staff.full_name,dbo.staff.address,dbo.staff.sex,dbo.staff.phone_number, dbo.staff.department,dbo.staff.time_for_work,dbo.staff.birthday FROM dbo.staff WHERE department = N'Bác sĩ' or department = N'Y tá' or department = N'Kế toán'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }

        public DataTable searchStaff(string word)
        {
            string query = "SELECT dbo.staff.id,dbo.staff.email,dbo.staff.full_name,dbo.staff.address,dbo.staff.sex,dbo.staff.phone_number, dbo.staff.department,dbo.staff.time_for_work,dbo.staff.birthday FROM dbo.staff WHERE (email LIKE N'%" + word + "%' OR address LIKE N'%" + word + "%' OR full_name LIKE N'%" + word + "%' ) and department = N'Bác sĩ' or department = N'Y tá' or department = N'Kế toán'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }
    }
}
