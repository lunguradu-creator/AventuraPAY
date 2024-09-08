using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;

namespace AventuraPAY.Models
{
    public class ReceiptModel
    {
        private string connectionString = @"Data Source=D:\Projects\AventuraPAY\DB\aventuraDBnote.db;Version=3;";

        public DataTable GetReceiptsForToday()
        {
            string query = "SELECT * FROM notedeplata WHERE DATE(Data) = DATE('now') ORDER BY id DESC";
            DataTable receiptsTable = new DataTable();

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(query, connection);
                    dataAdapter.Fill(receiptsTable);
                }
                catch (Exception ex)
                {
                    throw new Exception($"A apărut o eroare la obținerea bonurilor: {ex.Message}");
                }
            }

            return receiptsTable;
        }

        // Metodă pentru obținerea bonurilor după criterii de căutare
        public List<Receipt> GetReceipts(string searchQuery = "", DateTime? filterDate = null)
        {
            List<Receipt> receipts = new List<Receipt>();

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT id, Data, Produse, Total, MetodaPlata, DetaliiClient FROM notedeplata";

                if (!string.IsNullOrWhiteSpace(searchQuery) || filterDate.HasValue)
                {
                    query += " WHERE";
                    if (!string.IsNullOrWhiteSpace(searchQuery))
                    {
                        query += " id LIKE @SearchQuery";
                        if (filterDate.HasValue)
                        {
                            query += " AND";
                        }
                    }
                    if (filterDate.HasValue)
                    {
                        query += " DATE(Data) = DATE(@FilterDate)";
                    }
                }

                query += " ORDER BY Data DESC";

                SQLiteCommand command = new SQLiteCommand(query, connection);
                if (!string.IsNullOrWhiteSpace(searchQuery))
                {
                    command.Parameters.AddWithValue("@SearchQuery", "%" + searchQuery + "%");
                }
                if (filterDate.HasValue)
                {
                    command.Parameters.AddWithValue("@FilterDate", filterDate.Value.Date);
                }

                SQLiteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    receipts.Add(new Receipt
                    {
                        Id = Convert.ToInt32(reader["id"]),
                        Data = reader["Data"].ToString(),
                        Produse = reader["Produse"].ToString(),
                        Total = Convert.ToDouble(reader["Total"]),
                        MetodaPlata = reader["MetodaPlata"].ToString(),
                        DetaliiClient = reader["DetaliiClient"].ToString()
                    });
                }
            }

            return receipts;
        }

        // Metodă pentru actualizarea unui bon
        public void UpdateReceipt(Receipt receipt)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE notedeplata SET Data = @Data, Produse = @Produse, Total = @Total, MetodaPlata = @MetodaPlata, DetaliiClient = @DetaliiClient WHERE id = @id";
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@Data", receipt.Data);
                command.Parameters.AddWithValue("@Produse", receipt.Produse);
                command.Parameters.AddWithValue("@Total", receipt.Total);
                command.Parameters.AddWithValue("@MetodaPlata", receipt.MetodaPlata);
                command.Parameters.AddWithValue("@DetaliiClient", receipt.DetaliiClient);
                command.Parameters.AddWithValue("@id", receipt.Id);
                command.ExecuteNonQuery();
            }
        }

        // Metodă pentru ștergerea unui bon
        public void DeleteReceipt(int receiptId)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = "DELETE FROM notedeplata WHERE id = @id";
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@id", receiptId);
                command.ExecuteNonQuery();
            }
        }
    }

    // Clasa Receipt care reprezintă un bon de plată
    public class Receipt
    {
        public int Id { get; set; }
        public string Data { get; set; }
        public string Produse { get; set; }
        public double Total { get; set; }
        public string MetodaPlata { get; set; }
        public string DetaliiClient { get; set; }

        public override string ToString()
        {
            return $"ID: {Id}, Data: {Data}, Total: {Total}";
        }
    }
}
