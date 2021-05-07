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
    class TransactionDAO : transactionInterface
    {
        public Transaction GetTransaction(string code)
        {

            SqlConnection conn = connection.GetConnection();
            conn.Open();

            DataTable dt = new DataTable();
            Transaction transaction = new Transaction();
            try
            {
                string req = "select * from transaction where code=@code";
                SqlCommand cmd = new SqlCommand(req, conn);
                cmd.Parameters.AddWithValue("@code", code);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                DataRow row = (from trans in dt.AsEnumerable()
                               where trans.Field<string>("code") == code
                               select trans).First();
                transaction.TransactionDate =  row.Field<DateTime>("transactionDate");
                transaction.Code = row.Field<string>("code");

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
            List<Transaction> list = new List<Transaction>();
            try
            {
                string req = "select * from transaction";
                SqlCommand cmd = new SqlCommand(req, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                dt.AsEnumerable();
                foreach (DataRow row in dt.AsEnumerable())
                {
                    Transaction transaction = new Transaction();
                    transaction.TransactionDate = row.Field<DateTime>("transactionDate");
                    transaction.Code = row.Field<string>("code");
                    list.Add(transaction);
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
                string req = "DELETE FROM  transaction where code=@code";
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
                string req = "insert into transaction(code,transactionDate,productID,clientID) values(@code,@transactionDate,@productID,@clientID)";
                SqlCommand cmd = new SqlCommand(req, conn);
                cmd.Parameters.AddWithValue("@code", transaction.Code);
                cmd.Parameters.AddWithValue("@transactionDate", date);

                cmd.Parameters.AddWithValue("@productID", transaction.Product.Code);
                cmd.Parameters.AddWithValue("@clientID", transaction.Client.Code);

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    Console.WriteLine("Transaction was added with success");
                }
                else
                {
                    Console.WriteLine("An error has occured while adding the transaction");
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
                string req = "update transaction set transactionDate=@transactionDate where code=@code";
                SqlCommand cmd = new SqlCommand(req, conn);
                cmd.Parameters.AddWithValue("@code", transaction.Code);
                cmd.Parameters.AddWithValue("@transactionDate", transaction.TransactionDate);
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
