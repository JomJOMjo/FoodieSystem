using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrderManagement.BusinessLayer;

namespace OrderManagement.AccessLayer
{
    internal class CustomerAL
    {
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        #region Select Method for Customer
        public DataTable Select()
        {
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();

            try
            {
                String sql = "SELECT * FROM Customer";

                SqlCommand cmd = new SqlCommand(sql, conn);
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
        #region Inser new Product
        public bool Insert(CustomerL cl)
        {

            bool isSuccess = false;


            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {

                String sql = "INSERT INTO Customer (Type, Name, Email, contact, address, added_date) VALUES (@Type, @Name, @Email, @contact, @address, @added_date)";


                SqlCommand cmd = new SqlCommand(sql, conn);


                cmd.Parameters.AddWithValue("@Type", cl.Type);
                cmd.Parameters.AddWithValue("@Name", cl.Name);
                cmd.Parameters.AddWithValue("@Email", cl.Email);
                cmd.Parameters.AddWithValue("@contact", cl.contact);
                cmd.Parameters.AddWithValue("@address", cl.address);
                cmd.Parameters.AddWithValue("@added_date", cl.added_date);



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
        #region Update Customer
        public bool Update(CustomerL cl)
        {
            //create a boolean variable and set its initial value to false
            bool isSuccess = false;

            //Create SQL Connection for DAtabase
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                //SQL Query to Update Data in dAtabase
                String sql = "UPDATE Customer SET Type=@Type, Name=@Name, Email=@Email, contact=@contact, added_date=@added_date WHERE id=@id";

                //Create SQL Cmmand to pass the value to query
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Passing the values using parameters and cmd
                cmd.Parameters.AddWithValue("@Type", cl.Type);
                cmd.Parameters.AddWithValue("@Name", cl.Name);
                cmd.Parameters.AddWithValue("@Email", cl.Email);
                cmd.Parameters.AddWithValue("@contact", cl.contact);
                cmd.Parameters.AddWithValue("@address", cl.address);
                cmd.Parameters.AddWithValue("@added_date", cl.added_date);
                cmd.Parameters.AddWithValue("@id", cl.id);


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
        #region Delete Customer
        public bool Delete(CustomerL cl)
        {

            bool isSuccess = false;


            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {

                String sql = "DELETE FROM Customer WHERE id=@id";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", cl.id);
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
        #region Search Customer
        public DataTable Search(string keywords)
        {
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT * FROM Customer WHERE id LIKE '%" + keywords + "%' OR Type LIKE '%" + keywords + "%' OR Name LIKE '%" + keywords + "%'";
                SqlCommand cmd = new SqlCommand(sql, conn);
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
        #region search customer for orders
        public CustomerL searchcustomerorders(string keywords)
        {
            CustomerL cl = new CustomerL(); 
            SqlConnection conn = new SqlConnection(myconnstrng);

            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT Name, Email, contact, address from Customer WHERE id LIKE '%" + keywords + "%' OR Name LIKE '%" + keywords + "%'";
                SqlDataAdapter adapter = new SqlDataAdapter(sql,conn); 

                conn.Open();
                adapter.Fill(dt);
                if(dt.Rows.Count > 0) 
                {
                    cl.Name = dt.Rows[0]["Name"].ToString();
                    cl.Email = dt.Rows[0]["Email"].ToString();
                    cl.contact = dt.Rows[0]["contact"].ToString();
                    cl.address = dt.Rows[0]["address"].ToString();
                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message );
            }
            finally
            {
                conn.Close();
            }
            return cl;
              
            }
        }
        #endregion

    }


