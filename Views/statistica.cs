using AventuraPAY.Controllers;
using System;
using System.Windows.Forms;

namespace AventuraPAY.Views
{
    public partial class statistica : Form
    {
        private StatisticsController controller;

        public statistica()
        {
            InitializeComponent();
            controller = new StatisticsController(this);
            this.WindowState = FormWindowState.Maximized;
        }

        private void statistica_Load(object sender, EventArgs e)
        {
            controller.DisplayStatistics();
        }

        public void UpdateTotalIncasari(decimal total)
        {
            totalIncasariLabel.Text = $"Total Incasari Azi: {total:N2} Lei";
        }

        public void UpdateTotalIncasariIeri(decimal total)
        {
            totalIncasariIeriLabel.Text = $"Total Incasari Ieri: {total:N2} Lei";
        }

        public void UpdatePercentageChange(decimal percentage)
        {
            percentageChangeLabel.Text = $"{percentage:N2}%";
        }

        public void UpdateTotal7Days(decimal total)
        {
            total7DaysLabel.Text = $"Incasari Ultimele 7 Zile: {total:N2} Lei";
        }

        public void UpdateTotal7DaysPrev(decimal total)
        {
            total7DaysPrevLabel.Text = $"Incasari Anterioare 7 Zile: {total:N2} Lei";
        }

        public void UpdatePercentageChange7Days(decimal percentage)
        {
            percentageChange7DaysLabel.Text = $"{percentage:N2}%";
        }

        public void UpdateTotal30Days(decimal total)
        {
            total30DaysLabel.Text = $"Incasari Ultimele 30 Zile: {total:N2} Lei";
        }

        public void UpdateTotal30DaysPrev(decimal total)
        {
            total30DaysPrevLabel.Text = $"Incasari Anterioare 30 Zile: {total:N2} Lei";
        }

        public void UpdatePercentageChange30Days(decimal percentage)
        {
            percentageChange30DaysLabel.Text = $"{percentage:N2}%";
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
            adminPage adminPageForm = new adminPage();
            adminPageForm.WindowState = FormWindowState.Maximized;
            adminPageForm.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Close();
            Statistica2 statistica2Form = new Statistica2();
            statistica2Form.WindowState = FormWindowState.Maximized;
            statistica2Form.Show();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            var aventuraPayForm = new AventuraPAY();
            aventuraPayForm.WindowState = FormWindowState.Maximized;
            aventuraPayForm.Show();
            this.Close();
        }
    }
}
