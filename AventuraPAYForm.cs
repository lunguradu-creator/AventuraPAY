using System;
using System.Windows.Forms;
using AventuraPAY.Controllers;

namespace AventuraPAY.Views
{
    public partial class AventuraPAYForm : Form
    {
        private LoginController controller;

        public AventuraPAYForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            controller = new LoginController(this);  // Inițializezi controlerul
        }

        // Definirea metodei buttonSubmit_Click care este apelată la apăsarea butonului Login
        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            controller.HandleLogin();  // Apelăm logica de login din controller
        }

        public string Username => textBoxUsername.Text;  // Accesăm textul din câmpul Username
        public string Password => textBoxPassword.Text;  // Accesăm textul din câmpul Password
    }
}
