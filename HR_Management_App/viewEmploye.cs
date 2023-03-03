using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HR_Management_App
{
    public partial class viewEmploye : Form
    {
        public viewEmploye()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Igor_\source\repos\HR_Management_App\HR_Management_App\HR_DB.mdf;Integrated Security=True");
        private void populate()
        {
            conn.Open();
            string query = "SELECT * From employee";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            var dataSet = new DataSet();
            adapter.Fill(dataSet);
            employeDGV.DataSource = dataSet.Tables[0];

            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void viewEmploye_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'hR_DBDataSet1.employee' . Możesz go przenieść lub usunąć.
            this.employeeTableAdapter.Fill(this.hR_DBDataSet1.employee);

        }
    }
}
