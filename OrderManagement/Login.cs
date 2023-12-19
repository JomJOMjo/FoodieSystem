using OrderManagement.AccessLayer;
using OrderManagement.BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace OrderManagement
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        LoginLayer l = new LoginLayer();
        LoginAL la = new LoginAL();
        public static string userLogged;

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            l.Username = txtuser.Text.Trim();
            l.Password = txtpass.Text.Trim();
            l.User_Type = cbrole.Text.Trim();

            bool success = la.loginCheck(l);
            if (success == true)
            {
                MessageBox.Show("Successfully Login!");
                userLogged = l.Username;
              

                switch (l.User_Type)
                {
                    case "Admin":
                        {
                            Admin_Dashboard ad = new Admin_Dashboard();
                            ad.Show();
                            this.Hide();
                        }
                        break;
                    case "User":
                        {
                            User_Dashboard ud = new User_Dashboard();
                            ud.Show();
                            this.Hide();
                        }
                        break;
                    default:
                        {
                            MessageBox.Show("Invalid User Type!");
                        }
                        break;
                }
            }
            else
            {
                MessageBox.Show("Login Failed.Pls try again!");
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
           Close();
        }

        private void cbspassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbspassword.Checked)
            {
                txtpass.UseSystemPasswordChar = false;
            }
            else
            {
                txtpass.UseSystemPasswordChar = true;
            }
        }

        private void linkGuest_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Guest_Dashboard gd = new Guest_Dashboard();
            gd.Show();
            this.Hide();
        }
    }
}
