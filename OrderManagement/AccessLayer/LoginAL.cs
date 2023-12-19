using OrderManagement.BusinessLayer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderManagement.AccessLayer
{
    class LoginAL
    {
        static string connstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
        public bool loginCheck(LoginLayer l)
        {
            bool isSuccess = false;


            SqlConnection conn = new SqlConnection(connstrng);

            try
            {
                string sql = "SELECT * FROM Users WHERE Username=@Username AND Password=@Password AND User_Type=@User_Type";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Username", l.Username);
                cmd.Parameters.AddWithValue("@Password", l.Password);
                cmd.Parameters.AddWithValue("@User_Type", l.User_Type);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if(dt.Rows.Count > 0 ) 
                { 
                    isSuccess = true;
                }
                else
                {
                    isSuccess= false;
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
    }
}
