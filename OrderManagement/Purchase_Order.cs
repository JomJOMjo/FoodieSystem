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
    public partial class Purchase_Order : Form
    {
        public Purchase_Order()
        {
            InitializeComponent();
        }
        CustomerAL cal = new CustomerAL();
        ProductAL pal = new ProductAL();
        DataTable orderDT = new DataTable();

        private void pblogout1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void Purchase_Order_Load(object sender, EventArgs e)
        {
            string type = User_Dashboard.ordertype;
            lbltop.Text = type;
            orderDT.Columns.Add("Product Name");
            orderDT.Columns.Add("rate");
            orderDT.Columns.Add("Quantity");
            orderDT.Columns.Add("Total");
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            string keywords = textBox4.Text;

            if (keywords == "")
            {
                txtname.Text = "";
                txtemail.Text = "";
                txtcontact.Text = "";
                txtAddress.Text = "";

            }
            CustomerL cl = cal.searchcustomerorders(keywords);

            txtname.Text = cl.Name;
            txtemail.Text = cl.Email;
            txtcontact.Text = cl.contact;
            txtAddress.Text = cl.address;

        }

        private void txtsearchprod_TextChanged(object sender, EventArgs e)
        {
            string keywords = txtsearchprod.Text;

            if (keywords == "")
            {
                txtName2.Text = "";
                txtInv.Text = "0";
                txtrate.Text = "0";
                txtqty.Text = "0";
                return;
            }
            ProductL pl = pal.searchcustomerproducts(keywords);

            txtName2.Text = pl.Name;
            txtInv.Text = pl.qty.ToString();
            txtrate.Text = pl.rate.ToString();
           

        }

        private void btnPO_Click(object sender, EventArgs e)
        {
            string prodname = txtName2.Text;
            decimal rate = decimal.Parse(txtrate.Text);
            decimal qty = decimal.Parse(txtqty.Text);
            decimal Total = rate * qty;

       
      
            if (prodname == "")
            {
                MessageBox.Show("Please choose products First.Try again!");

            }
            else
            {
                orderDT.Rows.Add(prodname, rate, qty, Total);
                dgvaddprod.DataSource = orderDT;
         
            }
        }
   

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtamount_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void dgvaddprod_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
