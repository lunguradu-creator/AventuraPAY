using System;
using System.Data.SQLite;
using System.Collections.Generic;

namespace AventuraPAY.Models
{
    public class StatisticsModel
    {
        private string connectionString = @"Data Source=D:\Projects\AventuraPAY\DB\aventuraDBnote.db;Version=3;";

        public decimal GetTotalIncasari(string query)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand(query, connection);
                object result = command.ExecuteScalar();
                return result != DBNull.Value ? Convert.ToDecimal(result) : 0;
            }
        }

        public decimal GetPercentageChange(string queryToday, string queryYesterday)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                SQLiteCommand commandToday = new SQLiteCommand(queryToday, connection);
                SQLiteCommand commandYesterday = new SQLiteCommand(queryYesterday, connection);

                decimal totalIncasariToday = Convert.ToDecimal(commandToday.ExecuteScalar() ?? 0);
                decimal totalIncasariYesterday = Convert.ToDecimal(commandYesterday.ExecuteScalar() ?? 0);

                if (totalIncasariYesterday != 0)
                {
                    return ((totalIncasariToday - totalIncasariYesterday) / totalIncasariYesterday) * 100;
                }

                return 0;
            }
        }

        // Metodă pentru obținerea statisticilor filtrate pe utilizator și interval de timp
        public (decimal cardTotal, decimal cashTotal, decimal protocolTotal, decimal totalIncasari) GetStatistics(DateTime startDate, DateTime endDate, string user)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT " +
                    "SUM(CASE WHEN MetodaPlata = 'Card' THEN Total ELSE 0 END) AS CardTotal, " +
                    "SUM(CASE WHEN MetodaPlata = 'Cash' THEN Total ELSE 0 END) AS CashTotal, " +
                    "SUM(CASE WHEN MetodaPlata = 'Protocol' THEN Total ELSE 0 END) AS ProtocolTotal, " +
                    "SUM(Total) AS TotalIncasari " +
                    "FROM notedeplata " +
                    "WHERE Data BETWEEN @startDate AND @endDate";

                if (!string.IsNullOrEmpty(user))
                {
                    query += " AND User = @user";
                }

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@startDate", startDate);
                    command.Parameters.AddWithValue("@endDate", endDate);
                    if (!string.IsNullOrEmpty(user))
                    {
                        command.Parameters.AddWithValue("@user", user);
                    }

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            decimal cardTotal = reader["CardTotal"] != DBNull.Value ? Convert.ToDecimal(reader["CardTotal"]) : 0;
                            decimal cashTotal = reader["CashTotal"] != DBNull.Value ? Convert.ToDecimal(reader["CashTotal"]) : 0;
                            decimal protocolTotal = reader["ProtocolTotal"] != DBNull.Value ? Convert.ToDecimal(reader["ProtocolTotal"]) : 0;
                            decimal totalIncasari = reader["TotalIncasari"] != DBNull.Value ? Convert.ToDecimal(reader["TotalIncasari"]) : 0;

                            return (cardTotal, cashTotal, protocolTotal, totalIncasari);
                        }
                    }
                }
            }

            return (0, 0, 0, 0);
        }

        // Metodă pentru obținerea utilizatorilor unici din baza de date
        public string[] GetUsers()
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT DISTINCT User FROM notedeplata";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    var users = new List<string>();
                    while (reader.Read())
                    {
                        users.Add(reader["User"].ToString());
                    }
                    return users.ToArray();
                }
            }
        }
    }
}
