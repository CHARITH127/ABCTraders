using ABCTraders.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCTraders.Services
{
    internal class CarPartsService
    {

        private string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=CarTraderDB;Integrated Security=True;Encrypt=False";


        public List<CarPart> GetAllCarParts()
        {
            List<CarPart> carParts = new List<CarPart>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM CarParts";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    CarPart carPart = new CarPart
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        Name = reader["Name"].ToString(),
                        Model = reader["Model"].ToString(),
                        UnitPrice = Convert.ToDecimal(reader["UnitPrice"]),
                        Quantity = Convert.ToInt32(reader["Quantity"])
                    };
                    carParts.Add(carPart);
                }
            }

            return carParts;
        }

        public bool InsertCarPart(CarPart carPart)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO CarParts (Name, Model, UnitPrice, Quantity) VALUES (@Name, @Model, @UnitPrice, @Quantity)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Name", carPart.Name);
                cmd.Parameters.AddWithValue("@Model", carPart.Model);
                cmd.Parameters.AddWithValue("@UnitPrice", carPart.UnitPrice);
                cmd.Parameters.AddWithValue("@Quantity", carPart.Quantity);
                conn.Open();

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool UpdateCarPart(CarPart carPart)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE CarParts SET Name = @Name, Model = @Model, UnitPrice = @UnitPrice, Quantity = @Quantity WHERE Id = @Id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", carPart.Id);
                cmd.Parameters.AddWithValue("@Name", carPart.Name);
                cmd.Parameters.AddWithValue("@Model", carPart.Model);
                cmd.Parameters.AddWithValue("@UnitPrice", carPart.UnitPrice);
                cmd.Parameters.AddWithValue("@Quantity", carPart.Quantity);
                conn.Open();

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool DeleteCarPart(int id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM CarParts WHERE Id = @Id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", id);
                conn.Open();

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public List<string> GetCarPartBrands()
        {
            List<string> carPartBrands = new List<string>();
            string query = "SELECT DISTINCT Model FROM CarParts";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    carPartBrands.Add(reader["Model"].ToString());
                }

                reader.Close();
            }

            return carPartBrands;
        }

        public List<string> GetCarPartNamesByModel(string model)
        {
            List<string> partNames = new List<string>();
            string query = "SELECT Name FROM CarParts WHERE Model = @Model";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Model", model);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    partNames.Add(reader["Name"].ToString());
                }

                reader.Close();
            }

            return partNames;
        }

        public CarPart GetCarPartByNameAndModel(string name, string model)
        {
            CarPart carPart = null;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT TOP 1 * FROM CarParts WHERE Name = @Name AND Model = @Model";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Model", model);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    carPart = new CarPart
                    {
                        Id = (int)reader["Id"],
                        Name = (string)reader["Name"],
                        Model = (string)reader["Model"],
                        UnitPrice = (decimal)reader["UnitPrice"],
                        Quantity = (int)reader["Quantity"]
                    };
                }

                reader.Close();
            }

            return carPart;
        }

    }
}
