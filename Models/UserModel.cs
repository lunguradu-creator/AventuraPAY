using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Security.Cryptography;
using System.Text;

namespace AventuraPAY.Models
{
    public class UserModel
    {
        private string connectionString = @"Data Source=D:\Projects\AventuraPAY\DB\aventuraDB.db;Version=3;";

        public void RecordLoginAttempt(string username)
        {
            string query = "INSERT INTO login_attempts (username, login_time) VALUES (@username, @login_time)";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@login_time", DateTime.Now);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public bool CheckCredentials(string username, string password)
        {
            string query = "SELECT password FROM login WHERE username = @username";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@username", username);

                connection.Open();
                string storedPasswordHash = (string)command.ExecuteScalar();

                if (storedPasswordHash != null)
                {
                    string enteredPasswordHash = HashPassword(password);
                    return storedPasswordHash == enteredPasswordHash;
                }
                else
                {
                    return false;
                }
            }
        }

        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; ++i)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        // Metodă pentru a obține toți utilizatorii
        public DataTable GetAllUsers()
        {
            DataTable dataTable = new DataTable();

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT username, password FROM login";

                SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(query, connection);
                dataAdapter.Fill(dataTable);
            }

            return dataTable;
        }

        // Metodă pentru a adăuga un utilizator nou
        public void AddUser(string username, string password)
        {
            string hashedPassword = HashPassword(password);

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO login (username, password) VALUES (@username, @password)";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", hashedPassword);
                    command.ExecuteNonQuery();
                }
            }
        }

        // Metodă pentru a șterge un utilizator
        public void DeleteUser(string username)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = "DELETE FROM login WHERE username = @username";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    command.ExecuteNonQuery();
                }
            }
        }

        // Metodă pentru a obține lista de nume de utilizatori
        public List<string> GetUsernames()
        {
            List<string> usernames = new List<string>();

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT username FROM login";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        usernames.Add(reader["username"].ToString());
                    }
                }
            }

            return usernames;
        }
    }
}
