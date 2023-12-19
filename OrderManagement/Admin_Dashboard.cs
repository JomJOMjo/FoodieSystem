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
    public partial class Admin_Dashboard : Form
    {
        public Admin_Dashboard()
        {
            InitializeComponent();
        }

        private void prodcutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Products products = new Products();
            products.Show();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Show();
        }

        private void Admin_Dashboard_Load(object sender, EventArgs e)
        {
            lblloginuser.Text = Login.userLogged;

        }

        private void Admin_Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
          
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void pblogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void catergoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Categories categories = new Categories();
            categories.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.Show();
        }
    }
}
