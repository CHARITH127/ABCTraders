using ABCTraders.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCTraders.Services
{
    internal class UserService
    {
        private string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=CarTraderDB;Integrated Security=True;Encrypt=False";
        public UserService() { }

        public bool AddUser(string username, string password, string role)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO Users (Username, Password, Role) VALUES (@Username, @Password, @Role)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);
                    cmd.Parameters.AddWithValue("@Role", role);
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public void UpdateCustomerPassword(int customerId, string newPassword)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE Users SET Password = @Password WHERE UserID = @UserID AND Role = 'customer'";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserID", customerId);
                    command.Parameters.AddWithValue("@Password", newPassword);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public bool DeleteUser(int id)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM Users WHERE UserID = @Id";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Id", id);
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public bool UserExists(int id)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = "SELECT COUNT(1) FROM Users WHERE UserID = @Id";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Id", id);
                    con.Open();
                    return (int)cmd.ExecuteScalar() > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public DataTable GetAllCustomers()
        {
            using (var connection = new SqlConnection(connectionString))
            {
                string query = "SELECT UserID, Username, Password, Role FROM Users WHERE Role = 'customer'";
                using (var adapter = new SqlDataAdapter(query, connection))
                {
                    var customers = new DataTable();
                    adapter.Fill(customers);
                    return customers;
                }
            }
        }

        public DataTable GetCustomerByIdGrid(int customerId)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                string query = "SELECT UserID, Username, Password, Role FROM Users WHERE UserID = @UserID AND Role = 'customer'";
                using (var adapter = new SqlDataAdapter(query, connection))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@UserID", customerId);
                    var customer = new DataTable();
                    adapter.Fill(customer);
                    return customer;
                }
            }
        }

        public int GetUserIdByUsername(string username)
        {
            
            string query = "SELECT UserID FROM Users WHERE Username = @Username";

            using (var connection = new SqlConnection(connectionString))
            {
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    connection.Open();

                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        return Convert.ToInt32(result);
                    }
                    else
                    {
                        throw new Exception("User not found.");
                    }
                }
            }
        }

    }
}
