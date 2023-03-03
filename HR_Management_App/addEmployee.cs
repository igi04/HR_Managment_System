using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HR_Management_App
{
    public partial class addEmployee : Form
    {
        public addEmployee()
        {
            InitializeComponent();
        }
        SqlConnection conn =  new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Igor_\source\repos\HR_Management_App\HR_Management_App\HR_DB.mdf;Integrated Security=True");

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(nameTb.Text=="" || SurnameTb.Text=="" || birthDtp.Text=="" || telephoneTb.Text=="" || placeTb.Text=="" || addressTb.Text=="" || positionCb.Text=="" || start_workDtp.Text == "")
            {
                MessageBox.Show("Missing information");
            }

            else
            {
                try
                {
                    conn.Open();
                    string query = "insert into employee values('" + nameTb.Text + "','" + SurnameTb.Text + "','" + birthDtp.Text + "','" + telephoneTb.Text + "','" + placeTb.Text+ "', '" + addressTb.Text + "','" + positionCb.SelectedItem.ToString() + "','" + start_workDtp.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee added succesfuly");
                    conn.Close();   
                }catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            nameTb.Text = string.Empty;
            SurnameTb.Text = string.Empty;
            birthDtp.Text = string.Empty;
            telephoneTb.Text = string.Empty;
            placeTb.Text = string.Empty;
            addressTb.Text = string.Empty;
            positionCb.Text = string.Empty;
            start_workDtp.Text = string.Empty;

        }

        private void Add_back_btn_Click(object sender, EventArgs e)
        {
            mainForm mf= new mainForm();
            mf.Show();
            this.Hide();
        }

    }
}
