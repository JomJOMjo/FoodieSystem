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

namespace OrderManagement
{
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }
        UserBL u = new UserBL();
        userAL a = new userAL();
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void User_Load(object sender, EventArgs e)
        {
            DataTable dt = a.Select();
            dgvUsers.DataSource = dt;
        }

        private void Clear()
        {
            txtuserID.Text = "";
            txtfname.Text = "";
            txtLname.Text = "";
            txtEmail.Text = "";
            txtusername.Text = "";
            txtpass.Text = "";
            txtcontact.Text = "";
            txtaddress.Text = "";
            cbgender.Text = "";
            cbuserType.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

           
            u.First_name = txtusername.Text;
            u.Last_name = txtLname.Text;
            u.Email = txtEmail.Text;
            u.Username = txtusername.Text;
            u.Password = txtpass.Text;
            u.contact = txtcontact.Text;
            u.address = txtaddress.Text;
            u.gender = cbgender.Text;
            u.User_Type = cbuserType.Text;
            u.added_date = DateTime.Now;

            string userloggedin = Login.userLogged;
            UserBL user = a.GetIDFromusername(userloggedin);


            u.added_by = user.userId;
            

            bool success  = a.Insert(u);
            if (success==true) 
            {
                MessageBox.Show("Successfully Created!");
                Clear();
            }
            else
            {
                MessageBox.Show("Failed to create User!");
            }
            DataTable dt = a.Select();
            dgvUsers.DataSource = dt;

        }

        private void dgvUsers_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            txtuserID.Text = dgvUsers.Rows[rowIndex].Cells[0].Value.ToString();
            txtfname.Text = dgvUsers.Rows[rowIndex].Cells[1].Value.ToString();
            txtLname.Text = dgvUsers.Rows[rowIndex].Cells[2].Value.ToString();
            txtEmail.Text = dgvUsers.Rows[rowIndex].Cells[3].Value.ToString();
            txtusername.Text = dgvUsers.Rows[rowIndex].Cells[4].Value.ToString();
            txtpass.Text = dgvUsers.Rows[rowIndex].Cells[5].Value.ToString();
            txtcontact.Text = dgvUsers.Rows[rowIndex].Cells[6].Value.ToString();
            txtaddress.Text = dgvUsers.Rows[rowIndex].Cells[7].Value.ToString();
            cbgender.Text = dgvUsers.Rows[rowIndex].Cells[8].Value.ToString();
            cbuserType.Text = dgvUsers.Rows[rowIndex].Cells[9].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            u.userId = Convert.ToInt32(txtuserID.Text);
            u.First_name = txtfname.Text;
            u.Last_name = txtLname.Text;
            u.Email =txtEmail.Text;
            u.Username = txtusername.Text;
            u.Password = txtpass.Text;
            u.contact = txtcontact.Text;
            u.address = txtaddress.Text;
            u.gender = cbgender.Text;
            u.User_Type = cbuserType.Text;
            u.added_date = DateTime.Now;
            u.added_by = 1;
          

            bool success  = a.Update(u);
            if(success == true)
            {
                MessageBox.Show("User successfully Updated!");
            }
            else
            {
                MessageBox.Show("Failed to updaate user!");

            }

            DataTable dt = a.Select();
            dgvUsers.DataSource = dt;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            u.userId = Convert.ToInt32(txtuserID.Text);
            bool success = a.Delete(u);

            if(success == true) 
            {
                MessageBox.Show("User deleted successfully!");
            }
            else
            {
                MessageBox.Show("Failed to delete user!");
            }
            DataTable dt = a.Select();
            dgvUsers.DataSource= dt;
        }

        private void textSearch_TextChanged(object sender, EventArgs e)
        {
            string keywords = txtSearch.Text;
            if (keywords != null)
            {
                DataTable dt = a.Search(keywords);
                dgvUsers.DataSource = dt;
            }
            else
            {
                DataTable dt = a.Select();
                dgvUsers.DataSource = dt;
            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
