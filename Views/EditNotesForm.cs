using System;
using System.Collections.Generic;
using System.Windows.Forms;
using AventuraPAY.Controllers;
using AventuraPAY.Models;

namespace AventuraPAY.Views
{
    public partial class EditNotesForm : Form
    {
        private EditNotesController controller;

        public EditNotesForm(Form previousForm)
        {
            InitializeComponent();
            controller = new EditNotesController(this);
            this.previousForm = previousForm;
            this.WindowState = FormWindowState.Maximized; // deschide fereastra în fullscreen
            controller.LoadReceipts();
        }

        public void DisplayReceipts(List<Receipt> receipts)
        {
            receiptsListBox.Items.Clear();
            foreach (var receipt in receipts)
            {
                receiptsListBox.Items.Add(receipt);
            }
        }

        private void searchNumberButton_Click(object sender, EventArgs e)
        {
            controller.LoadReceipts(searchTextBox.Text, null);
        }

        private void searchDateButton_Click(object sender, EventArgs e)
        {
            controller.LoadReceipts(null, dateFilterPicker.Value);
        }

        private void receiptsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (receiptsListBox.SelectedItem != null)
            {
                var receipt = (Receipt)receiptsListBox.SelectedItem;
                detailsTextBox.Text = $"Data: {receipt.Data}\r\nProduse: {receipt.Produse}\r\nTotal: {receipt.Total}\r\nMetodaPlata: {receipt.MetodaPlata}\r\nDetaliiClient: {receipt.DetaliiClient}";
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (receiptsListBox.SelectedItem != null)
            {
                var receipt = (Receipt)receiptsListBox.SelectedItem;
                string[] details = detailsTextBox.Text.Split(new[] { "\r\n" }, StringSplitOptions.None);
                receipt.Data = details[0].Split(new[] { "Data: " }, StringSplitOptions.None)[1];
                receipt.Produse = details[1].Split(new[] { "Produse: " }, StringSplitOptions.None)[1];
                receipt.Total = Convert.ToDouble(details[2].Split(new[] { "Total: " }, StringSplitOptions.None)[1]);
                receipt.MetodaPlata = details[3].Split(new[] { "MetodaPlata: " }, StringSplitOptions.None)[1];
                receipt.DetaliiClient = details[4].Split(new[] { "DetaliiClient: " }, StringSplitOptions.None)[1];

                controller.SaveReceipt(receipt);
                MessageBox.Show("Receipt updated successfully.");
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (receiptsListBox.SelectedItem != null)
            {
                var receipt = (Receipt)receiptsListBox.SelectedItem;
                controller.DeleteReceipt(receipt.Id);
                receiptsListBox.Items.Remove(receipt);
                detailsTextBox.Clear();
                MessageBox.Show("Receipt deleted successfully.");
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            var vanzariForm = new vanzari();
            vanzariForm.WindowState = FormWindowState.Maximized;
            vanzariForm.Show();
            this.Close();
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
