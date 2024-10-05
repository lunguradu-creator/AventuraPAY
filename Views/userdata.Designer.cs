using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Security.Cryptography;
using System.Text;

namespace AventuraPAY
{
    partial class userdata : Form
    {
        private System.ComponentModel.IContainer components = null;
        private SplitContainer splitContainer1;
        private Button button1;
        private Button addButton;
        private Button deleteButton;
        private Button buttonLogout; // Add the logout button here
        private TextBox usernameTextBox;
        private TextBox passwordTextBox;
        private Label label1;
        private Label usernameLabel;
        private Label passwordLabel;
        private ComboBox usersComboBox;
        private Label deleteLabel;
        private Label addLabel;
        private Panel userPanel;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(userdata));
            splitContainer1 = new SplitContainer();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            buttonLogout = new Button();
            deleteLabel = new Label();
            addLabel = new Label();
            deleteButton = new Button();
            usersComboBox = new ComboBox();
            addButton = new Button();
            passwordLabel = new Label();
            passwordTextBox = new TextBox();
            usernameTextBox = new TextBox();
            usernameLabel = new Label();
            label1 = new Label();
            userPanel = new Panel();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(pictureBox1);
            splitContainer1.Panel1.Controls.Add(button1);
            splitContainer1.Panel1.Controls.Add(buttonLogout);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(deleteLabel);
            splitContainer1.Panel2.Controls.Add(addLabel);
            splitContainer1.Panel2.Controls.Add(deleteButton);
            splitContainer1.Panel2.Controls.Add(usersComboBox);
            splitContainer1.Panel2.Controls.Add(addButton);
            splitContainer1.Panel2.Controls.Add(passwordLabel);
            splitContainer1.Panel2.Controls.Add(passwordTextBox);
            splitContainer1.Panel2.Controls.Add(usernameTextBox);
            splitContainer1.Panel2.Controls.Add(usernameLabel);
            splitContainer1.Panel2.Controls.Add(label1);
            splitContainer1.Panel2.Controls.Add(userPanel);
            splitContainer1.Size = new Size(2640, 1511);
            splitContainer1.SplitterDistance = 502;
            splitContainer1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(73, 36);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(320, 305);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Font = new Font("Arial", 14F, FontStyle.Bold);
            button1.ForeColor = Color.FromArgb(0, 64, 0);
            button1.Location = new Point(48, 1303);
            button1.Name = "button1";
            button1.Size = new Size(371, 87);
            button1.TabIndex = 1;
            button1.Text = "Revino la Pagina ADMIN";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // buttonLogout
            // 
            buttonLogout.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonLogout.BackColor = Color.FromArgb(0, 64, 0);
            buttonLogout.Font = new Font("Arial", 14F, FontStyle.Bold);
            buttonLogout.ForeColor = Color.White;
            buttonLogout.Location = new Point(48, 1410);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Size = new Size(371, 69);
            buttonLogout.TabIndex = 9;
            buttonLogout.Text = "LOGOUT";
            buttonLogout.UseVisualStyleBackColor = false;
            buttonLogout.Click += buttonLogout_Click;
            // 
            // deleteLabel
            // 
            deleteLabel.AutoSize = true;
            deleteLabel.Font = new Font("Arial", 12F, FontStyle.Bold);
            deleteLabel.ForeColor = Color.DarkGreen;
            deleteLabel.Location = new Point(1108, 581);
            deleteLabel.Name = "deleteLabel";
            deleteLabel.Size = new Size(303, 33);
            deleteLabel.TabIndex = 9;
            deleteLabel.Text = "ȘTERGE UTILIZATOR";
            // 
            // addLabel
            // 
            addLabel.AutoSize = true;
            addLabel.Font = new Font("Arial", 12F, FontStyle.Bold);
            addLabel.ForeColor = Color.DarkGreen;
            addLabel.Location = new Point(624, 581);
            addLabel.Name = "addLabel";
            addLabel.Size = new Size(305, 33);
            addLabel.TabIndex = 10;
            addLabel.Text = "ADAUGĂ UTILIZATOR";
            // 
            // deleteButton
            // 
            deleteButton.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deleteButton.ForeColor = Color.FromArgb(0, 64, 0);
            deleteButton.Location = new Point(1108, 859);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(294, 69);
            deleteButton.TabIndex = 3;
            deleteButton.Text = "Șterge";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // usersComboBox
            // 
            usersComboBox.Font = new Font("Arial", 12F);
            usersComboBox.FormattingEnabled = true;
            usersComboBox.Location = new Point(1108, 681);
            usersComboBox.Name = "usersComboBox";
            usersComboBox.Size = new Size(303, 40);
            usersComboBox.TabIndex = 8;
            // 
            // addButton
            // 
            addButton.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addButton.ForeColor = Color.FromArgb(0, 64, 0);
            addButton.Location = new Point(624, 859);
            addButton.Name = "addButton";
            addButton.Size = new Size(342, 69);
            addButton.TabIndex = 2;
            addButton.Text = "Adaugă";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            passwordLabel.Location = new Point(624, 737);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(111, 33);
            passwordLabel.TabIndex = 7;
            passwordLabel.Text = "Parolă:";
            // 
            // passwordTextBox
            // 
            passwordTextBox.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordTextBox.Location = new Point(624, 780);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(342, 40);
            passwordTextBox.TabIndex = 5;
            // 
            // usernameTextBox
            // 
            usernameTextBox.Font = new Font("Arial", 12F);
            usernameTextBox.Location = new Point(624, 681);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(342, 40);
            usernameTextBox.TabIndex = 4;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            usernameLabel.Location = new Point(624, 648);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(104, 33);
            usernameLabel.TabIndex = 6;
            usernameLabel.Text = "Nume:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Text", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkGreen;
            label1.Location = new Point(777, 57);
            label1.Name = "label1";
            label1.Size = new Size(489, 56);
            label1.TabIndex = 1;
            label1.Text = "Administrare Utilizatori";
            // 
            // userPanel
            // 
            userPanel.BorderStyle = BorderStyle.FixedSingle;
            userPanel.Location = new Point(458, 142);
            userPanel.Name = "userPanel";
            userPanel.Size = new Size(1113, 360);
            userPanel.TabIndex = 11;
            // 
            // userdata
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2640, 1511);
            Controls.Add(splitContainer1);
            Name = "userdata";
            Text = "userdata";
            WindowState = FormWindowState.Maximized;
            Load += userdata_Load;
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
            var mainForm = new AventuraPAYForm();
            mainForm.WindowState = FormWindowState.Maximized;
            mainForm.Show();
            this.Close();
        }

        private void userdata_Load(object sender, EventArgs e)
        {
            LoadUserData();
            LoadUsersComboBox();
        }

        private void LoadUserData()
        {
            string connectionString = @"Data Source=D:\Projects\AventuraPAY\DB\aventuraDB.db;Version=3;";
            string query = "SELECT username, password FROM login";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    UpdateUserPanel(dataTable, true);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }

        private void UpdateUserPanel(DataTable dataTable, bool v)
        {
            throw new NotImplementedException();
        }

        private void LoadUsersComboBox()
        {
            string connectionString = @"Data Source=D:\Projects\AventuraPAY\DB\aventuraDB.db;Version=3;";
            string query = "SELECT username FROM login";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SQLiteCommand command = new SQLiteCommand(query, connection);
                    SQLiteDataReader reader = command.ExecuteReader();

                    usersComboBox.Items.Clear();
                    while (reader.Read())
                    {
                        usersComboBox.Items.Add(reader["username"].ToString());
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
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Numele de utilizator și parola nu pot fi goale.");
                return;
            }

            string hashedPassword = HashPassword(password); // Hash the password

            string connectionString = @"Data Source=D:\Projects\AventuraPAY\DB\aventuraDB.db;Version=3;";
            string query = "INSERT INTO login (username, password) VALUES (@username, @password)";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@password", hashedPassword); // Store the hashed password
                        command.ExecuteNonQuery();
                    }
                    LoadUserData();
                    LoadUsersComboBox();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            string username = usersComboBox.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Selectați un utilizator pentru a-l șterge.");
                return;
            }

            string connectionString = @"Data Source=D:\Projects\AventuraPAY\DB\aventuraDB.db;Version=3;";
            string query = "DELETE FROM login WHERE username = @username";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@username", username);
                        command.ExecuteNonQuery();
                    }
                    LoadUserData();
                    LoadUsersComboBox();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }

        private void UpdateUserPanel(DataTable dataTable)
        {
            userPanel.Controls.Clear();
            int yPos = 10;

            foreach (DataRow row in dataTable.Rows)
            {
                Label userLabel = new Label
                {
                    Text = $"User: {row["username"]}, Parola: (hashed)",
                    Location = new System.Drawing.Point(10, yPos),
                    AutoSize = true
                };

                userPanel.Controls.Add(userLabel);
                yPos += 30;
            }
        }

        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private PictureBox pictureBox1;
    }
}
