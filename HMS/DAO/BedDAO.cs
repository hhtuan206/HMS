using System.Data;

namespace HMS.DAO
{
    class BedDAO
    {
        private static BedDAO instance;

        public static BedDAO Instance
        {
            get { if (instance == null) instance = new BedDAO(); return BedDAO.instance; }
            private set { BedDAO.instance = value; }
        }

        public static int TableWidth = 90;
        public static int TableHeight = 90;

        private BedDAO() { }

        public DataTable LoadBedList()
        {
            string query = "select * from bed ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }

        public DataTable getAllBedInWardByWardID(int id)
        {
            string query = "select * from bed where id_ward = " + id + "";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }
    }
}

