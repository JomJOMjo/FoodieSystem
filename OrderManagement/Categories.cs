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
    public partial class Categories : Form
    {
        public Categories()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        CategoryL cl = new CategoryL();
        CategoryAL al = new CategoryAL();
        userAL ual = new userAL();

        private void btnupdate_Click(object sender, EventArgs e)
        {
            cl.id =int.Parse(txtid.Text);
            cl.Title = txttitle.Text;
            cl.Description = txtDescript.Text;
            cl.added_date = DateTime.Now;

            string loggedUser = Login.userLogged;
            UserBL usr = ual.GetIDFromusername(loggedUser);

            bool success = al.Update(cl);

            if(success == true)
            {
                MessageBox.Show("Updated Successfully!");
                Clear();

                DataTable dt = al.Select();
                dgvcategory.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Failed to Update!");

            }

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            cl.Title = txttitle.Text;
            cl.Description = txtDescript.Text;
            cl.added_date = DateTime.Now;

            string logginUser = Login.userLogged;
            UserBL usr = ual.GetIDFromusername(logginUser);
           
           

            bool success = al.Insert(cl);

            if(success == true) 
            {
                MessageBox.Show("Inserted Successfully!");
                Clear();
                DataTable dt = al.Select();
                dgvcategory.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Failed to Insert Category!");
            }
        }
        public void Clear()
        {
            txtid.Text = "";
            txttitle.Text = "";
            txtDescript.Text = "";
            txtsearch.Text = "";
        }

        private void Categories_Load(object sender, EventArgs e)
        {
            DataTable dt = al.Select();
            dgvcategory.DataSource = dt;
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            string keywords = txtsearch.Text;

            if(keywords != null)
            {
                DataTable dt = al.Search(keywords);
                dgvcategory.DataSource = dt;
            }
            else
            {
                DataTable dt = al.Select();
                dgvcategory.DataSource = dt;
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            cl.id = int.Parse(txtid.Text);

            bool success = al.Delete(cl);

            if(success == true)
            {
                MessageBox.Show("Category Deleted Successfully!");
                Clear();
                DataTable dt = al.Select();
                dgvcategory.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Failed to delete Category!");
            }

        }

        private void dgvcategory_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int Rowindex = e.RowIndex;
            txtid.Text = dgvcategory.Rows[Rowindex].Cells[0].Value.ToString();
            txttitle.Text = dgvcategory.Rows[Rowindex].Cells[1].Value.ToString();
            txtDescript.Text = dgvcategory.Rows[Rowindex].Cells[2].Value.ToString();
            
        }
    }
}
