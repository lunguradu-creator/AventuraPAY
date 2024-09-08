using AventuraPAY.Controllers;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AventuraPAY.Views
{
    public partial class vanzari : Form
    {
        private SalesController controller;

        public vanzari(string username)
        {
            InitializeComponent();
            controller = new SalesController(this);
            this.WindowState = FormWindowState.Maximized;
            controller.LoadProducts();
        }

        public void PopulateProducts(List<Tuple<string, string>> products)
        {
            produseFlowLayoutPanel.Controls.Clear();
            foreach (var product in products)
            {
                Panel productPanel = new Panel
                {
                    Size = new Size(250, 170),
                    Margin = new Padding(10),
                    BorderStyle = BorderStyle.FixedSingle
                };

                PictureBox productPictureBox = new PictureBox
                {
                    Image = Image.FromFile(GetIconPathForCategory(product.Item2)),
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Size = new Size(50, 50),
                    Location = new Point(100, 20)
                };

                CheckBox productCheckBox = new CheckBox
                {
                    Text = product.Item1,
                    Location = new Point(10, 110),
                    AutoSize = true
                };

                productPanel.Controls.Add(productPictureBox);
                productPanel.Controls.Add(productCheckBox);
                produseFlowLayoutPanel.Controls.Add(productPanel);
            }
        }

        public void AddProductToReceiptList(string productName, int quantity, double price, double totalPrice)
        {
            receiptListBox.Items.Add($"{quantity} x {productName} X {price} Lei = {totalPrice} Lei");
        }

        public void UpdateTotalAmount(double amount)
        {
            totalAmount += amount;
            totalAmountLabel.Text = totalAmount.ToString("F2");
        }

        public void PrintReceipt(int receiptId)
        {
            // Logică pentru imprimarea bonului folosind receiptId
        }

        public void ResetForm()
        {
            // Logică pentru resetarea formularului după înregistrarea bonului
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string selectedProduct = null;
            foreach (Control control in produseFlowLayoutPanel.Controls)
            {
                if (control is Panel panel)
                {
                    foreach (Control subControl in panel.Controls)
                    {
                        if (subControl is CheckBox checkBox && checkBox.Checked)
                        {
                            selectedProduct = checkBox.Text;
                            break;
                        }
                    }
                }
                if (selectedProduct != null) break;
            }

            if (selectedProduct == null || !int.TryParse(cantitateTextBox.Text, out int quantity))
            {
                MessageBox.Show("Selectați un produs și introduceți o cantitate validă.");
                return;
            }

            controller.AddProductToReceipt(selectedProduct, quantity);
        }

        private void finalizeButton_Click(object sender, EventArgs e)
        {
            if (!cashRadioButton.Checked && !cardRadioButton.Checked && !protocolRadioButton.Checked)
            {
                MessageBox.Show("Te rugăm să selectezi o metodă de plată (Cash, Card sau Protocol) înainte de a marca nota de plată.", "Metodă de plată necesară", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (receiptListBox.Items.Count == 0)
            {
                MessageBox.Show("Te rugăm să adaugi cel puțin un produs pe bon înainte de a marca nota de plată.", "Produs necesar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string products = string.Join(", ", receiptListBox.Items.Cast<string>());
            string paymentMethod = cashRadioButton.Checked ? "Cash" : cardRadioButton.Checked ? "Card" : protocolRadioButton.Checked ? "Protocol" : string.Empty;
            string clientDetails = numetextBox.Text;

            controller.FinalizeReceipt(products, totalAmount, paymentMethod, clientDetails);
        }
    }
}
