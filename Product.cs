﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Seller
{
    class Product
    {
        public int SellerId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ImagePath { get; set; }

        private static string connectionString = "server=localhost;user=root;password=;database=marketplace;";


        public void Save_btn()
        {
            string query = "INSERT INTO products (seller_id, name, description, price, image_path) " +
                           "VALUES (@sid, @n, @d, @p, @img)";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@sid", SellerId);
                        cmd.Parameters.AddWithValue("@n", Name);
                        cmd.Parameters.AddWithValue("@d", Description);
                        cmd.Parameters.AddWithValue("@p", Price);
                        cmd.Parameters.AddWithValue("@img", ImagePath);

                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        public static List<Product> LoadProducts()
        {

            List<Product> products = new List<Product>();
            string query = "SELECT name, description, price, image_path FROM products";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        products.Add(new Product
                        {
                            Name = reader.GetString("name"),
                            Description = reader.GetString("description"),
                            Price = reader.GetDecimal("price"),
                            ImagePath = reader.GetString("image_path")
                        });
                    }
                }
            }

            return products;
        }
    }
}

