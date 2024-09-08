using System;
using System.Windows.Forms;
using AventuraPAY.Controllers;

namespace AventuraPAY.Views
{
    public partial class AventuraPAY : Form
    {
        private LoginController controller;

        public AventuraPAY()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            controller = new LoginController(this);
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            controller.HandleLogin();
        }

        public string Username => textBoxUsername.Text;
        public string Password => textBoxPassword.Text;
    }
}
