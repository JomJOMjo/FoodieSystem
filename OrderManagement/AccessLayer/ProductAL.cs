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
   internal class ProductAL
    {
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
        #region Select Method for Product
        public DataTable Select()
        {
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();

            try
            {
                String sql = "SELECT * FROM Products";

                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);  

                conn.Open();
                adapter.Fill(dt);
            }
            catch(Exception ex) 
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
        #region Inser new Product
        public bool Insert(ProductL p)
        {

            bool isSuccess = false;

    
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
             
                String sql = "INSERT INTO Products (Name, Category, Description, rate, qty, added_date) VALUES (@Name, @Category, @Description, @rate, @qty, @added_date)";

             
                SqlCommand cmd = new SqlCommand(sql, conn);

            
                cmd.Parameters.AddWithValue("@Name", p.Name);
                cmd.Parameters.AddWithValue("@Category", p.Category);
                cmd.Parameters.AddWithValue("@Description", p.Description);
                cmd.Parameters.AddWithValue("@rate", p.rate);
                cmd.Parameters.AddWithValue("@qty", p.qty);
                cmd.Parameters.AddWithValue("@added_date", p.added_date);
            


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
        #region Update Products
        public bool Update(ProductL p)
        {
            //create a boolean variable and set its initial value to false
            bool isSuccess = false;

            //Create SQL Connection for DAtabase
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                //SQL Query to Update Data in dAtabase
                String sql = "UPDATE Products SET name=@Name, Category=@Category, Description=@Description, rate=@rate, added_date=@added_date WHERE id=@id";

                //Create SQL Cmmand to pass the value to query
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Passing the values using parameters and cmd
                cmd.Parameters.AddWithValue("@Name", p.Name);
                cmd.Parameters.AddWithValue("@Category", p.Category);
                cmd.Parameters.AddWithValue("@Description", p.Description);
                cmd.Parameters.AddWithValue("@rate", p.rate);
                cmd.Parameters.AddWithValue("@qty", p.qty);
                cmd.Parameters.AddWithValue("@added_date", p.added_date);
                cmd.Parameters.AddWithValue("@id", p.id);

           
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
        #region Delete Products
        public bool Delete(ProductL p)
        {
         
            bool isSuccess = false;

           
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
             
                String sql = "DELETE FROM Products WHERE id=@id";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", p.id);
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
        #region Search Products
        public DataTable Search(string keywords)
        {
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT * FROM Products WHERE id LIKE '%" + keywords + "%' OR Name LIKE '%" + keywords + "%' OR Category LIKE '%" + keywords + "%'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();

                adapter.Fill(dt);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close ();
            }

            return dt;
             
        }
        #endregion
        #region search customer for products
        public ProductL searchcustomerproducts(string keywords)
        {
            ProductL pl = new ProductL();
            SqlConnection conn = new SqlConnection(myconnstrng);

            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT Name, rate,qty from Products WHERE id LIKE '%" + keywords + "%' OR Name LIKE '%" + keywords + "%'";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);

                conn.Open();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    pl.Name = dt.Rows[0]["Name"].ToString();
                    pl.rate = decimal.Parse(dt.Rows[0]["rate"].ToString());
                    pl.qty = decimal.Parse(dt.Rows[0]["qty"].ToString());
                    
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
            return pl;

        }
    }
    #endregion
}

