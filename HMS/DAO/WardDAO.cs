using System.Data;

namespace HMS.DAO
{
    class WardDAO
    {

        private static WardDAO instance;

        public static WardDAO Instance
        {
            get { if (instance == null) instance = new WardDAO(); return WardDAO.instance; }
            private set { WardDAO.instance = value; }
        }

        private WardDAO() { }
        public DataTable getAllWard()
        {
            string query = "select * from ward";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            return data;
        }

        public void createWard(string name_ward)
        {
            string query = "INSERT INTO dbo.ward( name_ward, update_at,create_at) VALUES(   N'" + name_ward + "',  GETDATE(),GETDATE() )";
            DataProvider.Instance.ExecuteQuery(query);
        }

        public void updateWard(int id, string name_ward)
        {
            string query = "UPDATE dbo.ward SET name_ward = N'" + name_ward + "', update_at = GETDATE() WHERE id =" + id + "";
            DataProvider.Instance.ExecuteQuery(query);
        }

        public void deleteWard(int id)
        {
            string query = "DELETE dbo.ward WHERE id = " + id + "";
            DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable searchWard(string keyword)
        {
            string query = "SELECT * FROM dbo.ward WHERE name_ward LIKE N'%" + keyword + "%'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }
    }
}
