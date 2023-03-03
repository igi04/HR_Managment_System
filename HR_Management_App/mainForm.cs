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
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            addEmployee addemploye = new addEmployee();
            addemploye.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Login log =  new Login();
            log.Show();
            this.Hide();
        }

        private void update_delete_btn_Click(object sender, EventArgs e)
        {
            updateDelete ud = new updateDelete();
            ud.Show();
            this.Hide();
        }

        private void view_all_btn_Click(object sender, EventArgs e)
        {
            viewEmploye ve = new viewEmploye();
            ve.Show();
            this.Hide();
        }
    }
}
