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
            string query = "select id, name_ward from ward";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            return data;
        }
    }
}
