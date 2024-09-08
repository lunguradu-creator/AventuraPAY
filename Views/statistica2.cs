using AventuraPAY.Controllers;
using System;
using System.Windows.Forms;

namespace AventuraPAY.Views
{
    public partial class statistica2 : Form
    {
        private StatisticsController2 controller;

        public statistica2()
        {
            InitializeComponent();
            controller = new StatisticsController2(this);
            this.WindowState = FormWindowState.Maximized;
        }

        private void statistica2_Load(object sender, EventArgs e)
        {
            controller.LoadUsers();
        }

        public void PopulateUserComboBox(string[] users)
        {
            userComboBox.Items.Clear();
            userComboBox.Items.AddRange(users);
        }

        public void UpdateStatistics(decimal cardTotal, decimal cashTotal, decimal protocolTotal, decimal totalIncasari)
        {
            cardLabel.Text = "Card: " + cardTotal.ToString("N2") + " Lei";
            cashLabel.Text = "Cash: " + cashTotal.ToString("N2") + " Lei";
            protocolLabel.Text = "Protocol: " + protocolTotal.ToString("N2") + " Lei";
            totalLabel.Text = "Total: " + totalIncasari.ToString("N2") + " Lei";
        }

        private void showStatisticsButton_Click(object sender, EventArgs e)
        {
            DateTime startDate = startDatePicker.Value;
            DateTime endDate = endDatePicker.Value;
            string selectedUser = userComboBox.SelectedItem?.ToString();

            controller.DisplayStatistics(startDate, endDate, selectedUser);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
            adminPage adminPageForm = new adminPage();
            adminPageForm.WindowState = FormWindowState.Maximized;
            adminPageForm.Show();
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
