using AventuraPAY.Models;
using AventuraPAY.Views;
using System;
using System.Windows.Forms;

namespace AventuraPAY.Controllers
{
    public class LoginController
    {
        private readonly UserModel userModel;
        private readonly AventuraPAY view;

        public LoginController(AventuraPAY view)
        {
            this.view = view;
            this.userModel = new UserModel();
        }

        public void HandleLogin()
        {
            string enteredUsername = view.Username;
            string enteredPassword = view.Password;

            userModel.RecordLoginAttempt(enteredUsername);

            bool credentialsValid = userModel.CheckCredentials(enteredUsername, enteredPassword);
            if (credentialsValid)
            {
                if (enteredUsername.Equals("Admin", StringComparison.OrdinalIgnoreCase))
                {
                    adminPage AdminForm = new adminPage();
                    AdminForm.WindowState = FormWindowState.Maximized;
                    AdminForm.Show();
                    view.Hide();
                }
                else
                {
                    vanzari vanzariForm = new vanzari(enteredUsername);
                    vanzariForm.WindowState = FormWindowState.Maximized;
                    vanzariForm.Show();
                    view.Hide();
                }
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
