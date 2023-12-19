using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderManagement
{
    public partial class User_Dashboard : Form
    {
        public User_Dashboard()
        {
            InitializeComponent();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pblogout1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void User_Dashboard_Load(object sender, EventArgs e)
        {
        
        }

        private void User_Dashboard_Load_1(object sender, EventArgs e)
        {
            lblloginuser.Text = Login.userLogged;
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.Show();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Purchase_Order po = new Purchase_Order();
            po.Show();
        }
    }
}

