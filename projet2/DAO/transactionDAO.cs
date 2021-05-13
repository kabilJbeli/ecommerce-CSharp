using ecommerce.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ecommerce.ecommerceClasses
{
    class TransactionDAO : transactionInterface
    {
        public Transaction GetTransaction(string code)
        {

            SqlConnection conn = connection.GetConnection();
            conn.Open();
            ClientDAO clientDAO = new ClientDAO();
            ProductDAO productDAO = new ProductDAO();
            DataTable dt = new DataTable();
            Transaction transaction = new Transaction();
            try
            {
                string req = "select * from transactions where code=@code";
                SqlCommand cmd = new SqlCommand(req, conn);
                cmd.Parameters.AddWithValue("@code", code);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                DataRow row = (from trans in dt.AsEnumerable()
                               where trans.Field<string>("code") == code
                               select trans).First();
                transaction.TransactionDate =  row.Field<DateTime>("transactionDate");
                transaction.Code = row.Field<string>("code");
                transaction.Client = clientDAO.GetClient(row.Field<string>("clientID"));
                transaction.Product = productDAO.GetProduct(row.Field<string>("productID"));
            }
            catch (Exception e)
            {

            }
            finally
            {
                conn.Close();
            }
            return transaction;
        }

        public List<Transaction> getTransactionsList()
        {

            SqlConnection conn = connection.GetConnection();
            conn.Open();

            DataTable dt = new DataTable();
            List<Transaction> list = null;
            ClientDAO clientDAO = new ClientDAO();
            ProductDAO productDAO = new ProductDAO();
            try
            {
                string req = "select * from transactions";
                SqlCommand cmd = new SqlCommand(req, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                dt.AsEnumerable();
                if (dt.Rows.Count != 0)
                {
                    foreach (DataRow row in dt.AsEnumerable())
                    {
                        Transaction transaction = new Transaction();
                        transaction.TransactionDate = row.Field<DateTime>("transactionDate");
                        transaction.Code = row.Field<string>("code");
                        transaction.Client = clientDAO.GetClient(row.Field<string>("clientID"));
                        transaction.Product = productDAO.GetProduct(row.Field<string>("productID"));
                        list.Add(transaction);
                    }
                }
                else
                {
                    throw (new PAS_DE_TRANSACTION_EXCEPTION("The Transactions List Is Currently Empty"));
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

        public void removeTransaction(string code)
        {
            SqlConnection conn = connection.GetConnection();
            conn.Open();

            try
            {
                string req = "DELETE FROM  transactions where code=@code";
                SqlCommand cmd = new SqlCommand(req, conn);
                cmd.Parameters.AddWithValue("@code", code);
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    Console.WriteLine("Transaction was successfully removed");
                }
                else
                {
                    Console.WriteLine("An error has occured while removing the Transaction");
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

        public void setTransaction(Transaction transaction)
        {
            SqlConnection conn = connection.GetConnection();
            conn.Open();

            try
            {
                DateTime date = DateTime.UtcNow;
                ProductDAO productDAO = new ProductDAO();
                Product product = productDAO.GetProduct(transaction.Product.Code);
                if (product.Quantity >= transaction.Quantity)
                {

               
                string req = "insert into transactions(code,transactionDate,clientID,productID,quantity) values(@code,@transactionDate,@clientID,@productID,@quantity)";
                SqlCommand cmd = new SqlCommand(req, conn);
                cmd.Parameters.AddWithValue("@code", transaction.Code);
                cmd.Parameters.AddWithValue("@transactionDate", date);

                cmd.Parameters.AddWithValue("@productID", transaction.Product.Code);
                cmd.Parameters.AddWithValue("@clientID", transaction.Client.Code);
                cmd.Parameters.AddWithValue("@quantity", transaction.Quantity);

                    int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                        int availableQuantity = product.Quantity - transaction.Quantity;
                        product.Quantity = availableQuantity;
                        productDAO.setQuantityProduct(product);
                    Console.WriteLine("Transaction was added with success");
                }
                else
                {
                    Console.WriteLine("An error has occured while adding the transaction");
                }
                }
                else
                {
                    throw new INSUFFICIENT_QUANTITY("The requested quantity should be less or equal to the avaliable product ");

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

        public void updateTransaction(Transaction transaction)
        {

            SqlConnection conn = connection.GetConnection();
            conn.Open();

            try
            {
                ProductDAO productDAO = new ProductDAO();
                Product product = productDAO.GetProduct(transaction.Product.Code);
                if (product.Quantity >= transaction.Quantity)
                {

                    string req = "update transactions set transactionDate=@transactionDate,quantity=@quantity where code=@code";
                    SqlCommand cmd = new SqlCommand(req, conn);
                    cmd.Parameters.AddWithValue("@code", transaction.Code);
                    cmd.Parameters.AddWithValue("@transactionDate", transaction.TransactionDate);
                    cmd.Parameters.AddWithValue("@quantity", transaction.Quantity);


                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        Console.WriteLine("Transaction was successfully updated");
                    }
                    else
                    {
                        Console.WriteLine("An error has occured while updating the transaction");
                    }
                }
                else
                {
                    Console.WriteLine("The requested quantity should be less or equal to the avaliable product ");
                    throw (new INSUFFICIENT_QUANTITY("The requested quantity should be less or equal to the avaliable product "));
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
        public double repartition()
        { ClientDAO clientDAO = new ClientDAO();
            List<Transaction> TL = getTransactionsList();
            List<Client> CL = clientDAO.getClientsList();
            double res = new double();


            return res;
        }
    }
}
