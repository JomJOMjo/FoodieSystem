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
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtDescript_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        CategoryAL cal = new CategoryAL();
        ProductL p = new ProductL();
        ProductAL pal = new ProductAL();
        userAL ual = new userAL();
       
        private void Products_Load(object sender, EventArgs e)
        {
            DataTable catdt = cal.Select();
            cmbCategory.DataSource = catdt;
            cmbCategory.DisplayMember = "Title";
            cmbCategory.ValueMember = "Title";

            DataTable dt = pal.Select();
            dgvprod.DataSource = dt;
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            p.Name = txtname.Text;
            p.Category = cmbCategory.Text;
            p.Description = txtdescription.Text;
            p.rate = decimal.Parse(txtrate.Text);
            p.qty = 0;
            p.added_date = DateTime.Now;
            String Loggeduser = Login.userLogged;
            UserBL usr = ual.GetIDFromusername(Loggeduser);


            bool success = pal.Insert(p);
            if (success == true)
            {
                MessageBox.Show("Product Added Successfully!");
                DataTable dt = pal.Select();
                dgvprod.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Failed to Add Product!");
            }
        }
        public void Clear()
        {
            txtprodid.Text = "";
            txtname.Text = "";
            txtdescription.Text = "";
            txtrate.Text = "";
            txtSearch.Text = "";
        }

        private void dgvprod_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            txtprodid.Text = dgvprod.Rows[rowIndex].Cells[0].Value.ToString();
            txtname.Text = dgvprod.Rows[rowIndex].Cells[1].Value.ToString();
            cmbCategory.Text = dgvprod.Rows[rowIndex].Cells[2].Value.ToString();
            txtdescription.Text = dgvprod.Rows[rowIndex].Cells[3].Value.ToString();
            txtrate.Text = dgvprod.Rows[rowIndex].Cells[4].Value.ToString();


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            p.id = int.Parse(txtprodid.Text);
            p.Name = txtname.Text;
            p.Category = cmbCategory.Text;
            p.Description = txtdescription.Text;
            p.rate = decimal.Parse(txtrate.Text);
            p.added_date = DateTime.Now;

            String Loggeduser = Login.userLogged;
            UserBL usr = ual.GetIDFromusername(Loggeduser);

        

            bool success = pal.Update(p);
            if(success ==  true)
            {
                MessageBox.Show("Product Successfully Updated!");
                Clear();

                DataTable dt = pal.Select();
                dgvprod.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Failed to Update Product!");
            }

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            p.id = int.Parse(txtprodid.Text);
            bool success = pal.Delete(p);

            if(success == true) 
            {
                MessageBox.Show("Product Deleted Successfully!");
                Clear();

                DataTable dt = pal.Select();
                dgvprod.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Failed to delete Product!");
            }

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keywords = txtSearch.Text;
            if(keywords !=null)
            {
                DataTable dt = pal.Search(keywords);
                dgvprod.DataSource = dt;
            }
            else
            {
                DataTable dt = pal.Select();
                dgvprod.DataSource = dt;


            }
        }
    }
}
