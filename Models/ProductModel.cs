using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;

namespace AventuraPAY.Models
{
    public class ProductModel
    {
        private string connectionString = @"Data Source=D:\Projects\AventuraPAY\DB\aventuraDB.db;Version=3;";

        public DataTable GetAllProducts()
        {
            DataTable dataTable = new DataTable();

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT produs, pret, categoria FROM produse";

                SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(query, connection);
                dataAdapter.Fill(dataTable);
            }

            return dataTable;
        }

        public List<string> GetProductNames()
        {
            List<string> productNames = new List<string>();

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT produs FROM produse";

                SQLiteCommand command = new SQLiteCommand(query, connection);
                SQLiteDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    productNames.Add(reader["produs"].ToString());
                }
            }

            return productNames;
        }

        public void AddProduct(string produs, string pret, string categorie)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO produse (produs, pret, categoria) VALUES (@produs, @pret, @categorie)";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@produs", produs);
                    command.Parameters.AddWithValue("@pret", pret);
                    command.Parameters.AddWithValue("@categorie", categorie);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void UpdateProduct(string produs, string newProdus, string pret, string categorie)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE produse SET produs = @newProdus, pret = @pret, categoria = @categorie WHERE produs = @produs";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@produs", produs);
                    command.Parameters.AddWithValue("@newProdus", newProdus);
                    command.Parameters.AddWithValue("@pret", pret);
                    command.Parameters.AddWithValue("@categorie", categorie);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void DeleteProduct(string produs)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = "DELETE FROM produse WHERE produs = @produs";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@produs", produs);
                    command.ExecuteNonQuery();
                }
            }
        }

        public DataRow GetProductDetails(string produs)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT produs, pret, categoria FROM produse WHERE produs = @produs";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@produs", produs);
                    using (SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);

                        if (dataTable.Rows.Count > 0)
                        {
                            return dataTable.Rows[0];
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
            }
        }
    }
}
