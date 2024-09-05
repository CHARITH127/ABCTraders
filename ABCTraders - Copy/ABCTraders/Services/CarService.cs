using ABCTraders.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace ABCTraders.Services
{
    internal class CarService
    {
        private string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=CarTraderDB;Integrated Security=True;Encrypt=False";

        public CarService() {
              
        }

        
        public List<Car> GetAllCars()
        {
            List<Car> carList = new List<Car>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Cars";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Car car = new Car
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        BrandName = reader["BrandName"].ToString(),
                        Model = reader["Model"].ToString(),
                        UnitPrice = Convert.ToDecimal(reader["UnitPrice"]),
                        Quantity = Convert.ToInt32(reader["Quantity"])
                    };
                    carList.Add(car);
                }
            }
            return carList;
        }

        public void AddCar(Car car)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Cars (BrandName, Model, UnitPrice, Quantity) VALUES (@BrandName, @Model, @UnitPrice, @Quantity)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@BrandName", car.BrandName);
                cmd.Parameters.AddWithValue("@Model", car.Model);
                cmd.Parameters.AddWithValue("@UnitPrice", car.UnitPrice);
                cmd.Parameters.AddWithValue("@Quantity", car.Quantity);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateCar(Car car)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "UPDATE Cars SET BrandName = @BrandName, Model = @Model, UnitPrice = @UnitPrice, Quantity = @Quantity WHERE Id = @Id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Id", car.Id);
                cmd.Parameters.AddWithValue("@BrandName", car.BrandName);
                cmd.Parameters.AddWithValue("@Model", car.Model);
                cmd.Parameters.AddWithValue("@UnitPrice", car.UnitPrice);
                cmd.Parameters.AddWithValue("@Quantity", car.Quantity);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteCar(int id)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Cars WHERE Id = @Id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Id", id);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public List<string> GetCarBrands()
        {
            List<string> carBrands = new List<string>();
            string query = "SELECT DISTINCT BrandName FROM Cars";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    carBrands.Add(reader["BrandName"].ToString());
                }

                reader.Close();
            }

            return carBrands;
        }

        public List<string> GetCarModelsByBrand(string brand)
        {
            List<string> carModels = new List<string>();
            string query = "SELECT Model FROM Cars WHERE BrandName = @BrandName";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@BrandName", brand);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    carModels.Add(reader["Model"].ToString());
                }

                reader.Close();
            }

            return carModels;
        }

        public Car GetCarByBrandAndModel(string brand, string model)
        {
            Car selectedCar = null;
            string query = "SELECT * FROM Cars WHERE BrandName = @BrandName AND Model = @Model";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@BrandName", brand);
                command.Parameters.AddWithValue("@Model", model);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    selectedCar = new Car
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        BrandName = reader["BrandName"].ToString(),
                        Model = reader["Model"].ToString(),
                        UnitPrice = Convert.ToDecimal(reader["UnitPrice"]),
                        Quantity = Convert.ToInt32(reader["Quantity"])
                    };
                }

                reader.Close();
            }

            return selectedCar;
        }


        public Car GetCarByModel(string model)
        {
            Car selectedCar = null;
            string query = "SELECT * FROM Cars WHERE Model = @Model";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Model", model);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    selectedCar = new Car
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        BrandName = reader["BrandName"].ToString(),
                        Model = reader["Model"].ToString(),
                        UnitPrice = Convert.ToDecimal(reader["UnitPrice"]),
                        Quantity = Convert.ToInt32(reader["Quantity"])
                    };
                }

                reader.Close();
            }

            return selectedCar;
        }




    }
}
