using ecommerce.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ecommerce.ecommerceClasses
{
    class ProductDAO : productInterface
    {
        public Product GetProduct(string code)
        {

            SqlConnection conn = connection.GetConnection();
            conn.Open();
            DataTable dt = new DataTable();
            Product product = new Product();
            try
            {
                string req = "select * from product where code=@code";
                SqlCommand cmd = new SqlCommand(req, conn);
                cmd.Parameters.AddWithValue("@code", code);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
                DataRow row = (from prod in dt.AsEnumerable()
                               where prod.Field<string>("code") == code
                               select prod).First();
                product.Brand = row.Field<string>("brand");
                product.Code = row.Field<string>("code");
            }
            catch (Exception e)
            {

            }
            finally
            {
                conn.Close();
            }
            return product;
        }

        public List<Product> getProductsList()
        {
            SqlConnection conn = connection.GetConnection();
            conn.Open();

            DataTable dt = new DataTable();
            List<Product> list = new List<Product>();
            try
            {
                string req = "select * from client";
                SqlCommand cmd = new SqlCommand(req, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
                dt.AsEnumerable();
                foreach (DataRow row in dt.AsEnumerable())
                {
                    Product product = new Product();
                    product.Brand = row.Field<string>("brand");
                    product.Code = row.Field<string>("code");
                    list.Add(product);
                }
            }
            catch (Exception e)
            {

            }
            finally
            {
                conn.Close();
            }
            return list;
        }

        public void removeProduct(string code)
        {
            SqlConnection conn = connection.GetConnection();
            conn.Open();

            try
            {
                string req = "DELETE FROM  product where code=@code";
                SqlCommand cmd = new SqlCommand(req, conn);
                cmd.Parameters.AddWithValue("@code", code);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    Console.WriteLine("Product was successfully removed");
                }
                else
                {
                    Console.WriteLine("An error has occured while removing the Product");
                }

            }
            catch (Exception e)
            {

            }
            finally
            {
                conn.Close();
            }
        }

        public void setProduct(Product product)
        {
            SqlConnection conn = connection.GetConnection();
            conn.Open();

            try
            {
                string req = "insert into product(code,brand,name) values(@code,@brand,@name)";
                SqlCommand cmd = new SqlCommand(req, conn);
                cmd.Parameters.AddWithValue("@code", product.Code);
                cmd.Parameters.AddWithValue("@brand", product.Brand);
                cmd.Parameters.AddWithValue("@name", product.Name);

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    Console.WriteLine("Product was added with success");
                }
                else
                {
                    Console.WriteLine("An error has occured while adding the product");
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                conn.Close();
            }
        }

        public void updateProduct(Product product)
        {

            SqlConnection conn = connection.GetConnection();
            conn.Open();

            try
            {
                string req = "update client set brand=@brand where code=@code";
                SqlCommand cmd = new SqlCommand(req, conn);
                cmd.Parameters.AddWithValue("@code", product.Code);
                cmd.Parameters.AddWithValue("@brand", product.Brand);
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    Console.WriteLine("Product was successfully updated");
                }
                else
                {
                    Console.WriteLine("An error has occured while updating the product");

                }

            }
            catch (Exception e)
            {

            }
            finally
            {
                conn.Close();
            }
        }
    }
}
