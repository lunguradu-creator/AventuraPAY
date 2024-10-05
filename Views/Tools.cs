using System;
using System.Windows.Forms;

namespace AventuraPAY.Views
{
    public partial class Tools : Form
    {
        public Tools()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
            adminPage adminPageForm = new adminPage();
            adminPageForm.WindowState = FormWindowState.Maximized;
            adminPageForm.Show();
        }
    }
}
