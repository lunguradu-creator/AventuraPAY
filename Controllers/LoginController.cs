using AventuraPAY.Models;
using AventuraPAY.Views; // Asigură-te că folosești corect namespace-ul în care se află formularul
using System;
using System.Windows.Forms;

namespace AventuraPAY.Controllers
{
    public class LoginController
    {
        private readonly UserModel userModel;
        private readonly AventuraPAYForm view;  // Folosește numele corect al formularului

        public LoginController(AventuraPAYForm view)  // Actualizează constructorul pentru a folosi tipul corect
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
                    Sales vanzariForm = new Sales(enteredUsername);
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
