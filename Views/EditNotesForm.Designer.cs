using System;
using System.Data.SQLite;
using System.Drawing;
using System.Windows.Forms;

namespace AventuraPAY
{
    public partial class EditNotesForm : Form
    {
        private TextBox searchTextBox;
        private Button searchNumberButton;
        private Button searchDateButton;
        private ListBox receiptsListBox;
        private TextBox detailsTextBox;
        private Button saveButton;
        private Button deleteButton;
        private Button backButton;
        private DateTimePicker dateFilterPicker;
        private Form previousForm;

        public EditNotesForm(Form previousForm)
        {
            InitializeComponent();
            LoadReceipts();
            this.previousForm = previousForm;
            this.WindowState = FormWindowState.Maximized; // deschide fereastra in fullscreen
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditNotesForm));
            searchTextBox = new TextBox();
            searchNumberButton = new Button();
            searchDateButton = new Button();
            receiptsListBox = new ListBox();
            detailsTextBox = new TextBox();
            saveButton = new Button();
            deleteButton = new Button();
            backButton = new Button();
            dateFilterPicker = new DateTimePicker();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            buttonLogout = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // searchTextBox
            // 
            searchTextBox.Anchor = AnchorStyles.Top;
            searchTextBox.Font = new Font("Arial", 14F);
            searchTextBox.Location = new Point(587, 135);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(300, 45);
            searchTextBox.TabIndex = 0;
            // 
            // searchNumberButton
            // 
            searchNumberButton.Anchor = AnchorStyles.Top;
            searchNumberButton.Font = new Font("Arial", 14F, FontStyle.Bold);
            searchNumberButton.Location = new Point(907, 133);
            searchNumberButton.Name = "searchNumberButton";
            searchNumberButton.Size = new Size(204, 47);
            searchNumberButton.TabIndex = 1;
            searchNumberButton.Text = "Caută Nr.";
            searchNumberButton.UseVisualStyleBackColor = true;
            searchNumberButton.Click += searchNumberButton_Click;
            // 
            // searchDateButton
            // 
            searchDateButton.Anchor = AnchorStyles.Top;
            searchDateButton.Font = new Font("Arial", 14F, FontStyle.Bold);
            searchDateButton.Location = new Point(907, 264);
            searchDateButton.Name = "searchDateButton";
            searchDateButton.Size = new Size(204, 45);
            searchDateButton.TabIndex = 8;
            searchDateButton.Text = "Caută Dată";
            searchDateButton.UseVisualStyleBackColor = true;
            searchDateButton.Click += searchDateButton_Click;
            // 
            // receiptsListBox
            // 
            receiptsListBox.Anchor = AnchorStyles.Top;
            receiptsListBox.Font = new Font("Arial", 12F);
            receiptsListBox.FormattingEnabled = true;
            receiptsListBox.ItemHeight = 32;
            receiptsListBox.Location = new Point(587, 332);
            receiptsListBox.Name = "receiptsListBox";
            receiptsListBox.Size = new Size(650, 740);
            receiptsListBox.TabIndex = 2;
            receiptsListBox.SelectedIndexChanged += receiptsListBox_SelectedIndexChanged;
            // 
            // detailsTextBox
            // 
            detailsTextBox.Anchor = AnchorStyles.Top;
            detailsTextBox.Font = new Font("Arial", 12F);
            detailsTextBox.Location = new Point(1284, 332);
            detailsTextBox.Multiline = true;
            detailsTextBox.Name = "detailsTextBox";
            detailsTextBox.Size = new Size(650, 740);
            detailsTextBox.TabIndex = 3;
            // 
            // saveButton
            // 
            saveButton.Anchor = AnchorStyles.Top;
            saveButton.Font = new Font("Arial", 14F);
            saveButton.Location = new Point(1284, 1102);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(330, 50);
            saveButton.TabIndex = 4;
            saveButton.Text = "Salvează";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Anchor = AnchorStyles.Top;
            deleteButton.Font = new Font("Arial", 14F);
            deleteButton.Location = new Point(1640, 1102);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(294, 50);
            deleteButton.TabIndex = 5;
            deleteButton.Text = "Șterge";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // backButton
            // 
            backButton.Font = new Font("Arial", 14F, FontStyle.Bold);
            backButton.ForeColor = Color.FromArgb(0, 64, 0);
            backButton.Location = new Point(45, 981);
            backButton.Margin = new Padding(4);
            backButton.Name = "backButton";
            backButton.Size = new Size(429, 91);
            backButton.TabIndex = 6;
            backButton.Text = "Revino la pagina Vanzari";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // dateFilterPicker
            // 
            dateFilterPicker.Anchor = AnchorStyles.Top;
            dateFilterPicker.Font = new Font("Arial", 14F);
            dateFilterPicker.Format = DateTimePickerFormat.Short;
            dateFilterPicker.Location = new Point(587, 264);
            dateFilterPicker.Name = "dateFilterPicker";
            dateFilterPicker.Size = new Size(300, 45);
            dateFilterPicker.TabIndex = 7;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(92, 21);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(320, 305);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 14F, FontStyle.Bold);
            label1.Location = new Point(587, 85);
            label1.Name = "label1";
            label1.Size = new Size(373, 38);
            label1.TabIndex = 10;
            label1.Text = "Caută bon după număr";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 14F, FontStyle.Bold);
            label2.Location = new Point(587, 215);
            label2.Name = "label2";
            label2.Size = new Size(340, 38);
            label2.TabIndex = 11;
            label2.Text = "Caută bon după dată";
            // 
            // buttonLogout
            // 
            buttonLogout.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonLogout.BackColor = Color.FromArgb(0, 64, 0);
            buttonLogout.Font = new Font("Arial", 14F, FontStyle.Bold);
            buttonLogout.ForeColor = Color.White;
            buttonLogout.Location = new Point(45, 1114);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Size = new Size(429, 69);
            buttonLogout.TabIndex = 12;
            buttonLogout.Text = "LOGOUT";
            buttonLogout.UseVisualStyleBackColor = false;
            buttonLogout.Click += buttonLogout_Click;
            // 
            // EditNotesForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2083, 1289);
            Controls.Add(buttonLogout);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(backButton);
            Controls.Add(searchDateButton);
            Controls.Add(dateFilterPicker);
            Controls.Add(deleteButton);
            Controls.Add(saveButton);
            Controls.Add(detailsTextBox);
            Controls.Add(receiptsListBox);
            Controls.Add(searchNumberButton);
            Controls.Add(searchTextBox);
            Name = "EditNotesForm";
            Text = "Editare Note de Plata";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void LoadReceipts(string searchQuery = "", DateTime? filterDate = null)
        {
            using (SQLiteConnection connection = new SQLiteConnection(@"Data Source=D:\Projects\AventuraPAY\DB\aventuraDBnote.db;Version=3;"))
            {
                try
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

                    receiptsListBox.Items.Clear();
                    while (reader.Read())
                    {
                        receiptsListBox.Items.Add(new Receipt
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
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }

        private void searchNumberButton_Click(object sender, EventArgs e)
        {
            LoadReceipts(searchTextBox.Text, null);
        }

        private void searchDateButton_Click(object sender, EventArgs e)
        {
            LoadReceipts(null, dateFilterPicker.Value);
        }

        private void receiptsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (receiptsListBox.SelectedItem != null)
            {
                var receipt = (Receipt)receiptsListBox.SelectedItem;
                detailsTextBox.Text = $"Data: {receipt.Data}\r\nProduse: {receipt.Produse}\r\nTotal: {receipt.Total}\r\nMetodaPlata: {receipt.MetodaPlata}\r\nDetaliiClient: {receipt.DetaliiClient}";
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (receiptsListBox.SelectedItem != null)
            {
                var receipt = (Receipt)receiptsListBox.SelectedItem;
                string[] details = detailsTextBox.Text.Split(new[] { "\r\n" }, StringSplitOptions.None);
                receipt.Data = details[0].Split(new[] { "Data: " }, StringSplitOptions.None)[1];
                receipt.Produse = details[1].Split(new[] { "Produse: " }, StringSplitOptions.None)[1];
                receipt.Total = Convert.ToDouble(details[2].Split(new[] { "Total: " }, StringSplitOptions.None)[1]);
                receipt.MetodaPlata = details[3].Split(new[] { "MetodaPlata: " }, StringSplitOptions.None)[1];
                receipt.DetaliiClient = details[4].Split(new[] { "DetaliiClient: " }, StringSplitOptions.None)[1];

                using (SQLiteConnection connection = new SQLiteConnection(@"Data Source=D:\Projects\AventuraPAY\DB\aventuraDBnote.db;Version=3;"))
                {
                    try
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

                        MessageBox.Show("Receipt updated successfully.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred: {ex.Message}");
                    }
                }
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (receiptsListBox.SelectedItem != null)
            {
                var receipt = (Receipt)receiptsListBox.SelectedItem;

                using (SQLiteConnection connection = new SQLiteConnection(@"Data Source=D:\Projects\AventuraPAY\DB\aventuraDBnote.db;Version=3;"))
                {
                    try
                    {
                        connection.Open();
                        string query = "DELETE FROM notedeplata WHERE id = @id";
                        SQLiteCommand command = new SQLiteCommand(query, connection);
                        command.Parameters.AddWithValue("@id", receipt.Id);
                        command.ExecuteNonQuery();

                        receiptsListBox.Items.Remove(receipt);
                        detailsTextBox.Clear();

                        MessageBox.Show("Receipt deleted successfully.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred: {ex.Message}");
                    }
                }
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            var vanzariForm = new Sales();
            vanzariForm.WindowState = FormWindowState.Maximized;
            vanzariForm.Show();
            this.Close();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            var aventuraPayForm = new AventuraPAY.AventuraPAYForm();
            aventuraPayForm.WindowState = FormWindowState.Maximized;
            aventuraPayForm.Show();
            this.Close();
        }

        private class Receipt
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

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
        private Label label2;
        private Button buttonLogout;
    }
}
