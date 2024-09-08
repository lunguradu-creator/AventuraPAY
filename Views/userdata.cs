using AventuraPAY.Controllers;
using System;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace AventuraPAY.Views
{
    public partial class userdata : Form
    {
        private UserController controller;

        public userdata()
        {
            InitializeComponent();
            controller = new UserController(this);
            this.WindowState = FormWindowState.Maximized;
        }

        private void userdata_Load(object sender, EventArgs e)
        {
            controller.LoadAllUsers();
            controller.LoadUsernames();
        }

        public void UpdateUserPanel(DataTable users)
        {
            userPanel.Controls.Clear();
            int yPos = 10;

            foreach (DataRow row in users.Rows)
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

        public void UpdateUserComboBox(List<string> usernames)
        {
            usersComboBox.Items.Clear();
            usersComboBox.Items.AddRange(usernames.ToArray());
        }

        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;

            controller.AddUser(username, password);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            string username = usersComboBox.SelectedItem?.ToString();

            controller.DeleteUser(username);
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
    }
}
