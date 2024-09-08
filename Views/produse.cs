using AventuraPAY.Controllers;
using AventuraPAY.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace AventuraPAY.Views
{
    public partial class produse : Form
    {
        private ProductController controller;

        public produse()
        {
            InitializeComponent();
            controller = new ProductController(this);
            this.WindowState = FormWindowState.Maximized;
        }

        private void produse_Load(object sender, EventArgs e)
        {
            controller.LoadAllProducts();
            controller.LoadProductNames();
        }

        public void UpdateProductPanel(DataTable products)
        {
            produsePanel.Controls.Clear();
            produsePanel.AutoScroll = true; // Enable auto-scroll

            int yPos = 10;

            foreach (DataRow row in products.Rows)
            {
                Label produsLabel = new Label
                {
                    Text = $"Produs: {row["produs"]}, Preț: {row["pret"]}, Categorie: {row["categoria"]}",
                    Location = new System.Drawing.Point(10, yPos),
                    AutoSize = true
                };

                produsePanel.Controls.Add(produsLabel);
                yPos += 30;
            }
        }

        public void UpdateProductComboBox(List<string> productNames)
        {
            produseComboBox.Items.Clear();
            foreach (var name in productNames)
            {
                produseComboBox.Items.Add(name);
            }
        }

        public void DisplayProductDetails(DataRow productDetails)
        {
            produsTextBox.Text = productDetails["produs"].ToString();
            pretTextBox.Text = productDetails["pret"].ToString();
            categorieComboBox.SelectedItem = productDetails["categoria"].ToString();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string produs = produsTextBox.Text;
            string pret = pretTextBox.Text;
            string categorie = categorieComboBox.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(produs) || string.IsNullOrWhiteSpace(pret) || string.IsNullOrWhiteSpace(categorie))
            {
                MessageBox.Show("Numele produsului, prețul și categoria nu pot fi goale.");
                return;
            }

            controller.AddProduct(produs, pret, categorie);
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            string produs = produseComboBox.SelectedItem?.ToString();
            string newProdus = produsTextBox.Text;
            string pret = pretTextBox.Text;
            string categorie = categorieComboBox.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(produs) || string.IsNullOrWhiteSpace(newProdus) || string.IsNullOrWhiteSpace(pret) || string.IsNullOrWhiteSpace(categorie))
            {
                MessageBox.Show("Toate câmpurile sunt obligatorii pentru actualizare.");
                return;
            }

            controller.UpdateProduct(produs, newProdus, pret, categorie);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            string produs = produseComboBox.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(produs))
            {
                MessageBox.Show("Selectați un produs pentru a-l șterge.");
                return;
            }

            controller.DeleteProduct(produs);
        }

        private void produseComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string produs = produseComboBox.SelectedItem?.ToString();
            if (!string.IsNullOrWhiteSpace(produs))
            {
                controller.LoadProductDetails(produs);
            }
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
