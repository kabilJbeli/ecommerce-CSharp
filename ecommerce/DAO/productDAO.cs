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
            Product prod =null;
            try
            {
                string req = "select * from product where code=@code";
                SqlCommand cmd = new SqlCommand(req, conn);
                cmd.Parameters.AddWithValue("@code", code);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
       
                DataRow row = (from product in dt.AsEnumerable()
                               where product.Field<string>("code") == code
                               select product).First();
                if (row != null)
                {
                    prod = new Product();
                    prod.Brand = row.Field<string>("brand");
                    prod.Code = row.Field<string>("code");
                    prod.Name = row.Field<string>("name");
                }
            }
            catch (Exception e){}
            finally
            {
                conn.Close();
            }
            return prod;
        }

        public List<Product> getProductsList()
        {
            SqlConnection conn = connection.GetConnection();
            conn.Open();

            DataTable dt = new DataTable();
            List<Product> list = null;
            try
            {
                string req = "select * from product";
                SqlCommand cmd = new SqlCommand(req, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                dt.AsEnumerable();
                if (dt.Rows.Count != 0)
                {
                    list = new List<Product>();
                    foreach (DataRow row in dt.AsEnumerable())
                    {
                        Product product = new Product();
                        product.Brand = row.Field<string>("brand");
                        product.Name = row.Field<string>("name");
                        product.Code = row.Field<string>("code");
                        list.Add(product);
                    }
                }
                else
                {
                    throw (new PAS_DE_PRODUITS_EXCEPTION("The Product List Is Currently Empty"));
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

        public Boolean setProduct(Product product)
        {
            SqlConnection conn = connection.GetConnection();
            conn.Open();
            Boolean productSeted = false;
            try
            {
                if (GetProduct(product.Code) == null)
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
                       productSeted = true;
                    }
                    else
                {
                    Console.WriteLine("An error has occured while adding the product");

                    }
                }
                else
                {
                    throw (new PRODUIT_EXISTE_EXCEPTION("Product With the same code ID already exist"));
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
            return productSeted;

        }

        public Boolean updateProduct(Product product)
        {

            SqlConnection conn = connection.GetConnection();
            conn.Open();
           Boolean productUpdated = false;
            try
            {
                string req = "update product set brand=@brand,name=@name where code=@code";
                SqlCommand cmd = new SqlCommand(req, conn);
                cmd.Parameters.AddWithValue("@code", product.Code);
                cmd.Parameters.AddWithValue("@name", product.Name);
                cmd.Parameters.AddWithValue("@brand", product.Brand);
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    Console.WriteLine("Product was successfully updated");
                    productUpdated = true;
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
            return productUpdated;
        }
    }
}
