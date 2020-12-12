using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.DAO
{
    class StaffDAO
    {
        private static StaffDAO instance; // Ctrl + R + E

        public static StaffDAO Instance
        {
            get { if (instance == null) instance = new StaffDAO(); return StaffDAO.instance; }
            private set { StaffDAO.instance = value; }
        }

        private StaffDAO() { }

        public bool Login(string userName, string passWord)
        {
            string query = "SELECT * FROM dbo.Staff WHERE Email = N'" + userName + "' AND Password = N'" + passWord + "' ";

            DataTable result = DataProvider.Instance.ExecuteQuery(query);

            return result.Rows.Count > 0;
        }
    }
}
