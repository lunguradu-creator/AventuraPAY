using AventuraPAY.Views;
using System;
using System.Windows.Forms;

namespace AventuraPAY
{
    public partial class adminPage : Form
    {
        public adminPage()
        {
            InitializeComponent();
        }

        private void Button0_Click(object sender, EventArgs e)
        {
            // Code to redirect to vanzari.cs
            var vanzariForm = new Sales();
            vanzariForm.WindowState = FormWindowState.Maximized;
            vanzariForm.Show();
            this.Close(); // Close the current form
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // Code to redirect to userdata.cs
            var userdataForm = new userdata();
            userdataForm.WindowState = FormWindowState.Maximized;
            userdataForm.Show();
            this.Close(); // Close the current form
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            // Code to redirect to produse.cs
            var produseForm = new Products();
            produseForm.WindowState = FormWindowState.Maximized;
            produseForm.Show();
            this.Close(); // Close the current form
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            // Code to redirect to statistici.cs
            var statisticaForm = new Statistics();
            statisticaForm.WindowState = FormWindowState.Maximized;
            statisticaForm.Show();
            this.Close(); // Close the current form
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            // Code to redirect to utile.cs
            var utileForm = new Tools();
            utileForm.WindowState = FormWindowState.Maximized;
            utileForm.Show();
            this.Close(); // Close the current form
        }
        private void Button5_Click(object sender, EventArgs e)
        {
            // Code to redirect to AventuraPAY.cs
            var AventuraPAYForm = new AventuraPAY();
            AventuraPAYForm.WindowState = FormWindowState.Maximized;
            AventuraPAYForm.Show();
            this.Close(); // Close the current form
        }
    }
}
