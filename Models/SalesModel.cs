using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;

namespace AventuraPAY.Models
{
    public class SalesModel
    {
        private string connectionString = @"Data Source=D:\Projects\AventuraPAY\DB\aventuraDB.db;Version=3;";

        public List<Tuple<string, string>> GetProducts()
        {
            List<Tuple<string, string>> products = new List<Tuple<string, string>>();
            string query = "SELECT produs, categoria FROM produse";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            products.Add(new Tuple<string, string>(
                                reader["produs"].ToString(),
                                reader["categoria"].ToString()
                            ));
                        }
                    }
                }
            }
            return products;
        }

        public double GetProductPrice(string productName)
        {
            double price = 0;
            string query = "SELECT pret FROM produse WHERE produs = @produs";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@produs", productName);
                    price = Convert.ToDouble(command.ExecuteScalar());
                }
            }

            return price;
        }

        public int SaveReceipt(string products, double totalAmount, string paymentMethod, string clientDetails, string username)
        {
            string connectionString = @"Data Source=D:\Projects\AventuraPAY\DB\aventuraDBnote.db;Version=3;Default Timeout=30000;";
            string query = @"
            INSERT INTO notedeplata (Data, Produse, Total, MetodaPlata, DetaliiClient, User) 
            VALUES (@Data, @Produse, @Total, @MetodaPlata, @DetaliiClient, @User);
            SELECT last_insert_rowid();";

            int receiptId = 0;
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteTransaction transaction = connection.BeginTransaction())
                {
                    using (SQLiteCommand command = new SQLiteCommand(query, connection, transaction))
                    {
                        command.Parameters.AddWithValue("@Data", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                        command.Parameters.AddWithValue("@Produse", products);
                        command.Parameters.AddWithValue("@Total", totalAmount);
                        command.Parameters.AddWithValue("@MetodaPlata", paymentMethod);
                        command.Parameters.AddWithValue("@DetaliiClient", clientDetails);
                        command.Parameters.AddWithValue("@User", username);

                        command.ExecuteNonQuery();
                        receiptId = Convert.ToInt32(command.ExecuteScalar());
                    }
                    transaction.Commit();
                }
            }
            return receiptId;
        }

        public string GetLastLoggedInUser()
        {
            string lastLoggedInUser = string.Empty;
            string query = "SELECT username FROM login_attempts ORDER BY login_time DESC LIMIT 1";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    lastLoggedInUser = (string)command.ExecuteScalar();
                }
            }

            return lastLoggedInUser;
        }
    }
}
