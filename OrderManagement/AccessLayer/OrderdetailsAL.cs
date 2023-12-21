using OrderManagement.BusinessLayer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderManagement.AccessLayer
{
    internal class OrderdetailsAL
    {

        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        #region Insert Trans
        public bool Insert(order_detailsL odl)
        {

            bool isSuccess = false;


            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {

                String sql = "INSERT INTO order_detail (product_id, rate, qty,total, cust_id, added_date) VALUES (@product_id, @rate, @qty, @total, @cust_id @added_date)";


                SqlCommand cmd = new SqlCommand(sql, conn);


                cmd.Parameters.AddWithValue("@product_id", odl.product_id);
                cmd.Parameters.AddWithValue("@rate", odl.rate);
                cmd.Parameters.AddWithValue("@qty", odl.qty);
                cmd.Parameters.AddWithValue("@total", odl.total);
                cmd.Parameters.AddWithValue("@cust_id", odl.cust_id);
                cmd.Parameters.AddWithValue("@added_date", odl.added_date);



                conn.Open();

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                
                    isSuccess = true;
                }
                else
                {

                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return isSuccess;
        }
        #endregion
    }
}
