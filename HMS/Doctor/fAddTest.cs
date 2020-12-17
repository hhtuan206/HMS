using HMS.DAO;
using System.Data;
using System.Windows.Forms;

namespace HMS.Doctor
{
    public partial class fAddTest : Form
    {
        public fAddTest()
        {
            InitializeComponent();
            fillCbTest();
        }

        void fillCbTest()
        {
            DataTable data = TestDAO.Instance.getAllTest();
            cbTest.DataSource = data;
            cbTest.ValueMember = "id";
            cbTest.DisplayMember = "test_name";
        }

        private void btnAddMore_Click(object sender, System.EventArgs e)
        {
            string id_test = cbTest.SelectedValue.ToString();
            string test = cbTest.Text;
            pPatients.Instance.loadTest(id_test, test);
        }

        private void bntAddOne_Click(object sender, System.EventArgs e)
        {
            string id_test = cbTest.SelectedValue.ToString();
            string test = cbTest.Text;
            pPatients.Instance.loadTest(id_test, test);
            this.Dispose();
        }
    }
}
