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
    class ClientDAO : clientInterface
    {
        public Client GetClient(string code)
        {
            SqlConnection conn = connection.GetConnection();
            conn.Open();

            DataTable dt = new DataTable();
            Client cl = null;
            try
            {
                string req = "select * from client where code=@code";
                SqlCommand cmd = new SqlCommand(req, conn);
                cmd.Parameters.AddWithValue("@code", code);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                DataRow row = (from client in dt.AsEnumerable()
                               where client.Field<string>("code") == code
                               select client).First();
                if (row != null)
                {
                    cl = new Client();
                    cl.Adress = row.Field<string>("adress");
                    cl.Code = row.Field<string>("code");
                    cl.Email = row.Field<string>("email");
                    cl.LastName = row.Field<string>("lastName");
                    cl.Name = row.Field<string>("name");
                    cl.Tel = row.Field<int>("tel");
                }
             
                
            }
            catch (Exception e)
            {

            }
            finally
            {
                conn.Close();
            }
            return cl;
        }

        public List<Client> getClientsList()
        {
            SqlConnection conn = connection.GetConnection();
            conn.Open();

            DataTable dt = new DataTable();
            List<Client> list = null;
            try
            {
                string req = "select * from client";
                SqlCommand cmd = new SqlCommand(req, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                dt.AsEnumerable();
                if (dt.Rows.Count > 0)
                {
                    list = new List<Client>();
                    foreach (DataRow row in dt.AsEnumerable())
                    {
                        Client cl = new Client();
                        cl.Adress = row.Field<string>("adress");
                        cl.Code = row.Field<string>("code");
                        cl.Email = row.Field<string>("email");
                        cl.LastName = row.Field<string>("lastName");
                        cl.Name = row.Field<string>("name");
                        cl.Tel = row.Field<int>("tel");
                        list.Add(cl);
                    }
                }
            }
            catch(Exception e)
            {

            }
            finally
            {
                conn.Close();
            }
            return list;

        }

        public void removeClient(string code)
        {
            SqlConnection conn = connection.GetConnection();
            conn.Open();

            try
            {
                string req = "DELETE FROM  client where code=@code";
                SqlCommand cmd = new SqlCommand(req, conn);
                cmd.Parameters.AddWithValue("@code", code);            
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    Console.WriteLine("Client was successfully removed");
                }
                else
                {
                    Console.WriteLine("An error has occured while removing the client");

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

        public Boolean setClient(Client client)
        {
            SqlConnection conn = connection.GetConnection();
            conn.Open();
            Boolean clientAdded = false;
            try
            {
                if (GetClient(client.Code) == null)
                {
                    string req = "insert into client(code,adress,email,name,lastName,tel) values(@code,@adress,@email,@name,@lastName,@tel)";
                    SqlCommand cmd = new SqlCommand(req, conn);
                    cmd.Parameters.AddWithValue("@code", client.Code);
                    cmd.Parameters.AddWithValue("@adress", client.Adress);
                    cmd.Parameters.AddWithValue("@email", client.Email);
                    cmd.Parameters.AddWithValue("@name", client.Name);
                    cmd.Parameters.AddWithValue("@lastName", client.LastName);
                    cmd.Parameters.AddWithValue("@tel", client.Tel);
                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        Console.WriteLine("Client was added with success");
                        clientAdded = true;
                    }
                    else
                    {
                        Console.WriteLine("An error has occured while adding the client");

                    }
                }
                else
                {
                    throw (new ClIENT_EXISTE_EXCEPTION("There's already a client with the mentioned ID"));
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
            return clientAdded;
        }

        public Boolean updateClient(Client client)
        {

            SqlConnection conn = connection.GetConnection();
            conn.Open();
            Boolean updatedClient = false;
            try
            {
                string req = "update client set adress=@adress, email=@email, name=@name, lastName=@lastName, tel=@tel where code=@code";
                SqlCommand cmd = new SqlCommand(req, conn);
                cmd.Parameters.AddWithValue("@code", client.Code);
                cmd.Parameters.AddWithValue("@adress", client.Adress);
                cmd.Parameters.AddWithValue("@email", client.Email);
                cmd.Parameters.AddWithValue("@name", client.Name);
                cmd.Parameters.AddWithValue("@lastName", client.LastName);
                cmd.Parameters.AddWithValue("@tel", client.Tel);
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    Console.WriteLine("Client was successfully updated");
                    updatedClient = true;
                }
                else
                {
                    Console.WriteLine("An error has occured while updating the client");

                }

            }
            catch (Exception e)
            {

            }
            finally
            {
                conn.Close();
            }
            return updatedClient;
        }
    }
}
