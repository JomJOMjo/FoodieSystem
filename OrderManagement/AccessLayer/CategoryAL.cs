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
    internal class CategoryAL
    {
        static string myconnstring = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
        #region Select Method

        public DataTable Select()
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable(); 

            try
            {
                string sql = "SELECT * FROM Categories";
                SqlCommand cmd = new SqlCommand(sql,conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
        #endregion
        #region Insert new Category
        public bool Insert(CategoryL c)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstring);

            try
            {
                string sql = "INSERT INTO Categories (Title, Description, added_date, added_by)VALUES(@Title, @Description, @added_date, @added_by)";
                SqlCommand cmd = new SqlCommand(sql,conn);
                cmd.Parameters.AddWithValue("@Title", c.Title);
                cmd.Parameters.AddWithValue("@Description", c.Description);
                cmd.Parameters.AddWithValue("@added_date", c.added_date);
                cmd.Parameters.AddWithValue("@added_by", c.added_by);
                conn.Open();

                //CREATE int to execute query
                int rows = cmd.ExecuteNonQuery();

                //if the query is executed successfully then its value will be greater than 0 else it ill will be less than 0 
                if(rows > 0) 
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }

            }
            catch(Exception ex)
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
        #region Update Caterogry
        public bool Update(CategoryL c)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstring);

            try
            {
                string sql = "UPDATE Categories SET Title=@Title,Description=@Description,added_date=@added_date,added_by=@added_by WHERE id =@id";

                SqlCommand cmd  = new SqlCommand (sql,conn);

                cmd.Parameters.AddWithValue("@Title", c.Title);
                cmd.Parameters.AddWithValue("@Description", c.Description);
                cmd.Parameters.AddWithValue("@added_date", c.added_date);
                cmd.Parameters.AddWithValue("@added_by", c.added_by);
                cmd.Parameters.AddWithValue("@id", c.id);

                conn.Open();

                int rows = cmd.ExecuteNonQuery();

                if(rows > 0) 
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
                MessageBox.Show (ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return isSuccess;
        }
        #endregion C
        #region Delete Category
        public bool Delete(CategoryL c) 
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection (myconnstring);

            try
            {
                string sql = "DELETE FROM Categories WHERE id=@id";
                SqlCommand cmd = new SqlCommand(sql,conn);

                cmd.Parameters.AddWithValue("@id", c.id);

                conn.Open();

                int rows = cmd.ExecuteNonQuery();

                //if the query is executed successfully then the value of row will be greater than zero else it will be less than 0
                
                if(rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch(Exception ex) 
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
        #region Search Category
        public DataTable Search(string keywords)
        {
            SqlConnection conn = new SqlConnection (myconnstring);

            DataTable dt = new DataTable ();

            try
            {
                String sql = "SELECT * FROM Categories WHERE id LIKE '%" + keywords + "%' OR Title LIKE '%" + keywords + "%' OR  Description LIKE '%" + keywords + "%'";
                SqlCommand cmd = new SqlCommand (sql,conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                conn.Open();
                adapter.Fill (dt);

            }
            catch(Exception ex) 
            {
                MessageBox.Show (ex.Message);
            }
            finally
            {
                conn.Close ();
            }

            return dt;
        }
        #endregion

    }
}
