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
    public partial class Guest_Dashboard : Form
    {
        public Guest_Dashboard()
        {
            InitializeComponent();
        }

        private void Guest_Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void ProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Foods foods = new Foods();
            foods.Show();
        }

        private void drinksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Drinks drinks = new Drinks();
            drinks.Show();

        }

        private void aBOUTUSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About_us about_Us = new About_us(); 
            about_Us.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
