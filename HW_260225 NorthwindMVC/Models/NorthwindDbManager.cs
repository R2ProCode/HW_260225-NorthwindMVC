using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace HW_260225_NorthwindMVC.Models
{
    public class NorthwindDbManager
    {
        private string _connectionString;

        public NorthwindDbManager(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<Order> GetOrders()
        {
            SqlConnection connection = new SqlConnection(_connectionString);
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM Orders";

            connection.Open();

            List<Order> orders = new List<Order>();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                orders.Add(new Order
                {
                    Id = (int)reader["OrderId"],
                    OrderDate = (DateTime)reader["OrderDate"],
                    ShipName = (string)reader["ShipName"],
                    ShipAddress = (string)reader["ShipAddress"],
                    ShipCountry = (string)reader["ShipCountry"]
                });
            }

            return orders;
        }

        public List<OrderDetail> GetOrderDetails()
        {
            SqlConnection connection = new SqlConnection(_connectionString);
            SqlCommand command = connection.CreateCommand();
            command.CommandText = @"SELECT * FROM [Order Details] od
                                    JOIN Orders o
                                    ON od.OrderID = o.OrderID
                                    WHERE DATEPART(YEAR, o.OrderDate) = '1997'
";

            connection.Open();

            List<OrderDetail> orderDetails = new List<OrderDetail>();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                orderDetails.Add(new OrderDetail
                {
                    OrderId = (int)reader["OrderID"],
                    ProductId = (int)reader["ProductID"],
                    UnitPrice = (decimal)reader["UnitPrice"],
                    Quantity = (short)reader["Quantity"],
                    OrderDate = (DateTime)reader["OrderDate"]
                });
            }

            return orderDetails;
        }
    }
}