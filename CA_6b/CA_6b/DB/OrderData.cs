using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CA_6b.Models;
using System.Data.SqlClient;
using System.Diagnostics;

namespace CA_6b.DB
{
    public class OrderData : Data
    {
        public static void SaveOrder(Order order)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql1 = @"INSERT into Orders VALUES (@CustomerId, @OrderDate)";
                string sql2 = @"INSERT into OrderDetails VALUES (@OrderId, @ProductId,
                              @UnitPrice, @Quantity, @Discount)";
                string sql3 = @"INSERT into ActivationCodes VALUES(@OrderId, @ProductId, @ActCode)";
                //save CustomerId, OrderDate to the Order Table
                SqlCommand cmd1 = new SqlCommand(sql1, conn);
                cmd1.Parameters.AddWithValue("@CustomerId", order.CustomerId);
                cmd1.Parameters.AddWithValue("@OrderDate", order.OrderDate);
                cmd1.ExecuteNonQuery();

                int id = GetOrderId(order);

                SqlCommand cmd2 = new SqlCommand(sql2, conn);
                SqlCommand cmd3 = new SqlCommand(sql3, conn);
                for (int i = 0; i < order.OrderDetail.Products.Count(); i++)
                {
                    //save details to the OrderDetails table
                    cmd2.Parameters.AddWithValue("@OrderId", id);
                    cmd2.Parameters.AddWithValue("@ProductId", order.OrderDetail.Products[i].ProductId);
                    cmd2.Parameters.AddWithValue("@UnitPrice", order.OrderDetail.Products[i].Price);
                    cmd2.Parameters.AddWithValue("@Quantity", order.OrderDetail.Quantity[i]);
                    cmd2.Parameters.AddWithValue("@Discount", order.OrderDetail.Products[i].Discount);
                    cmd2.ExecuteNonQuery();
                    cmd2.Parameters.Clear();

                    for (int j = 0; j < order.OrderDetail.Quantity[i]; j++)
                    {
                        //save activation codes to the ActivationCodes table
                        cmd3.Parameters.AddWithValue("@OrderId", id);
                        cmd3.Parameters.AddWithValue("@ProductId", order.OrderDetail.Products[i].ProductId);
                        cmd3.Parameters.AddWithValue("@ActCode", order.OrderDetail.CodeLists[i].ActCode[j]);
                        cmd3.ExecuteNonQuery();
                        cmd3.Parameters.Clear();
                    }
                }
            }
        }

        public static int GetOrderId(Order order)
        {
            int id = 0;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = @"SELECT OrderId from Orders 
                                WHERE CustomerId = @CustomerId AND OrderDate = @OrderDate";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@CustomerId", order.CustomerId);
                cmd.Parameters.AddWithValue("@OrderDate", order.OrderDate);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    id = (int)reader["OrderId"];
                }
            }
            return id;
        }

        public static List<OrderItem> GetOrder(int orderId)
        {
            List<OrderItem> orderList = new List<OrderItem>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string sql1 = @"SELECT o.OrderDate, p.ProductId, p.ProductName, od.Quantity, od.UnitPrice, 
                               od.Discount, i.ImageUrl from Orders o, OrderDetails od, Products p, Images i
                               where o.OrderId = od.OrderId and od.ProductId = p.ProductId and p.ProductId = i.ProductId
                               group by o.OrderId, o.OrderDate, p.ProductName, p.ProductId, od.Quantity, 
                               od.UnitPrice, od.Discount, i.ImageUrl
                               having o.OrderId =" + orderId;
                Debug.WriteLine(orderId);


                string sql2 = @"select ac.ActCode
                                from ActivationCodes ac, OrderDetails od
                                where ac.OrderId = od.OrderId and ac.ProductId = od.ProductId
                                group by ac.ProductId, ac.ActCode, ac.OrderId
                                having ac.OrderId = @orderId and ac.ProductId = @productId";
                SqlCommand cmd1 = new SqlCommand(sql1, conn);
                SqlCommand cmd2 = new SqlCommand(sql2, conn);
                SqlDataReader reader1 = cmd1.ExecuteReader();


                while (reader1.Read())
                {
                    cmd2.Parameters.AddWithValue("@orderId", orderId);
                    cmd2.Parameters.AddWithValue("@productId", (int)reader1["ProductId"]);
                    List<string> listCode = new List<string>();
                    SqlDataReader reader2 = cmd2.ExecuteReader();
                    while (reader2.Read())
                    {
                        listCode.Add((string)reader2["ActCode"]);
                    }
                    OrderItem orderItem = new OrderItem()
                    {
                        ItemId = (int)reader1["ProductId"],
                        ItemOrderDate = (DateTime)reader1["OrderDate"],
                        ItemName = (string)reader1["ProductName"],
                        ItemQuantity = (int)reader1["Quantity"],
                        ItemPrice = ((Math.Ceiling((double)reader1["UnitPrice"] * (100 - (double)reader1["Discount"]) / 100) * 100) - 1) / 100,
                        ItemDiscount = (double)reader1["Discount"],
                        ItemUrl = (string)reader1["ImageUrl"],
                        ItemCodeLists = listCode
                    };
                    orderList.Add(orderItem);
                    cmd2.Parameters.Clear();
                    reader2.Close();
                }

            }
            return orderList;
        }


        public static List<Order> GetOrderHistory(int customerId)
        {
            List<Order> orderHistory = new List<Order>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = @"select OrderId, OrderDate from Orders where CustomerId = @customerId";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@customerId", customerId);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Order order = new Order()
                    {
                        OrderId = (int)reader["OrderId"],
                        OrderDate = (DateTime)reader["OrderDate"]
                    };
                    orderHistory.Add(order);
                }
            }
            return orderHistory;
        }
    }
}