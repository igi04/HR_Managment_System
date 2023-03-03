using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HR_Management_App
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* 
            if(loginTb.Text=="Admin" && passwordTb.Text=="Qwerty123") {
                MessageBox.Show("Log in succesfuly");
                mainForm mainform = new mainForm();
                mainform.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Wrong login or password, try once again!");
                loginTb.Text=string.Empty;
                passwordTb.Text=string.Empty;
            }
            */
        }

        private void passwordTb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
