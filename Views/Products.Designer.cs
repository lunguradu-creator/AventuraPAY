using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SQLite;

namespace AventuraPAY
{
    partial class Products : Form
    {
        private System.ComponentModel.IContainer components = null;
        private SplitContainer splitContainer1;
        private Button button1;
        private Button addButton;
        private Button deleteButton;
        private Button updateButton;
        private TextBox produsTextBox;
        private TextBox pretTextBox;
        private Label label1;
        private Label produsLabel;
        private Label pretLabel;
        private ComboBox produseComboBox;
        private Label deleteLabel;
        private Label addLabel;
        private ComboBox categorieComboBox;
        private Label categorieLabel;
        private Panel produsePanel;
        private Button buttonLogout;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Products));
            splitContainer1 = new SplitContainer();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            buttonLogout = new Button();
            label2 = new Label();
            deleteLabel = new Label();
            addLabel = new Label();
            deleteButton = new Button();
            produseComboBox = new ComboBox();
            addButton = new Button();
            updateButton = new Button();
            pretLabel = new Label();
            pretTextBox = new TextBox();
            produsTextBox = new TextBox();
            produsLabel = new Label();
            categorieLabel = new Label();
            categorieComboBox = new ComboBox();
            label1 = new Label();
            produsePanel = new Panel();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();

            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";

            splitContainer1.Panel1.Controls.Add(pictureBox1);
            splitContainer1.Panel1.Controls.Add(button1);
            splitContainer1.Panel1.Controls.Add(buttonLogout);

            splitContainer1.Panel2.Controls.Add(label2);
            splitContainer1.Panel2.Controls.Add(deleteLabel);
            splitContainer1.Panel2.Controls.Add(addLabel);
            splitContainer1.Panel2.Controls.Add(deleteButton);
            splitContainer1.Panel2.Controls.Add(produseComboBox);
            splitContainer1.Panel2.Controls.Add(addButton);
            splitContainer1.Panel2.Controls.Add(updateButton);
            splitContainer1.Panel2.Controls.Add(pretLabel);
            splitContainer1.Panel2.Controls.Add(pretTextBox);
            splitContainer1.Panel2.Controls.Add(produsTextBox);
            splitContainer1.Panel2.Controls.Add(produsLabel);
            splitContainer1.Panel2.Controls.Add(categorieLabel);
            splitContainer1.Panel2.Controls.Add(categorieComboBox);
            splitContainer1.Panel2.Controls.Add(label1);
            splitContainer1.Panel2.Controls.Add(produsePanel);
            splitContainer1.Size = new Size(2640, 1511);
            splitContainer1.SplitterDistance = 451;
            splitContainer1.TabIndex = 0;

            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(79, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(320, 305);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;

            button1.Font = new Font("Arial", 14F, FontStyle.Bold);
            button1.ForeColor = Color.FromArgb(0, 64, 0);
            button1.Location = new Point(26, 1284);
            button1.Name = "button1";
            button1.Size = new Size(362, 92);
            button1.TabIndex = 1;
            button1.Text = "Revino la Pagina ADMIN";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;

            buttonLogout.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonLogout.BackColor = Color.FromArgb(0, 64, 0);
            buttonLogout.Font = new Font("Arial", 14F, FontStyle.Bold);
            buttonLogout.ForeColor = Color.White;
            buttonLogout.Location = new Point(26, 1415);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Size = new Size(362, 69);
            buttonLogout.TabIndex = 9;
            buttonLogout.Text = "LOGOUT";
            buttonLogout.UseVisualStyleBackColor = false;
            buttonLogout.Click += buttonLogout_Click;

            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 14F, FontStyle.Bold);
            label2.Location = new Point(1209, 696);
            label2.Name = "label2";
            label2.Size = new Size(266, 38);
            label2.TabIndex = 14;
            label2.Text = "Alege Produsul:";

            deleteLabel.Anchor = AnchorStyles.Top;
            deleteLabel.AutoSize = true;
            deleteLabel.Font = new Font("Arial", 14F, FontStyle.Bold);
            deleteLabel.ForeColor = Color.DarkGreen;
            deleteLabel.Location = new Point(1200, 648);
            deleteLabel.Name = "deleteLabel";
            deleteLabel.Size = new Size(328, 38);
            deleteLabel.TabIndex = 9;
            deleteLabel.Text = "EDITEAZA PRODUS";

            addLabel.Anchor = AnchorStyles.Top;
            addLabel.AutoSize = true;
            addLabel.Font = new Font("Arial", 14F, FontStyle.Bold);
            addLabel.ForeColor = Color.DarkGreen;
            addLabel.Location = new Point(458, 648);
            addLabel.Name = "addLabel";
            addLabel.Size = new Size(305, 38);
            addLabel.TabIndex = 10;
            addLabel.Text = "ADAUGĂ PRODUS";

            deleteButton.Anchor = AnchorStyles.Top;
            deleteButton.Font = new Font("Arial", 14F, FontStyle.Bold);
            deleteButton.ForeColor = Color.FromArgb(0, 64, 0);
            deleteButton.Location = new Point(1209, 886);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(449, 69);
            deleteButton.TabIndex = 3;
            deleteButton.Text = "Șterge";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;

            produseComboBox.Anchor = AnchorStyles.Top;
            produseComboBox.Font = new Font("Arial", 14F, FontStyle.Bold);
            produseComboBox.FormattingEnabled = true;
            produseComboBox.Location = new Point(1209, 729);
            produseComboBox.Name = "produseComboBox";
            produseComboBox.Size = new Size(449, 46);
            produseComboBox.TabIndex = 8;
            produseComboBox.SelectedIndexChanged += produseComboBox_SelectedIndexChanged;

            addButton.Anchor = AnchorStyles.Top;
            addButton.Font = new Font("Arial", 14F, FontStyle.Bold);
            addButton.ForeColor = Color.FromArgb(0, 64, 0);
            addButton.Location = new Point(458, 1018);
            addButton.Name = "addButton";
            addButton.Size = new Size(447, 69);
            addButton.TabIndex = 2;
            addButton.Text = "Adaugă";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;

            updateButton.Anchor = AnchorStyles.Top;
            updateButton.Font = new Font("Arial", 14F, FontStyle.Bold);
            updateButton.ForeColor = Color.FromArgb(0, 64, 0);
            updateButton.Location = new Point(1209, 794);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(449, 69);
            updateButton.TabIndex = 15;
            updateButton.Text = "Actualizează";
            updateButton.UseVisualStyleBackColor = true;
            updateButton.Click += updateButton_Click;

            pretLabel.Anchor = AnchorStyles.Top;
            pretLabel.AutoSize = true;
            pretLabel.Font = new Font("Arial", 14F, FontStyle.Bold);
            pretLabel.Location = new Point(458, 789);
            pretLabel.Name = "pretLabel";
            pretLabel.Size = new Size(91, 38);
            pretLabel.TabIndex = 7;
            pretLabel.Text = "Preț:";

            pretTextBox.Anchor = AnchorStyles.Top;
            pretTextBox.Font = new Font("Arial", 14F, FontStyle.Bold);
            pretTextBox.Location = new Point(458, 832);
            pretTextBox.Name = "pretTextBox";
            pretTextBox.Size = new Size(447, 45);
            pretTextBox.TabIndex = 5;

            produsTextBox.Anchor = AnchorStyles.Top;
            produsTextBox.Font = new Font("Arial", 14F, FontStyle.Bold);
            produsTextBox.Location = new Point(458, 733);
            produsTextBox.Name = "produsTextBox";
            produsTextBox.Size = new Size(447, 45);
            produsTextBox.TabIndex = 4;

            produsLabel.Anchor = AnchorStyles.Top;
            produsLabel.AutoSize = true;
            produsLabel.Font = new Font("Arial", 14F, FontStyle.Bold);
            produsLabel.Location = new Point(458, 700);
            produsLabel.Name = "produsLabel";
            produsLabel.Size = new Size(140, 38);
            produsLabel.TabIndex = 6;
            produsLabel.Text = "Produs:";

            categorieLabel.Anchor = AnchorStyles.Top;
            categorieLabel.AutoSize = true;
            categorieLabel.Font = new Font("Arial", 14F, FontStyle.Bold);
            categorieLabel.Location = new Point(458, 899);
            categorieLabel.Name = "categorieLabel";
            categorieLabel.Size = new Size(179, 38);
            categorieLabel.TabIndex = 12;
            categorieLabel.Text = "Categorie:";

            categorieComboBox.Anchor = AnchorStyles.Top;
            categorieComboBox.Font = new Font("Arial", 14F, FontStyle.Bold);
            categorieComboBox.FormattingEnabled = true;
            categorieComboBox.Items.AddRange(new object[] { "Bar", "Park" });
            categorieComboBox.Location = new Point(458, 942);
            categorieComboBox.Name = "categorieComboBox";
            categorieComboBox.Size = new Size(447, 46);
            categorieComboBox.TabIndex = 13;

            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Text", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkGreen;
            label1.Location = new Point(836, 58);
            label1.Name = "label1";
            label1.Size = new Size(454, 56);
            label1.TabIndex = 1;
            label1.Text = "Administrare Produse";

            produsePanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            produsePanel.AutoScroll = true;
            produsePanel.BorderStyle = BorderStyle.FixedSingle;
            produsePanel.Location = new Point(458, 142);
            produsePanel.Name = "produsePanel";
            produsePanel.Size = new Size(1215, 473);
            produsePanel.TabIndex = 11;

            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2640, 1511);
            Controls.Add(splitContainer1);
            Name = "produse";
            Text = "produse";
            WindowState = FormWindowState.Maximized;
            Load += produse_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            adminPage adminForm = new adminPage();
            adminForm.WindowState = FormWindowState.Maximized;
            adminForm.Show();
            this.Close();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            AventuraPAY mainForm = new AventuraPAY();
            mainForm.WindowState = FormWindowState.Maximized;
            mainForm.Show();
            this.Close();
        }

        private void produse_Load(object sender, EventArgs e)
        {
            LoadProduseData();
            LoadProduseComboBox();
        }

        private void LoadProduseData()
        {
            string connectionString = @"Data Source=D:\Projects\AventuraPAY\DB\aventuraDB.db;Version=3;";
            string query = "SELECT produs, pret, categoria FROM produse";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    // Sort the data by category with "Park" first, then "Bar"
                    DataView view = dataTable.DefaultView;
                    view.Sort = "categoria DESC";
                    DataTable sortedDataTable = view.ToTable();

                    UpdateProdusePanel(sortedDataTable);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }

        private void LoadProduseComboBox()
        {
            string connectionString = @"Data Source=D:\Projects\AventuraPAY\DB\aventuraDB.db;Version=3;";
            string query = "SELECT produs FROM produse";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SQLiteCommand command = new SQLiteCommand(query, connection);
                    SQLiteDataReader reader = command.ExecuteReader();

                    produseComboBox.Items.Clear();
                    while (reader.Read())
                    {
                        produseComboBox.Items.Add(reader["produs"].ToString());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string produs = produsTextBox.Text;
            string pret = pretTextBox.Text;
            string categorie = categorieComboBox.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(produs) || string.IsNullOrWhiteSpace(pret) || string.IsNullOrWhiteSpace(categorie))
            {
                MessageBox.Show("Numele produsului, prețul și categoria nu pot fi goale.");
                return;
            }

            string connectionString = @"Data Source=D:\Projects\AventuraPAY\DB\aventuraDB.db;Version=3;";
            string query = "INSERT INTO produse (produs, pret, categoria) VALUES (@produs, @pret, @categorie)";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@produs", produs);
                        command.Parameters.AddWithValue("@pret", pret);
                        command.Parameters.AddWithValue("@categorie", categorie);
                        command.ExecuteNonQuery();
                    }
                    LoadProduseData();
                    LoadProduseComboBox();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            string produs = produseComboBox.SelectedItem?.ToString();
            string newProdus = produsTextBox.Text;
            string pret = pretTextBox.Text;
            string categorie = categorieComboBox.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(produs) || string.IsNullOrWhiteSpace(newProdus) || string.IsNullOrWhiteSpace(pret) || string.IsNullOrWhiteSpace(categorie))
            {
                MessageBox.Show("Toate câmpurile sunt obligatorii pentru actualizare.");
                return;
            }

            string connectionString = @"Data Source=D:\Projects\AventuraPAY\DB\aventuraDB.db;Version=3;";
            string query = "UPDATE produse SET produs = @newProdus, pret = @pret, categoria = @categorie WHERE produs = @produs";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@produs", produs);
                        command.Parameters.AddWithValue("@newProdus", newProdus);
                        command.Parameters.AddWithValue("@pret", pret);
                        command.Parameters.AddWithValue("@categorie", categorie);
                        command.ExecuteNonQuery();
                    }
                    LoadProduseData();
                    LoadProduseComboBox();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            string produs = produseComboBox.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(produs))
            {
                MessageBox.Show("Selectați un produs pentru a-l șterge.");
                return;
            }

            string connectionString = @"Data Source=D:\Projects\AventuraPAY\DB\aventuraDB.db;Version=3;";
            string query = "DELETE FROM produse WHERE produs = @produs";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@produs", produs);
                        command.ExecuteNonQuery();
                    }
                    LoadProduseData();
                    LoadProduseComboBox();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }

        private void produseComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string produs = produseComboBox.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(produs))
                return;

            string connectionString = @"Data Source=D:\Projects\AventuraPAY\DB\aventuraDB.db;Version=3;";
            string query = "SELECT produs, pret, categoria FROM produse WHERE produs = @produs";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@produs", produs);
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                produsTextBox.Text = reader["produs"].ToString();
                                pretTextBox.Text = reader["pret"].ToString();
                                categorieComboBox.SelectedItem = reader["categoria"].ToString();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }

        private void UpdateProdusePanel(DataTable dataTable)
        {
            produsePanel.Controls.Clear();
            produsePanel.AutoScroll = true; // Enable auto-scroll

            int yPos = 10;

            foreach (DataRow row in dataTable.Rows)
            {
                Label produsLabel = new Label
                {
                    Text = $"Produs: {row["produs"]}, Preț: {row["pret"]}, Categorie: {row["categoria"]}",
                    Location = new System.Drawing.Point(10, yPos),
                    AutoSize = true
                };

                produsePanel.Controls.Add(produsLabel);
                yPos += 30;
            }
        }

        private Label label2;
        private PictureBox pictureBox1;
    }
}
