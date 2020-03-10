using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CA_6b.Models;
using System.Data.SqlClient;

namespace CA_6b.DB
{
    public class ProductData : Data
    {
        public static List<Product> GetAllProducts()
        {
            List<Product> products = new List<Product>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {

                conn.Open();

                string sql = @"  SELECT p.ProductId, p.ProductName, p.Description,
                               p.Platform, p.Price, p.Discount, p.NumOfSales, i.ImageUrl
                               FROM Products p, Images i WHERE p.ProductId=i.ProductId";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Product product = new Product()
                    {
                        ProductId = (int)reader["ProductId"],
                        ProductName = (string)reader["ProductName"],
                        Description = (string)reader["Description"],
                        Platform = (string)reader["Platform"],
                        Price = (double)reader["Price"],
                        Discount = (double)reader["Discount"],
                        ImageUrl = (string)reader["ImageUrl"],
                        NumOfSales = (int)reader["NumOfSales"]
                    };
                    products.Add(product);
                }
            }

            return products;
        }

        public static Product GetProductById(int productId)
        {
            Product product = null;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string sql = @"SELECT p.ProductId, p.ProductName, p.Description, p.Genre, p.Developer, p.Publisher, p.Platform, p.OperatingSystem,
                            p.Price, p.Discount, i.ImageUrl
                            FROM Products p, Images i where p.ProductId = i.ProductId
							group by p.ProductId, p.ProductName, p.Description, p.Genre, p.Developer, p.Publisher, p.Platform, p.OperatingSystem,
                            p.Price, p.Discount, i.ImageUrl
                            having p.ProductId = " + productId;

                SqlCommand cmd = new SqlCommand(sql, conn);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    product = new Product()
                    {
                        ProductId = (int)reader["ProductId"],
                        ProductName = (string)reader["ProductName"],
                        Description = (string)reader["Description"],
                        Genre = (string)reader["Genre"],
                        Developer = (string)reader["Developer"],
                        Publisher = (string)reader["Publisher"],
                        Platform = (string)reader["Platform"],
                        OperatingSystem = (string)reader["OperatingSystem"],
                        Price = (double)reader["Price"],
                        Discount = (double)reader["Discount"],
                        ImageUrl = (string)reader["ImageUrl"],

                    };
                };
            }

            return product;
        }

        public static Product find(int productId)
        {
            List<Product> products = GetAllProducts();
            return products.Single(p => p.ProductId.Equals(productId));
        }
    }
}