using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CA_6b.Models;
using System.Data.SqlClient;
using System.Web.Mvc;
using System.Security.Cryptography;

namespace CA_6b.DB
{
    public class CustomerData:Data
    {
        public static Customer GetCustomer(string Username)
        {
            Customer customer = new Customer();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string sql = @"SELECT CustomerId, FirstName, LastName FROM Customers WHERE Username=@Username";

                SqlParameter param1 = new SqlParameter();
                param1.ParameterName = "@Username";
                param1.Value = Username;
      
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add(param1);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    customer.CustomerId = (int)reader["CustomerId"];
                    customer.FirstName = (string)reader["FirstName"];
                    customer.LastName = (string)reader["LastName"];
                }
                return customer;

            }
        }


        public static string GetPassword(string username)
        {
            using(SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = @"SELECT Password from Customers where Username = @username";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@username", username);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string password = (string)reader["Password"];
                    return password;
                }
                return null;
            }
        }


        private const int NUM_ITERATIONS = 1000;
        public static bool IsPasswordValid(string password, string saltHash)
        {
            //after user sends username and plain-text password to the server, server will
            //check and get the salt of that user:

            //1.saltHash is the password saved in database and is retrieved by using function
            //GetPassword(string username). After that, password will be splited to salt and hash
            string[] parts = saltHash.Split(new[] { ':' }, StringSplitOptions.RemoveEmptyEntries);

            if (parts.Length != 2) return false;

            //2. Hash the plain-text password sent by user in the server side, using the stored salt 
            //from database
            byte[] buf = Convert.FromBase64String(parts[0]);
            Rfc2898DeriveBytes deriver2898 = new Rfc2898DeriveBytes(password.Trim(), buf, NUM_ITERATIONS);
            string computedHash = Convert.ToBase64String(deriver2898.GetBytes(16));

            //3. Compare the result of step 2 with the hash in the database
            return parts[1].Equals(computedHash);
        }
    }
}