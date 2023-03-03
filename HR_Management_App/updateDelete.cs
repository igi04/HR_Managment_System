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
using System.Data.SqlClient;

namespace HR_Management_App
{
    public partial class updateDelete : Form
    {
        public updateDelete()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void updateDelete_Load(object sender, EventArgs e)
        {
            populate();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Igor_\source\repos\HR_Management_App\HR_Management_App\HR_DB.mdf;Integrated Security=True");
        private void populate()
        {
            conn.Open();
            string query = "SELECT * From employee";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            var dataSet = new DataSet();
            adapter.Fill(dataSet);
            updateDeleteDGV.DataSource = dataSet.Tables[0];

            conn.Close();
        }


        private void button4_Click(object sender, EventArgs e)
        {
            mainForm mf = new mainForm();
            mf.Show();
            this.Hide();
        }

        int key = 0;
        private void updateDeleteDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            key = Convert.ToInt32(updateDeleteDGV.SelectedRows[0].Cells[0].Value.ToString());
            nameTb.Text = updateDeleteDGV.SelectedRows[0].Cells[1].Value.ToString();
            SurnameTb.Text = updateDeleteDGV.SelectedRows[0].Cells[2].Value.ToString();
            BirthDtp.Text = updateDeleteDGV.SelectedRows[0].Cells[3].Value.ToString();
            TelephoneTb.Text = updateDeleteDGV.SelectedRows[0].Cells[4].Value.ToString();
            PlaceTb.Text = updateDeleteDGV.SelectedRows[0].Cells[5].Value.ToString();
            AddressTb.Text = updateDeleteDGV.SelectedRows[0].Cells[6].Value.ToString();
            PositionCb.Text = updateDeleteDGV.SelectedRows[0].Cells[7].Value.ToString();
            start_workDtp.Text = updateDeleteDGV.SelectedRows[0].Cells[8].Value.ToString();
        }

        private void reset_tbn_Click(object sender, EventArgs e)
        {
            nameTb.Text = string.Empty;
            SurnameTb.Text = string.Empty;
            BirthDtp.Text = string.Empty;
            TelephoneTb.Text = string.Empty;
            PlaceTb.Text = string.Empty;
            AddressTb.Text = string.Empty;
            PositionCb.Text = string.Empty;
            start_workDtp.Text = string.Empty;
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Select an employee to delete!");
            }

            else
            {
                try
                {
                    conn.Open();
                    string query = "DELETE FROM employee WHERE id='" + key + "'";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee deleted succesfully");
                    conn.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                populate();
            }
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            if (key == 0 || nameTb.Text=="" || SurnameTb.Text=="" || BirthDtp.Text=="" || TelephoneTb.Text=="" || PlaceTb.Text=="" || AddressTb.Text=="" || PositionCb.Text=="" || start_workDtp.Text=="")
            {
                MessageBox.Show("Missing information!");
            }
            else
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE employee SET imie='"+nameTb.Text+"', nazwisko='"+SurnameTb.Text+"',data_uro='"+BirthDtp.Text+"', tel_number='"+TelephoneTb.Text+"', place='"+PlaceTb.Text+"', address='"+AddressTb.Text+"', position='"+PositionCb.Text+"', start_work='"+start_workDtp.Text+"' ";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee update succesfully");
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                populate();
            }
        }
    }
}
