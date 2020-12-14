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


        private BedDAO() { }

        public DataTable LoadBedList()
        {
            string query = "select * from bed ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }

        public DataTable getAllBedInWardByWardID(int id)
        {
            string query = "select * from bed where id_ward = " + id + " and status = 0";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }

        public void changeStatusBed(int id_bed)
        {
            string query = "UPDATE dbo.bed SET status = 0 WHERE id = " + id_bed + "";
            DataProvider.Instance.ExecuteNonQuery(query);
        }
    }
}

