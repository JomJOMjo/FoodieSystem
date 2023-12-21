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
    internal class OrderAL
    {
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        #region Insert Trans
        public bool Insert(OrderL ol, out int orderid)
        {

            bool isSuccess = false;

            orderid = -1;


            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {

                String sql = "INSERT INTO Order (Type, cust_id, g_Total,trans_date, Tax, Discount) VALUES (@Type, @cust_id, @g_Total, @trans_date, @Tax, @Discount)";


                SqlCommand cmd = new SqlCommand(sql, conn);


                cmd.Parameters.AddWithValue("@Type", ol.Type);
                cmd.Parameters.AddWithValue("@cust_id", ol.cust_id);
                cmd.Parameters.AddWithValue("@g_Total",ol.g_Total);
                cmd.Parameters.AddWithValue("@trans_date", ol.trans_date);
                cmd.Parameters.AddWithValue("@Tax", ol.Tax);
                cmd.Parameters.AddWithValue("@Discount",ol.Discount);



                conn.Open();
                
                object o = cmd.ExecuteScalar();
                if(o != null)
                {
                    orderid = int.Parse(o.ToString());
                    isSuccess = true;
                }
                else {

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
