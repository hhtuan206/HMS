using System.Data;

namespace HMS.DAO
{
    class TestDAO
    {
        private static TestDAO instance; // Ctrl + R + E

        public static TestDAO Instance
        {
            get { if (instance == null) instance = new TestDAO(); return TestDAO.instance; }
            private set { TestDAO.instance = value; }
        }

        public DataTable getAllTest()
        {
            string query = "select * from test_product";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }

        public void createTest(string id_detail_patient, string id_test)
        {
            string query = "insert into test(id_detail_patient,id_test,create_at, update_at) values(" + id_detail_patient + "," + id_test + ",getdate(),getdate())";
            DataProvider.Instance.ExecuteQuery(query);
        }



        public DataTable getTestByID(string id)
        {
            string query = "SELECT * FROM dbo.test_product WHERE id =" + id + "";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }

        public void createTestProduct(string name, float cost)
        {
            string query = "INSERT INTO dbo.test_product(test_name,cost,create_at,update_at) VALUES(N'" + name + "'," + cost + ",GETDATE(), GETDATE())";
            DataProvider.Instance.ExecuteQuery(query);
        }

        public void updateTestProduct(string id, string name, float cost)
        {
            string query = " UPDATE dbo.test_product SET test_name = N'" + name + "', cost = " + cost + ", update_at = GETDATE() WHERE id = " + id + "";
            DataProvider.Instance.ExecuteQuery(query);
        }

        public void deleteTestProduct(string id)
        {
            string query = "DELETE dbo.test_product WHERE id = " + id + "";
            DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable getAllTestByIdDetailPatient(string id)
        {
            string query = "SELECT dbo.test_product.test_name,dbo.test_product.cost FROM dbo.test INNER JOIN dbo.test_product ON test_product.id = test.id_test WHERE id_detail_patient = " + id + "";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }

        public DataTable searchTestProduct(string keyword)
        {
            string query = "SELECT * FROM dbo.test_product WHERE test_name LIKE N'%" + keyword + "%'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }
    }
}
