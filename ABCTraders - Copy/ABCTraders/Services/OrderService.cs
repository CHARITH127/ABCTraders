using ABCTraders.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABCTraders.Services
{
    internal class OrderService
    {

        private string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=CarTraderDB;Integrated Security=True;Encrypt=False";

        public bool PlaceOrder(Order order, List<OrderDetail> orderDetails)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlTransaction transaction = null;
                try
                {
                    connection.Open();
                    transaction = connection.BeginTransaction();

                    string orderQuery = @"
                    INSERT INTO Orders (UserID, OrderDate, Status, Reason, TotalAmount)
                    VALUES (@UserID, @OrderDate, @Status, @Reason, @TotalAmount);
                    SELECT CAST(scope_identity() AS int);";

                    int orderId;
                    using (SqlCommand orderCmd = new SqlCommand(orderQuery, connection, transaction))
                    {
                        orderCmd.Parameters.AddWithValue("@UserID", order.UserID);
                        orderCmd.Parameters.AddWithValue("@OrderDate", order.OrderDate);
                        orderCmd.Parameters.AddWithValue("@Status", order.Status);
                        orderCmd.Parameters.AddWithValue("@Reason", order.Reason ?? (object)DBNull.Value);
                        orderCmd.Parameters.AddWithValue("@TotalAmount", order.TotalAmount);

                        orderId = (int)orderCmd.ExecuteScalar();
                    }

                    string orderDetailQuery = @"
                    INSERT INTO OrderDetails (OrderID, Quantity, Type, Brand, Model, Name, UnitPrice, TotalValue)
                    VALUES (@OrderID, @Quantity, @Type, @Brand, @Model, @Name, @UnitPrice, @TotalValue);";

                    foreach (OrderDetail detail in orderDetails)
                    {
                        using (SqlCommand orderDetailCmd = new SqlCommand(orderDetailQuery, connection, transaction))
                        {
                            orderDetailCmd.Parameters.AddWithValue("@OrderID", orderId);
                            orderDetailCmd.Parameters.AddWithValue("@Quantity", detail.Quantity);
                            orderDetailCmd.Parameters.AddWithValue("@Type", detail.Type);
                            orderDetailCmd.Parameters.AddWithValue("@Brand", detail.Brand ?? (object)DBNull.Value);
                            orderDetailCmd.Parameters.AddWithValue("@Model", detail.Model);
                            orderDetailCmd.Parameters.AddWithValue("@Name", detail.Name);
                            orderDetailCmd.Parameters.AddWithValue("@UnitPrice", detail.UnitPrice);
                            orderDetailCmd.Parameters.AddWithValue("@TotalValue", detail.TotalValue);

                            orderDetailCmd.ExecuteNonQuery();
                        }

                        DeductQuantity(detail, connection, transaction);
                    }

                    transaction.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    transaction?.Rollback();
                    throw new ApplicationException("An error occurred while placing the order.", ex);
                }
            }
        }

        public List<OrderOut> GetAllOrders()
        {
            List<OrderOut> orders = new List<OrderOut>();

            string query = "SELECT * FROM Orders";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        OrderOut order = new OrderOut
                        {
                            OrderID = (int)reader["OrderID"],
                            UserID = (int)reader["UserID"],
                            OrderDate = (DateTime)reader["OrderDate"],
                            Status = reader["Status"].ToString(),
                            Reason = reader["Reason"].ToString(),
                            TotalAmount = (decimal)reader["TotalAmount"],
                            OrderDetails = GetOrderDetails((int)reader["OrderID"])
                        };
                        orders.Add(order);
                    }
                }
            }

            return orders;
        }

        public List<OrderOut> GetAllOrdersByUSerID(int userID)
        {
            List<OrderOut> orders = new List<OrderOut>();

            string query = "SELECT * FROM Orders WHERE UserID = @UserID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@UserID", userID);
                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        OrderOut order = new OrderOut
                        {
                            OrderID = (int)reader["OrderID"],
                            UserID = (int)reader["UserID"],
                            OrderDate = (DateTime)reader["OrderDate"],
                            Status = reader["Status"].ToString(),
                            Reason = reader["Reason"].ToString(),
                            TotalAmount = (decimal)reader["TotalAmount"],
                            OrderDetails = GetOrderDetails((int)reader["OrderID"])
                        };
                        orders.Add(order);
                    }
                }
            }

            return orders;
        }

        public List<OrderDetailsOut> GetOrderDetails(int orderId)
        {
            List<OrderDetailsOut> orderDetails = new List<OrderDetailsOut>();

            string query = "SELECT * FROM OrderDetails WHERE OrderID = @OrderID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@OrderID", orderId);
                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        OrderDetailsOut detail = new OrderDetailsOut
                        {
                            OrderDetailID = (int)reader["OrderDetailID"],
                            OrderID = (int)reader["OrderID"],
                            Quantity = (int)reader["Quantity"],
                            Type = reader["Type"].ToString(),
                            Brand = reader["Brand"].ToString(),
                            Model = reader["Model"].ToString(),
                            Name = reader["Name"].ToString(),
                            UnitPrice = (decimal)reader["UnitPrice"],
                            TotalValue = (decimal)reader["TotalValue"]
                        };
                        orderDetails.Add(detail);
                    }
                }
            }

            return orderDetails;
        }

        public OrderOut GetOrderById(int orderId)
        {
            OrderOut order = null;

            string query = "SELECT * FROM Orders WHERE OrderID = @OrderID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@OrderID", orderId);
                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        order = new OrderOut
                        {
                            OrderID = (int)reader["OrderID"],
                            UserID = (int)reader["UserID"],
                            OrderDate = (DateTime)reader["OrderDate"],
                            Status = reader["Status"].ToString(),
                            Reason = reader["Reason"].ToString(),
                            TotalAmount = (decimal)reader["TotalAmount"],
                            OrderDetails = GetOrderDetails((int)reader["OrderID"])
                        };
                    }
                }
            }

            return order;
        }

        // Method to delete the order and its details
        public void DeleteOrder(int orderId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        // Retrieve the order details before deletion
                        string selectQuery = "SELECT Brand, Type, Name, Model, Quantity FROM OrderDetails WHERE OrderID = @OrderID";
                        List<(string Brand, string Type, string Name, string Model, int Qty)> items = new List<(string, string, string, string, int)>();

                        using (SqlCommand selectCommand = new SqlCommand(selectQuery, connection, transaction))
                        {
                            selectCommand.Parameters.AddWithValue("@OrderID", orderId);
                            using (SqlDataReader reader = selectCommand.ExecuteReader())
                            {
                                // add values from the selected
                                while (reader.Read())
                                {
                                    items.Add((reader["Brand"].ToString(), reader["Type"].ToString(), reader["Name"].ToString(), reader["Model"].ToString(), (int)reader["Quantity"]));
                                }
                            }
                        }

                        // Delete from OrderDetails
                        string deleteOrderDetailsQuery = "DELETE FROM OrderDetails WHERE OrderID = @OrderID";
                        using (SqlCommand command = new SqlCommand(deleteOrderDetailsQuery, connection, transaction))
                        {
                            command.Parameters.AddWithValue("@OrderID", orderId);
                            command.ExecuteNonQuery();
                        }

                        // Delete from Orders
                        string deleteOrderQuery = "DELETE FROM Orders WHERE OrderID = @OrderID";
                        using (SqlCommand command = new SqlCommand(deleteOrderQuery, connection, transaction))
                        {
                            command.Parameters.AddWithValue("@OrderID", orderId);
                            command.ExecuteNonQuery();
                        }

                        // Update Car table with the new quantity
                        foreach (var item in items)
                        {

                            if (item.Type == "Car")
                            {
                                string updateCarQuery = "UPDATE Cars SET Quantity = Quantity + @Qty WHERE BrandName = @BrandName AND Model = @Model";
                                using (SqlCommand command = new SqlCommand(updateCarQuery, connection, transaction))
                                {
                                    command.Parameters.AddWithValue("@Qty", item.Qty);
                                    command.Parameters.AddWithValue("@BrandName", item.Brand);
                                    command.Parameters.AddWithValue("@Model", item.Model);
                                    command.ExecuteNonQuery();
                                }
                            }
                            else if (item.Type == "CarPart")
                            {
                                string updateCarQuery = "UPDATE CarParts SET Quantity = Quantity + @Qty WHERE Name = @Name AND Model = @Model";
                                using (SqlCommand command = new SqlCommand(updateCarQuery, connection, transaction))
                                {
                                    command.Parameters.AddWithValue("@Qty", item.Qty);
                                    command.Parameters.AddWithValue("@Name", item.Name);
                                    command.Parameters.AddWithValue("@Model", item.Model);
                                    command.ExecuteNonQuery();
                                }
                            }

                        }

                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw new Exception("An error occurred while deleting the order: " + ex.Message);
                    }
                }
            }
        }

        public void DeleteOrderDetail(int orderId, int orderDetailId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        // Retrieve the order details before deletion
                        string selectQuery = "SELECT Brand, Type, Name, Model, Quantity FROM OrderDetails WHERE OrderID = @OrderID AND OrderDetailID = @OrderDetailID ";
                        List<(string Brand, string Type, string Name, string Model, int Qty)> items = new List<(string, string, string, string, int)>();

                        using (SqlCommand selectCommand = new SqlCommand(selectQuery, connection, transaction))
                        {
                            selectCommand.Parameters.AddWithValue("@OrderID", orderId);
                            selectCommand.Parameters.AddWithValue("@OrderDetailID", orderDetailId);
                            using (SqlDataReader reader = selectCommand.ExecuteReader())
                            {
                                // add values from the selected
                                while (reader.Read())
                                {
                                    items.Add((reader["Brand"].ToString(), reader["Type"].ToString(), reader["Name"].ToString(), reader["Model"].ToString(), (int)reader["Quantity"]));
                                }
                            }
                        }

                        // Delete from OrderDetails
                        string deleteOrderDetailsQuery = "DELETE FROM OrderDetails WHERE OrderID = @OrderID AND OrderDetailID = @OrderDetailID ";
                        using (SqlCommand command = new SqlCommand(deleteOrderDetailsQuery, connection, transaction))
                        {
                            command.Parameters.AddWithValue("@OrderID", orderId);
                            command.Parameters.AddWithValue("@OrderDetailID", orderDetailId);
                            command.ExecuteNonQuery();
                        }

                        // Update Car table with the new quantity
                        foreach (var item in items)
                        {

                            if (item.Type == "Car")
                            {
                                string updateCarQuery = "UPDATE Cars SET Quantity = Quantity + @Qty WHERE BrandName = @BrandName AND Model = @Model";
                                using (SqlCommand command = new SqlCommand(updateCarQuery, connection, transaction))
                                {
                                    command.Parameters.AddWithValue("@Qty", item.Qty);
                                    command.Parameters.AddWithValue("@BrandName", item.Brand);
                                    command.Parameters.AddWithValue("@Model", item.Model);
                                    command.ExecuteNonQuery();
                                }
                            }
                            else if (item.Type == "CarPart")
                            {
                                string updateCarQuery = "UPDATE CarParts SET Quantity = Quantity + @Qty WHERE Name = @Name AND Model = @Model";
                                using (SqlCommand command = new SqlCommand(updateCarQuery, connection, transaction))
                                {
                                    command.Parameters.AddWithValue("@Qty", item.Qty);
                                    command.Parameters.AddWithValue("@Name", item.Name);
                                    command.Parameters.AddWithValue("@Model", item.Model);
                                    command.ExecuteNonQuery();
                                }
                            }

                        }

                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw new Exception("An error occurred while deleting the order detail: " + ex.Message);
                    }
                }
            }
        }

        public string GetOrderStatusById(int orderId)
        {
            string status = null;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT Status FROM Orders WHERE OrderID = @OrderID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@OrderID", orderId);

                    connection.Open();
                    var result = command.ExecuteScalar();
                    if (result != null)
                    {
                        status = result.ToString();
                    }
                }
            }

            return status;
        }

        public void UpdateOrderStatus(OrderOut order)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE Orders SET Status = @Status, Reason = @Reason WHERE OrderID = @OrderID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Status", order.Status);
                command.Parameters.AddWithValue("@Reason", (object)order.Reason ?? DBNull.Value);
                command.Parameters.AddWithValue("@OrderID", order.OrderID);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public List<OrderOut> GetOrdersByDateRange(DateTime fromDate, DateTime toDate)
        {
            List<OrderOut> orders = new List<OrderOut>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"SELECT OrderID, UserID, OrderDate, Status, Reason, TotalAmount 
                         FROM Orders 
                         WHERE OrderDate BETWEEN @FromDate AND @ToDate";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@FromDate", fromDate);
                command.Parameters.AddWithValue("@ToDate", toDate);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    OrderOut order = new OrderOut
                    {
                        OrderID = reader.GetInt32(0),
                        UserID = reader.GetInt32(1),
                        OrderDate = reader.GetDateTime(2),
                        Status = reader.GetString(3),
                        Reason = reader.IsDBNull(4) ? null : reader.GetString(4),
                        TotalAmount = reader.GetDecimal(5)
                    };
                    orders.Add(order);
                }
            }

            return orders;
        }

        public int GetOrderCountByStatus(string status)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Orders WHERE Status = @Status", conn))
                {
                    cmd.Parameters.AddWithValue("@Status", status);
                    return (int)cmd.ExecuteScalar();
                }
            }
        }

        public decimal GetTotalAmountByStatus(string status)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT ISNULL(SUM(TotalAmount), 0) FROM Orders WHERE Status = @Status", conn))
                {
                    cmd.Parameters.AddWithValue("@Status", status);
                    return (decimal)cmd.ExecuteScalar();
                }
            }
        }


        private void DeductQuantity(OrderDetail detail, SqlConnection connection, SqlTransaction transaction)
        {
            string updateQuery = string.Empty;

            if (detail.Type == "Car")
            {
                updateQuery = "UPDATE Car SET Quantity = Quantity - @Quantity WHERE Brand = @Brand AND Model = @Model";
            }
            else if (detail.Type == "CarPart")
            {
                updateQuery = "UPDATE CarParts SET Quantity = Quantity - @Quantity WHERE Name = @Name AND Model = @Model";
            }

            if (!string.IsNullOrEmpty(updateQuery))
            {
                using (var command = new SqlCommand(updateQuery, connection, transaction))
                {
                    command.Parameters.AddWithValue("@Quantity", detail.Quantity);
                    if (detail.Brand != null)
                    {
                        command.Parameters.AddWithValue("@Brand", detail.Brand);
                    }

                    if (detail.Model != null)
                    {
                        command.Parameters.AddWithValue("@Model", detail.Model);
                    }

                    if (detail.Name != null)
                    {
                        command.Parameters.AddWithValue("@Name", detail.Name);
                    }
                    

                    command.ExecuteNonQuery();
                }
            }
        }

    }
}
