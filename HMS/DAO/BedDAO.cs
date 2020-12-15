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

        public void createBed(int id_ward, int number_bed)
        {
            string query = "INSERT INTO dbo.bed(id_ward,number_bed,status,create_at,update_at) VALUES(" + id_ward + "," + number_bed + ",0,GETDATE(),GETDATE() )";
            DataProvider.Instance.ExecuteQuery(query);
        }

        public void updateBed(int id,int id_ward, int number_bed)
        {
            string query = "UPDATE dbo.bed SET id_ward = " + id_ward + ", number_bed = "+number_bed+", update_at = getdate() WHERE id = " + id + "";
            DataProvider.Instance.ExecuteQuery(query);
        }

        public void deleteBed(int id)
        {
            string query = "DELETE dbo.bed WHERE id = " + id + "";
            DataProvider.Instance.ExecuteQuery(query);
        }
    }
}

