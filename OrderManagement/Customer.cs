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
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Customer_Load(object sender, EventArgs e)
        {

        }
        CustomerL cl = new CustomerL();
        CustomerAL cal = new CustomerAL();
        userAL ual = new userAL();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            cl.Type = cmbType.Text;
            cl.Name = txtName.Text;
            cl.Email = txtEmail.Text;
            cl.contact = txtcontact.Text;
            cl.address = txtaddress.Text;
            cl.added_date = DateTime.Now;

            string loggedUser = Login.userLogged;
            UserBL usr = ual.GetIDFromusername(loggedUser);

            bool success = cal.Insert(cl);

            if (success == true)
            {
                MessageBox.Show("Added Successfully!");
                Clear();
                DataTable dt = cal.Select();
                dgvCustomer.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Failed to add Customer!");
            }
        }
        public void Clear()
        {
            txtcustid.Text = "";
            cmbType.Text = "";
            txtName.Text = "";
            txtcontact.Text = "";
            txtaddress.Text = "";
            txtsearch.Text = "";
        }

        private void dgvCustomer_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void dgvCustomer_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int Rowindex = e.RowIndex;

           txtcustid.Text = dgvCustomer.Rows[Rowindex].Cells[0].Value.ToString();
            cmbType.Text = dgvCustomer.Rows[Rowindex].Cells[1].Value.ToString();
             txtName.Text = dgvCustomer.Rows[Rowindex].Cells[2].Value.ToString();
            txtEmail.Text = dgvCustomer.Rows[Rowindex].Cells[3].Value.ToString();
            txtcontact.Text = dgvCustomer.Rows[Rowindex].Cells[4].Value.ToString();
            txtaddress.Text = dgvCustomer.Rows[Rowindex].Cells[5].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            cl.id = int.Parse(txtcustid.Text);
            cl.Type = cmbType.Text;
            cl.Name = txtName.Text;
            cl.Email = txtEmail.Text;
            cl.contact = txtcontact.Text;
            cl.address = txtaddress.Text;
            cl.added_date = DateTime.Now;

            string loggedUser = Login.userLogged;
            UserBL usr = ual.GetIDFromusername(loggedUser);

            bool success = cal.Update(cl);

            if (success == true)
            {
                MessageBox.Show("Updated Successfully!");
                Clear();

                DataTable dt = cal.Select();
               dgvCustomer.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Failed to Update!");

            }

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            cl.id = int.Parse(txtcustid.Text);

            bool success = cal.Delete(cl);

            if (success == true)
            {
                MessageBox.Show("Customer Deleted Successfully!");
                Clear();
                DataTable dt = cal.Select();
              dgvCustomer.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Failed to delete Customer!");
            }

        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            string keywords = txtsearch.Text;

            if (keywords != null)
            {
                DataTable dt = cal.Search(keywords);
               dgvCustomer.DataSource = dt;
            }
            else
            {
                DataTable dt = cal.Select();
               dgvCustomer.DataSource = dt;
            }
        }
    }
   }
 
  
