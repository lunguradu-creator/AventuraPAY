using System;
using System.Data.SQLite;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Drawing.Printing;

namespace AventuraPAY
{
    public partial class Sales : Form
    {
        private System.ComponentModel.IContainer components = null;
        private SplitContainer splitContainer1;
        private Button backButton;
        private Button addButton;
        private Button finalizeButton;
        private Button resetButton;
        private Button editNotesButton;
        private FlowLayoutPanel produseFlowLayoutPanel;
        private TextBox cantitateTextBox;
        private Button increaseButton;
        private Button decreaseButton;
        private Label cantitateLabel;
        private Label produseLabel;
        private Label totalLabel;
        private Label totalAmountLabel;
        private double totalAmount = 0;
        private RadioButton cashRadioButton;
        private RadioButton cardRadioButton;
        private RadioButton protocolRadioButton;
        private TextBox numetextBox;
        private Label clientNameLabel;
        private bool clientNameAddedToReceipt = false;
        private int receiptId;
        private string loggedInUsername;
        private Button generateClosureButton;
        private PictureBox pictureBox1;
        private Button buttonLogout;
        private bool isAdmin;

        public Sales(string username)
        {
            InitializeComponent();
            loggedInUsername = username;
            isAdmin = CheckIfUserIsAdmin(username);

            if (!isAdmin)
            {
                HideAdminButtons();
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sales));
            splitContainer1 = new SplitContainer();
            buttonLogout = new Button();
            pictureBox1 = new PictureBox();
            backButton = new Button();
            generateClosureButton = new Button();
            editNotesButton = new Button();
            clientNameLabel = new Label();
            numetextBox = new TextBox();
            produseFlowLayoutPanel = new FlowLayoutPanel();
            cantitateTextBox = new TextBox();
            increaseButton = new Button();
            decreaseButton = new Button();
            cantitateLabel = new Label();
            produseLabel = new Label();
            addButton = new Button();
            finalizeButton = new Button();
            resetButton = new Button();
            receiptListBox = new ListBox();
            totalLabel = new Label();
            totalAmountLabel = new Label();
            cashRadioButton = new RadioButton();
            cardRadioButton = new RadioButton();
            protocolRadioButton = new RadioButton();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();

            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Margin = new Padding(4);
            splitContainer1.Name = "splitContainer1";

            splitContainer1.Panel1.Controls.Add(buttonLogout);
            splitContainer1.Panel1.Controls.Add(pictureBox1);
            splitContainer1.Panel1.Controls.Add(backButton);
            splitContainer1.Panel1.Controls.Add(generateClosureButton);
            splitContainer1.Panel1.Controls.Add(editNotesButton);
            splitContainer1.Panel1.Paint += splitContainer1_Panel1_Paint;

            splitContainer1.Panel2.Controls.Add(clientNameLabel);
            splitContainer1.Panel2.Controls.Add(numetextBox);
            splitContainer1.Panel2.Controls.Add(produseFlowLayoutPanel);
            splitContainer1.Panel2.Controls.Add(cantitateTextBox);
            splitContainer1.Panel2.Controls.Add(increaseButton);
            splitContainer1.Panel2.Controls.Add(decreaseButton);
            splitContainer1.Panel2.Controls.Add(cantitateLabel);
            splitContainer1.Panel2.Controls.Add(produseLabel);
            splitContainer1.Panel2.Controls.Add(addButton);
            splitContainer1.Panel2.Controls.Add(finalizeButton);
            splitContainer1.Panel2.Controls.Add(resetButton);
            splitContainer1.Panel2.Controls.Add(receiptListBox);
            splitContainer1.Panel2.Controls.Add(totalLabel);
            splitContainer1.Panel2.Controls.Add(totalAmountLabel);
            splitContainer1.Panel2.Controls.Add(cashRadioButton);
            splitContainer1.Panel2.Controls.Add(cardRadioButton);
            splitContainer1.Panel2.Controls.Add(protocolRadioButton);
            splitContainer1.Panel2.Controls.Add(button1);
            splitContainer1.Panel2.Paint += splitContainer1_Panel2_Paint;
            splitContainer1.Size = new Size(2922, 1671);
            splitContainer1.SplitterDistance = 556;
            splitContainer1.SplitterWidth = 5;
            splitContainer1.TabIndex = 0;

            buttonLogout.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonLogout.BackColor = Color.FromArgb(0, 64, 0);
            buttonLogout.Font = new Font("Arial", 14F, FontStyle.Bold);
            buttonLogout.ForeColor = Color.White;
            buttonLogout.Location = new Point(57, 1537);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Size = new Size(429, 69);
            buttonLogout.TabIndex = 9;
            buttonLogout.Text = "LOGOUT";
            buttonLogout.UseVisualStyleBackColor = false;
            buttonLogout.Click += buttonLogout_Click;

            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(110, 33);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(320, 305);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;

            backButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            backButton.Font = new Font("Arial", 14F, FontStyle.Bold);
            backButton.ForeColor = Color.FromArgb(0, 64, 0);
            backButton.Location = new Point(57, 1405);
            backButton.Margin = new Padding(4);
            backButton.Name = "backButton";
            backButton.Size = new Size(429, 90);
            backButton.TabIndex = 0;
            backButton.Text = "Revino la Pagina ADMIN";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;

            generateClosureButton.Font = new Font("Arial", 14.1428576F, FontStyle.Bold, GraphicsUnit.Point, 0);
            generateClosureButton.Location = new Point(57, 414);
            generateClosureButton.Margin = new Padding(4);
            generateClosureButton.Name = "generateClosureButton";
            generateClosureButton.Size = new Size(429, 84);
            generateClosureButton.TabIndex = 19;
            generateClosureButton.Text = "Generează Închidere";
            generateClosureButton.UseVisualStyleBackColor = true;
            generateClosureButton.Click += generateClosureButton_Click;

            editNotesButton.Font = new Font("Arial", 14.1428576F, FontStyle.Bold, GraphicsUnit.Point, 0);
            editNotesButton.Location = new Point(57, 530);
            editNotesButton.Margin = new Padding(4);
            editNotesButton.Name = "editNotesButton";
            editNotesButton.Size = new Size(429, 84);
            editNotesButton.TabIndex = 18;
            editNotesButton.Text = "Editare Note de Plata";
            editNotesButton.UseVisualStyleBackColor = true;
            editNotesButton.Click += editNotesButton_Click;

            clientNameLabel.Anchor = AnchorStyles.Top;
            clientNameLabel.AutoSize = true;
            clientNameLabel.Font = new Font("Arial", 14F, FontStyle.Bold);
            clientNameLabel.Location = new Point(370, 44);
            clientNameLabel.Margin = new Padding(4, 0, 4, 0);
            clientNameLabel.Name = "clientNameLabel";
            clientNameLabel.Size = new Size(384, 38);
            clientNameLabel.TabIndex = 15;
            clientNameLabel.Text = "Nume și prenume client";

            numetextBox.Anchor = AnchorStyles.Top;
            numetextBox.Font = new Font("Arial", 14F);
            numetextBox.Location = new Point(370, 87);
            numetextBox.Margin = new Padding(4);
            numetextBox.Multiline = true;
            numetextBox.Name = "numetextBox";
            numetextBox.Size = new Size(523, 55);
            numetextBox.TabIndex = 14;
            numetextBox.TextChanged += numetextBox_TextChanged;

            produseFlowLayoutPanel.Anchor = AnchorStyles.Top;
            produseFlowLayoutPanel.AutoScroll = true;
            produseFlowLayoutPanel.BorderStyle = BorderStyle.FixedSingle;
            produseFlowLayoutPanel.Location = new Point(1287, 120);
            produseFlowLayoutPanel.Margin = new Padding(4);
            produseFlowLayoutPanel.Name = "produseFlowLayoutPanel";
            produseFlowLayoutPanel.Size = new Size(830, 1180);
            produseFlowLayoutPanel.TabIndex = 18;

            cantitateTextBox.Anchor = AnchorStyles.Top;
            cantitateTextBox.Font = new Font("Segoe UI", 14F);
            cantitateTextBox.Location = new Point(370, 232);
            cantitateTextBox.Margin = new Padding(4);
            cantitateTextBox.Name = "cantitateTextBox";
            cantitateTextBox.Size = new Size(523, 51);
            cantitateTextBox.TabIndex = 2;

            increaseButton.Anchor = AnchorStyles.Top;
            increaseButton.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            increaseButton.Location = new Point(370, 291);
            increaseButton.Margin = new Padding(4);
            increaseButton.Name = "increaseButton";
            increaseButton.Size = new Size(243, 51);
            increaseButton.TabIndex = 19;
            increaseButton.Text = "+";
            increaseButton.UseVisualStyleBackColor = true;
            increaseButton.Click += increaseButton_Click;

            decreaseButton.Anchor = AnchorStyles.Top;
            decreaseButton.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            decreaseButton.Location = new Point(650, 291);
            decreaseButton.Margin = new Padding(4);
            decreaseButton.Name = "decreaseButton";
            decreaseButton.Size = new Size(243, 51);
            decreaseButton.TabIndex = 20;
            decreaseButton.Text = "-";
            decreaseButton.UseVisualStyleBackColor = true;
            decreaseButton.Click += decreaseButton_Click;

            cantitateLabel.Anchor = AnchorStyles.Top;
            cantitateLabel.AutoSize = true;
            cantitateLabel.Font = new Font("Arial", 14F, FontStyle.Bold);
            cantitateLabel.Location = new Point(370, 184);
            cantitateLabel.Margin = new Padding(4, 0, 4, 0);
            cantitateLabel.Name = "cantitateLabel";
            cantitateLabel.Size = new Size(157, 38);
            cantitateLabel.TabIndex = 3;
            cantitateLabel.Text = "Cantitate";
            cantitateLabel.Click += cantitateLabel_Click;

            produseLabel.Anchor = AnchorStyles.Top;
            produseLabel.AutoSize = true;
            produseLabel.Font = new Font("Arial Black", 14.1428576F, FontStyle.Bold, GraphicsUnit.Point, 0);
            produseLabel.Location = new Point(1287, 44);
            produseLabel.Margin = new Padding(4, 0, 4, 0);
            produseLabel.Name = "produseLabel";
            produseLabel.Size = new Size(197, 46);
            produseLabel.TabIndex = 4;
            produseLabel.Text = "PRODUSE";
            produseLabel.Click += produseLabel_Click;

            addButton.Anchor = AnchorStyles.Top;
            addButton.Font = new Font("Arial", 14F, FontStyle.Bold);
            addButton.Location = new Point(370, 364);
            addButton.Margin = new Padding(4);
            addButton.Name = "addButton";
            addButton.Size = new Size(522, 55);
            addButton.TabIndex = 5;
            addButton.Text = "Adaugă produsele pe bon";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;

            finalizeButton.Anchor = AnchorStyles.Top;
            finalizeButton.Font = new Font("Arial Black", 14F, FontStyle.Bold);
            finalizeButton.Location = new Point(370, 1150);
            finalizeButton.Margin = new Padding(4);
            finalizeButton.Name = "finalizeButton";
            finalizeButton.Size = new Size(848, 71);
            finalizeButton.TabIndex = 6;
            finalizeButton.Text = "MARCHEAZĂ";
            finalizeButton.UseVisualStyleBackColor = true;
            finalizeButton.Click += finalizeButton_Click;

            resetButton.Anchor = AnchorStyles.Top;
            resetButton.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            resetButton.Location = new Point(537, 1245);
            resetButton.Margin = new Padding(4);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(528, 63);
            resetButton.TabIndex = 6;
            resetButton.Text = "Resetează";
            resetButton.UseVisualStyleBackColor = true;
            resetButton.Click += resetButton_Click;

            receiptListBox.Anchor = AnchorStyles.Top;
            receiptListBox.FormattingEnabled = true;
            receiptListBox.ItemHeight = 30;
            receiptListBox.Location = new Point(370, 468);
            receiptListBox.Margin = new Padding(4);
            receiptListBox.Name = "receiptListBox";
            receiptListBox.Size = new Size(848, 484);
            receiptListBox.TabIndex = 7;
            receiptListBox.SelectedIndexChanged += receiptListBox_SelectedIndexChanged;
            receiptListBox.DragDrop += receiptListBox_DragDrop;
            receiptListBox.DragOver += receiptListBox_DragOver;
            receiptListBox.MouseDown += receiptListBox_MouseDown;

            totalLabel.Anchor = AnchorStyles.Top;
            totalLabel.AutoSize = true;
            totalLabel.Font = new Font("Arial Black", 16.1428585F, FontStyle.Bold);
            totalLabel.Location = new Point(370, 1066);
            totalLabel.Margin = new Padding(4, 0, 4, 0);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new Size(140, 54);
            totalLabel.TabIndex = 8;
            totalLabel.Text = "Total:";

            totalAmountLabel.Anchor = AnchorStyles.Top;
            totalAmountLabel.AutoSize = true;
            totalAmountLabel.Font = new Font("Arial Black", 16.1428585F, FontStyle.Bold);
            totalAmountLabel.Location = new Point(501, 1066);
            totalAmountLabel.Margin = new Padding(4, 0, 4, 0);
            totalAmountLabel.Name = "totalAmountLabel";
            totalAmountLabel.Size = new Size(48, 54);
            totalAmountLabel.TabIndex = 9;
            totalAmountLabel.Text = "0";

            cashRadioButton.Anchor = AnchorStyles.Top;
            cashRadioButton.AutoSize = true;
            cashRadioButton.BackColor = SystemColors.ButtonHighlight;
            cashRadioButton.Font = new Font("Arial", 14F);
            cashRadioButton.Location = new Point(409, 1000);
            cashRadioButton.Name = "cashRadioButton";
            cashRadioButton.Size = new Size(118, 42);
            cashRadioButton.TabIndex = 11;
            cashRadioButton.TabStop = true;
            cashRadioButton.Text = "Cash";
            cashRadioButton.UseVisualStyleBackColor = false;

            cardRadioButton.Anchor = AnchorStyles.Top;
            cardRadioButton.AutoSize = true;
            cardRadioButton.BackColor = SystemColors.ButtonHighlight;
            cardRadioButton.Font = new Font("Arial", 14F);
            cardRadioButton.Location = new Point(757, 1000);
            cardRadioButton.Name = "cardRadioButton";
            cardRadioButton.Size = new Size(112, 42);
            cardRadioButton.TabIndex = 12;
            cardRadioButton.TabStop = true;
            cardRadioButton.Text = "Card";
            cardRadioButton.UseVisualStyleBackColor = false;

            protocolRadioButton.Anchor = AnchorStyles.Top;
            protocolRadioButton.AutoSize = true;
            protocolRadioButton.BackColor = SystemColors.ButtonHighlight;
            protocolRadioButton.Font = new Font("Arial", 14F);
            protocolRadioButton.Location = new Point(1041, 1000);
            protocolRadioButton.Name = "protocolRadioButton";
            protocolRadioButton.Size = new Size(159, 42);
            protocolRadioButton.TabIndex = 13;
            protocolRadioButton.TabStop = true;
            protocolRadioButton.Text = "Protocol";
            protocolRadioButton.UseVisualStyleBackColor = false;

            button1.Anchor = AnchorStyles.Top;
            button1.Location = new Point(367, 985);
            button1.Name = "button1";
            button1.Size = new Size(848, 73);
            button1.TabIndex = 20;
            button1.UseVisualStyleBackColor = true;

            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2922, 1671);
            Controls.Add(splitContainer1);
            Margin = new Padding(4);
            Name = "vanzari";
            Text = "Vânzări";
            Load += vanzari_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        private void vanzari_Load(object sender, EventArgs e)
        {
            LoadProduseFlowLayoutPanel();
        }

        private void LoadProduseFlowLayoutPanel()
        {
            string connectionString = @"Data Source=D:\Projects\AventuraPAY\DB\aventuraDB.db;Version=3;";
            string query = "SELECT produs, categoria FROM produse";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            var produseList = new List<Tuple<string, string>>();
                            while (reader.Read())
                            {
                                string produs = reader["produs"].ToString();
                                string categoria = reader["categoria"].ToString();
                                produseList.Add(new Tuple<string, string>(produs, categoria));
                            }

                            produseFlowLayoutPanel.Controls.Clear();

                            foreach (var categorie in new[] { "park", "bar" })
                            {
                                foreach (var produs in produseList.Where(p => p.Item2.Equals(categorie, StringComparison.OrdinalIgnoreCase)))
                                {
                                    string iconPath = GetIconPathForCategory(produs.Item2);

                                    Panel productPanel = new Panel
                                    {
                                        Size = new Size(250, 170),
                                        Margin = new Padding(10),
                                        BorderStyle = BorderStyle.FixedSingle
                                    };

                                    PictureBox productPictureBox = new PictureBox
                                    {
                                        Image = Image.FromFile(iconPath),
                                        SizeMode = PictureBoxSizeMode.StretchImage,
                                        Size = new Size(50, 50),
                                        Location = new Point(100, 20)
                                    };

                                    CheckBox productCheckBox = new CheckBox
                                    {
                                        Text = produs.Item1,
                                        Location = new Point(10, 110),
                                        AutoSize = true
                                    };

                                    productPanel.Controls.Add(productPictureBox);
                                    productPanel.Controls.Add(productCheckBox);
                                    produseFlowLayoutPanel.Controls.Add(productPanel);

                                    productCheckBox.CheckedChanged += (s, e) =>
                                    {
                                        if (productCheckBox.Checked)
                                        {
                                            foreach (Control control in produseFlowLayoutPanel.Controls)
                                            {
                                                if (control is Panel panel)
                                                {
                                                    foreach (Control subControl in panel.Controls)
                                                    {
                                                        if (subControl is CheckBox checkBox && checkBox != productCheckBox)
                                                        {
                                                            checkBox.Checked = false;
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    };
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }

        private string GetIconPathForCategory(string categoria)
        {
            if (categoria.Equals("park", StringComparison.OrdinalIgnoreCase))
            {
                return @"D:\Projects\AventuraPAY\icons\parc.png";
            }
            else if (categoria.Equals("bar", StringComparison.OrdinalIgnoreCase))
            {
                return @"D:\Projects\AventuraPAY\icons\bar.png";
            }
            else
            {
                return @"D:\Projects\AventuraPAY\icons\default.png";
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string produs = null;
            foreach (Control control in produseFlowLayoutPanel.Controls)
            {
                if (control is Panel panel)
                {
                    foreach (Control subControl in panel.Controls)
                    {
                        if (subControl is CheckBox checkBox && checkBox.Checked)
                        {
                            produs = checkBox.Text;
                            break;
                        }
                    }
                }
                if (produs != null) break;
            }

            if (produs == null || !int.TryParse(cantitateTextBox.Text, out int cantitate))
            {
                MessageBox.Show("Selectați un produs și introduceți o cantitate validă.");
                return;
            }

            string connectionString = @"Data Source=D:\Projects\AventuraPAY\DB\aventuraDB.db;Version=3;";
            string query = "SELECT pret FROM produse WHERE produs = @produs";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@produs", produs);
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                double pret = Convert.ToDouble(reader["pret"]);
                                double totalPret = pret * cantitate;
                                totalAmount += totalPret;

                                receiptListBox.Items.Add($"{cantitate} x {produs} X {pret} Lei = {totalPret} Lei");
                                totalAmountLabel.Text = totalAmount.ToString("F2");

                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
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

            SaveReceipt();
            PrintReceipt();
        }

        private void PrintReceipt()
        {
            if (!cashRadioButton.Checked && !cardRadioButton.Checked && !protocolRadioButton.Checked)
            {
                MessageBox.Show("Te rugăm să selectezi o metodă de plată (Cash, Card sau Protocol) înainte de a imprima.", "Metodă de plată necesară", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += new PrintPageEventHandler(printDocument_PrintPage);

            try
            {
                printDocument.Print();
                ResetForm(); // Resetare formular dacă printul a reușit
            }
            catch (Exception ex)
            {
                MessageBox.Show($"A apărut o eroare la imprimare: {ex.Message}", "Eroare de imprimare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            float printableWidth = 190; // Latimea maxima de printare pentru wrap text !!!

            float xPosCenter = printableWidth / 2;

            string header = "Săpânța Aventura Parc";
            using (Font font = new Font("Segoe UI", 11, FontStyle.Bold))
            {
                e.Graphics.DrawString(header, font, Brushes.Black, new PointF(xPosCenter - e.Graphics.MeasureString(header, font).Width / 2, 50));

                string subHeader = "Bon Nefiscal";
                using (Font subFont = new Font("Segoe UI", 10))
                {
                    e.Graphics.DrawString(subHeader, subFont, Brushes.Black, new PointF(xPosCenter - e.Graphics.MeasureString(subHeader, subFont).Width / 2, 70));
                }

                using (Font infoFont = new Font("Segoe UI", 9))
                {
                    e.Graphics.DrawString($"Nota de plată nr: {receiptId}", infoFont, Brushes.Black, new PointF(10, 90));
                    e.Graphics.DrawString($"Client: {numetextBox.Text}", infoFont, Brushes.Black, new PointF(10, 110));
                    e.Graphics.DrawString($"Data: {DateTime.Now:yyyy-MM-dd HH:mm:ss}", infoFont, Brushes.Black, new PointF(10, 130));
                }

                float yPos = 150;
                e.Graphics.DrawString(new string('-', 48), new Font("Segoe UI", 8), Brushes.Black, new PointF(10, yPos));
                yPos += 15;

                using (Font detailFont = new Font("Segoe UI", 9))
                {
                    foreach (var item in receiptListBox.Items)
                    {
                        string text = item.ToString();
                        string[] parts = text.Split(new string[] { " X " }, StringSplitOptions.None);

                        if (parts.Length == 2)
                        {
                            e.Graphics.DrawString(parts[0].Trim(), detailFont, Brushes.Black, new PointF(10, yPos));
                            yPos += 15;

                            string[] priceParts = parts[1].Trim().Split(new string[] { " = " }, StringSplitOptions.None);
                            if (priceParts.Length == 2)
                            {
                                string priceLine = priceParts[0].Trim();
                                string totalLine = "= " + priceParts[1].Trim();

                                e.Graphics.DrawString(priceLine, detailFont, Brushes.Black, new PointF(10, yPos));

                                float priceWidth = e.Graphics.MeasureString(priceLine, detailFont).Width;
                                float totalWidth = e.Graphics.MeasureString(totalLine, detailFont).Width;
                                float separatorWidth = printableWidth - priceWidth - totalWidth - 20; // spațiu margine

                                string separator = new string('-', (int)(separatorWidth / e.Graphics.MeasureString("-", detailFont).Width));
                                e.Graphics.DrawString(separator, detailFont, Brushes.Black, new PointF(10 + priceWidth + 5, yPos));

                                e.Graphics.DrawString(totalLine, detailFont, Brushes.Black, new PointF(printableWidth - totalWidth - 10, yPos));
                            }
                        }
                        else
                        {
                            e.Graphics.DrawString(text, detailFont, Brushes.Black, new PointF(10, yPos));
                        }

                        yPos += 30;
                        // Separator între produse
                        e.Graphics.DrawString(new string('-', 48), new Font("Segoe UI", 8), Brushes.Black, new PointF(10, yPos));
                        yPos += 15;
                    }
                }

                yPos += 15;
                e.Graphics.DrawString(new string('-', 48), new Font("Segoe UI", 8), Brushes.Black, new PointF(10, yPos));
                yPos += 15;

                using (Font totalFont = new Font("Segoe UI", 8, FontStyle.Bold))
                {
                    e.Graphics.DrawString($"Total: {totalAmountLabel.Text} Lei", totalFont, Brushes.Black, new PointF(10, yPos));
                    yPos += 20;
                    string paymentMethod = cashRadioButton.Checked ? "Cash" : cardRadioButton.Checked ? "Card" : protocolRadioButton.Checked ? "Protocol" : string.Empty;
                    e.Graphics.DrawString("Metoda de plată: " + paymentMethod, totalFont, Brushes.Black, new PointF(10, yPos));
                }

                yPos += 10;
                e.Graphics.DrawString(new string('-', 48), new Font("Segoe UI", 8), Brushes.Black, new PointF(10, yPos));
                yPos += 15;

                yPos += 10;
                string footer = "Aventura te așteaptă! 0742-764041";
                using (Font footerFont = new Font("Segoe UI", 7, FontStyle.Bold))
                {
                    e.Graphics.DrawString(footer, footerFont, Brushes.Black, new PointF(xPosCenter - e.Graphics.MeasureString(footer, footerFont).Width / 2, yPos));
                }
                yPos += 35;
                e.Graphics.DrawString(new string('-', 48), new Font("Segoe UI", 8), Brushes.Black, new PointF(10, yPos));
                yPos += 45;
            }
        }

        private void SaveReceipt()
        {
            string produse = string.Join(", ", receiptListBox.Items.Cast<string>());
            string metodaPlata = cashRadioButton.Checked ? "Cash" : cardRadioButton.Checked ? "Card" : protocolRadioButton.Checked ? "Protocol" : string.Empty;
            string data = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            string clientDetalii = numetextBox.Text;

            string connectionString = @"Data Source=D:\Projects\AventuraPAY\DB\aventuraDBnote.db;Version=3;Default Timeout=30000;";
            string query = @"
        INSERT INTO notedeplata (Data, Produse, Total, MetodaPlata, DetaliiClient, User) 
        VALUES (@Data, @Produse, @Total, @MetodaPlata, @DetaliiClient, @User);
        SELECT last_insert_rowid();";

            string lastLoggedInUser = GetLastLoggedInUser();

            int retryCount = 0;
            const int maxRetries = 5;
            bool success = false;

            while (!success && retryCount < maxRetries)
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        using (SQLiteCommand pragmaCmd = new SQLiteCommand("PRAGMA journal_mode=WAL; PRAGMA busy_timeout=30000;", connection))
                        {
                            pragmaCmd.ExecuteNonQuery();
                        }

                        using (SQLiteTransaction transaction = connection.BeginTransaction())
                        {
                            using (SQLiteCommand command = new SQLiteCommand(query, connection, transaction))
                            {
                                command.Parameters.AddWithValue("@Data", data);
                                command.Parameters.AddWithValue("@Produse", produse);
                                command.Parameters.AddWithValue("@Total", totalAmount);
                                command.Parameters.AddWithValue("@MetodaPlata", metodaPlata);
                                command.Parameters.AddWithValue("@DetaliiClient", clientDetalii);
                                command.Parameters.AddWithValue("@User", lastLoggedInUser); // Use the last logged-in username - TRICK personal:)

                                command.ExecuteNonQuery();

                                using (SQLiteCommand lastIdCommand = new SQLiteCommand("SELECT last_insert_rowid();", connection, transaction))
                                {
                                    receiptId = Convert.ToInt32(lastIdCommand.ExecuteScalar());
                                }
                            }
                            transaction.Commit();
                        }
                        success = true;
                    }
                    catch (SQLiteException ex)
                    {
                        if (ex.Message.Contains("database is locked"))
                        {
                            ++retryCount;
                            System.Threading.Thread.Sleep(1000);
                        }
                        else
                        {
                            MessageBox.Show($"A apărut o eroare: {ex.Message}");
                            break;
                        }
                    }
                }
            }

            if (!success)
            {
                MessageBox.Show("Nu s-a putut salva bonul din cauza blocării bazei de date.");
            }
        }

        private string GetLastLoggedInUser()
        {
            string lastLoggedInUser = string.Empty;
            string connectionString = @"Data Source=D:\Projects\AventuraPAY\DB\aventuraDB.db;Version=3;";
            string query = "SELECT username FROM login_attempts ORDER BY login_time DESC LIMIT 1";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        lastLoggedInUser = (string)command.ExecuteScalar();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }

            return lastLoggedInUser;
        }

        public static List<string> WrapText(string text, Font font, float maxWidth)
        {
            List<string> lines = new List<string>();
            string[] words = text.Split(' ');
            string currentLine = string.Empty;

            foreach (var word in words)
            {
                string testLine = currentLine.Length == 0 ? word : currentLine + " " + word;
                float testWidth = TextRenderer.MeasureText(testLine, font).Width;

                if (testWidth > maxWidth)
                {
                    if (!string.IsNullOrEmpty(currentLine))
                    {
                        lines.Add(currentLine);
                        currentLine = word;
                    }
                    else
                    {
                        lines.Add(testLine);
                        currentLine = string.Empty;
                    }
                }
                else
                {
                    currentLine = testLine;
                }
            }

            if (!string.IsNullOrEmpty(currentLine))
            {
                lines.Add(currentLine);
            }

            return lines;
        }

        private void backButton_Click(object sender, EventArgs e)
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

        private void editNotesButton_Click(object sender, EventArgs e)
        {
            EditNotesForm editNotesForm = new EditNotesForm(this);
            editNotesForm.Show();
            this.Hide();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void ResetForm()
        {
            clientNameAddedToReceipt = false;
            numetextBox.Clear();
            cantitateTextBox.Clear();
            receiptListBox.Items.Clear();
            totalAmount = 0;
            totalAmountLabel.Text = "0";
            cashRadioButton.Checked = false;
            cardRadioButton.Checked = false;
            protocolRadioButton.Checked = false;
            receiptId = 0;
            foreach (Control control in produseFlowLayoutPanel.Controls)
            {
                if (control is Panel panel)
                {
                    foreach (Control subControl in panel.Controls)
                    {
                        if (subControl is CheckBox checkBox)
                        {
                            checkBox.Checked = false;
                        }
                    }
                }
            }
        }

        private void receiptListBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (receiptListBox.Items.Count == 0) return;

            int index = receiptListBox.IndexFromPoint(e.X, e.Y);
            if (index >= 0)
            {
                receiptListBox.DoDragDrop(receiptListBox.Items[index], DragDropEffects.Move);
            }
        }

        private void receiptListBox_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void receiptListBox_DragDrop(object sender, DragEventArgs e)
        {
            Point point = receiptListBox.PointToClient(new Point(e.X, e.Y));
            int index = receiptListBox.IndexFromPoint(point);
            if (index < 0) index = receiptListBox.Items.Count - 1;
            object data = e.Data.GetData(typeof(string));
            receiptListBox.Items.Remove(data);
            receiptListBox.Items.Insert(index, data);

        }

        private void generateClosureButton_Click(object sender, EventArgs e)
        {
            ShowClosureReportForm();
        }

        private void increaseButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(cantitateTextBox.Text, out int cantitate))
            {
                if (cantitate < 30)
                {
                    ++cantitate;
                    cantitateTextBox.Text = cantitate.ToString();
                }
            }
            else
            {
                cantitateTextBox.Text = "1";
            }
        }

        private void decreaseButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(cantitateTextBox.Text, out int cantitate))
            {
                if (cantitate > 1)
                {
                    --cantitate;
                    cantitateTextBox.Text = cantitate.ToString();
                }
            }
            else
            {
                cantitateTextBox.Text = "1";
            }
        }

        private void ShowClosureReportForm()
        {
            ClosureReportForm closureReportForm = new ClosureReportForm();
            closureReportForm.ShowDialog();
        }

        private void HideAdminButtons()
        {
            editNotesButton.Visible = false;
            backButton.Visible = false;
            // administrareProduseButton.Visible = false;
            // administrareUtilizatoriButton.Visible = false;
            // statisticiButton.Visible = false;
        }

        private bool CheckIfUserIsAdmin(string username)
        {
            List<string> adminUsers = new List<string> { "admin", "administrator" };

            return adminUsers.Contains(username, StringComparer.OrdinalIgnoreCase);
        }

        public partial class ClosureReportForm : Form
        {
            private Label titleLabel;
            private Label closureDetailsLabel;
            private Label separatorLabel1;
            private Label separatorLabel2;
            private Button closeButton;
            private Button printClosureButton;

            public ClosureReportForm()
            {
                InitializeComponent();
            }

            private void InitializeComponent()
            {
                titleLabel = new Label();
                closureDetailsLabel = new Label();
                separatorLabel1 = new Label();
                separatorLabel2 = new Label();
                closeButton = new Button();
                printClosureButton = new Button();
                SuspendLayout();

                titleLabel.AutoSize = true;
                titleLabel.Font = new Font("Arial", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
                titleLabel.Location = new Point(325, 20);
                titleLabel.Name = "titleLabel";
                titleLabel.Size = new Size(300, 32);
                titleLabel.Text = "Săpânța Aventura Parc";
                titleLabel.TextAlign = ContentAlignment.MiddleCenter;

                separatorLabel1.AutoSize = true;
                separatorLabel1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
                separatorLabel1.Location = new Point(20, 60);
                separatorLabel1.Name = "separatorLabel1";
                separatorLabel1.Size = new Size(1000, 24);
                separatorLabel1.Text = new string('-', 100);
                separatorLabel1.TextAlign = ContentAlignment.MiddleCenter;

                closureDetailsLabel.AutoSize = true;
                closureDetailsLabel.Font = new Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
                closureDetailsLabel.Location = new Point(20, 100);
                closureDetailsLabel.Name = "closureDetailsLabel";
                closureDetailsLabel.Size = new Size(1000, 600);
                closureDetailsLabel.TextAlign = ContentAlignment.MiddleLeft;

                separatorLabel2.AutoSize = true;
                separatorLabel2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
                separatorLabel2.Location = new Point(20, 720);
                separatorLabel2.Name = "separatorLabel2";
                separatorLabel2.Size = new Size(1000, 24);
                separatorLabel2.Text = new string('-', 100);
                separatorLabel2.TextAlign = ContentAlignment.MiddleCenter;

                closeButton.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
                closeButton.Location = new Point(450, 760);
                closeButton.Name = "closeButton";
                closeButton.Size = new Size(200, 50);
                closeButton.Text = "Close";
                closeButton.UseVisualStyleBackColor = true;
                closeButton.Click += closeButton_Click;

                printClosureButton.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
                printClosureButton.Location = new Point(100, 760);
                printClosureButton.Name = "printClosureButton";
                printClosureButton.Size = new Size(300, 50);
                printClosureButton.Text = "Printează Închidere";
                printClosureButton.UseVisualStyleBackColor = true;
                printClosureButton.Click += printClosureButton_Click;

                AutoScaleDimensions = new SizeF(12F, 30F);
                AutoScaleMode = AutoScaleMode.Font;
                ClientSize = new Size(1050, 850);
                Controls.Add(titleLabel);
                Controls.Add(separatorLabel1);
                Controls.Add(closureDetailsLabel);
                Controls.Add(separatorLabel2);
                Controls.Add(closeButton);
                Controls.Add(printClosureButton);
                Name = "ClosureReportForm";
                Text = "Closure Report";
                Load += ClosureReportForm_Load;
                ResumeLayout(false);
                PerformLayout();
            }

            private void ClosureReportForm_Load(object sender, EventArgs e)
            {
                LoadClosureReportDetails();
            }

            private void LoadClosureReportDetails()
            {
                string connectionString = @"Data Source=D:\Projects\AventuraPAY\DB\aventuraDBnote.db;Version=3;";
                string query = @"
                        SELECT MetodaPlata, SUM(Total) as TotalIncasari, User 
                        FROM notedeplata 
                        WHERE DATE(Data) = DATE('now')
                        GROUP BY MetodaPlata, User";

                DataTable closureData = new DataTable();
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        using (SQLiteCommand command = new SQLiteCommand(query, connection))
                        {
                            SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
                            adapter.Fill(closureData);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred: {ex.Message}");
                        return;
                    }
                }

                var groupedData = closureData.AsEnumerable()
                    .GroupBy(row => row.Field<string>("User"))
                    .Select(g => new
                    {
                        User = g.Key,
                        Totals = g.GroupBy(row => row.Field<string>("MetodaPlata"))
                                  .Select(mg => new
                                  {
                                      Method = mg.Key,
                                      Total = mg.Sum(row => row.Field<double>("TotalIncasari"))
                                  })
                    }).ToList();

                string closureReport = "Inchidere Incasari\n\n";
                double grandTotal = 0;

                foreach (var group in groupedData)
                {
                    closureReport += $"Operator: {group.User}\n";
                    foreach (var methodGroup in group.Totals)
                    {
                        closureReport += $"{methodGroup.Method}: {methodGroup.Total:F2} Lei\n";
                        grandTotal += methodGroup.Total;
                    }
                    closureReport += "\n";
                }
                closureReport += new string('-', 48) + "\n";
                closureReport += $"Total General: {grandTotal:F2} Lei\n";
                closureDetailsLabel.Text = closureReport;
            }


            private void closeButton_Click(object sender, EventArgs e)
            {
                this.Close();
            }

            private void printClosureButton_Click(object sender, EventArgs e)
            {
                PrintClosureReport();
            }

            private void PrintClosureReport()
            {
                PrintDocument printDocument = new PrintDocument();
                printDocument.PrintPage += (sender, e) => PrintClosureReportPage(e, closureDetailsLabel.Text);

                PrintDialog printDialog = new PrintDialog();
                printDialog.Document = printDocument;
                if (printDialog.ShowDialog() == DialogResult.OK)
                {
                    printDocument.Print();
                }
            }

            private void PrintClosureReportPage(PrintPageEventArgs e, string closureReport)
            {
                float printableWidth = 200;
                float productPrintableWidth = 200;

                float xPosCenter = printableWidth / 2;

                string header = "Săpânța Aventura Parc";
                using (Font font = new Font("Segoe UI", 10, FontStyle.Bold))
                {
                    e.Graphics.DrawString(header, font, Brushes.Black, new PointF(xPosCenter - e.Graphics.MeasureString(header, font).Width / 2, 50));

                    string subHeader = "Bon Nefiscal";
                    using (Font subFont = new Font("Segoe UI", 9))
                    {
                        e.Graphics.DrawString(subHeader, subFont, Brushes.Black, new PointF(xPosCenter - e.Graphics.MeasureString(subHeader, subFont).Width / 2, 70));
                    }

                    using (Font infoFont = new Font("Segoe UI", 9))
                    {
                        e.Graphics.DrawString($"Inchidere Incasari data: {DateTime.Now:yyyy-MM-dd}", infoFont, Brushes.Black, new PointF(10, 90));
                    }

                    float yPos = 110;
                    e.Graphics.DrawString(new string('-', 48), new Font("Segoe UI", 8), Brushes.Black, new PointF(10, yPos));
                    yPos += 15;

                    using (Font detailFont = new Font("Segoe UI", 7))
                    {
                        using (StringReader reader = new StringReader(closureReport))
                        {
                            string line;
                            while ((line = reader.ReadLine()) != null)
                            {
                                var lines = Sales.WrapText(line, detailFont, productPrintableWidth);
                                foreach (var wrappedLine in lines)
                                {
                                    e.Graphics.DrawString(wrappedLine, detailFont, Brushes.Black, new PointF(10, yPos));
                                    yPos += 15;
                                }
                            }
                        }
                    }

                    yPos += 15;
                    e.Graphics.DrawString(new string('-', 48), new Font("Segoe UI", 8), Brushes.Black, new PointF(10, yPos));
                    yPos += 15;

                    string footer = "Aventura te așteaptă! 0742-764041";
                    using (Font footerFont = new Font("Segoe UI", 7, FontStyle.Bold))
                    {
                        e.Graphics.DrawString(footer, footerFont, Brushes.Black, new PointF(xPosCenter - e.Graphics.MeasureString(footer, footerFont).Width / 2, yPos));
                    }

                    yPos += 35;
                    e.Graphics.DrawString(new string('-', 48), new Font("Segoe UI", 8), Brushes.Black, new PointF(10, yPos));
                    yPos += 45;
                }
            }

        }

        public partial class ReceiptForm : Form
        {
            private Label clientNameLabel;
            private Label dateLabel;
            private ListBox itemsListBox;
            private Label totalLabel;
            private Label label1;
            private Label receiptIdLabel;
            private Button printButton;
            private string paymentMethod;

            public ReceiptForm()
            {
                InitializeComponent();
            }

            private void InitializeComponent()
            {
                clientNameLabel = new Label();
                dateLabel = new Label();
                itemsListBox = new ListBox();
                totalLabel = new Label();
                label1 = new Label();
                receiptIdLabel = new Label();
                printButton = new Button();
                SuspendLayout();

                clientNameLabel.AutoSize = true;
                clientNameLabel.Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point, 0);
                clientNameLabel.Location = new Point(18, 151);
                clientNameLabel.Margin = new Padding(4, 0, 4, 0);
                clientNameLabel.Name = "clientNameLabel";
                clientNameLabel.Size = new Size(168, 32);
                clientNameLabel.TabIndex = 0;
                clientNameLabel.Text = "Client: [Nume]";

                dateLabel.AutoSize = true;
                dateLabel.Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point, 0);
                dateLabel.Location = new Point(305, 151);
                dateLabel.Margin = new Padding(4, 0, 4, 0);
                dateLabel.Name = "dateLabel";
                dateLabel.Size = new Size(138, 32);
                dateLabel.TabIndex = 1;
                dateLabel.Text = "Data: [Dată]";

                itemsListBox.FormattingEnabled = true;
                itemsListBox.ItemHeight = 30;
                itemsListBox.Location = new Point(18, 187);
                itemsListBox.Margin = new Padding(4, 6, 4, 6);
                itemsListBox.Name = "itemsListBox";
                itemsListBox.Size = new Size(739, 364);
                itemsListBox.TabIndex = 2;

                totalLabel.AutoSize = true;
                totalLabel.Font = new Font("Segoe UI Black", 9.857143F, FontStyle.Bold, GraphicsUnit.Point, 0);
                totalLabel.Location = new Point(18, 570);
                totalLabel.Margin = new Padding(4, 0, 4, 0);
                totalLabel.Name = "totalLabel";
                totalLabel.Size = new Size(174, 32);
                totalLabel.TabIndex = 3;
                totalLabel.Text = "Total: [Suma]";

                label1.AutoSize = true;
                label1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
                label1.Location = new Point(206, 34);
                label1.Name = "label1";
                label1.Size = new Size(334, 38);
                label1.TabIndex = 4;
                label1.Text = "Săpânța Aventura Parc";

                receiptIdLabel.AutoSize = true;
                receiptIdLabel.Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point, 0);
                receiptIdLabel.Location = new Point(18, 110);
                receiptIdLabel.Margin = new Padding(4, 0, 4, 0);
                receiptIdLabel.Name = "receiptIdLabel";
                receiptIdLabel.Size = new Size(167, 32);
                receiptIdLabel.TabIndex = 1;
                receiptIdLabel.Text = "Nr. Bon: [ID]";

                printButton.Location = new Point(18, 615);
                printButton.Name = "printButton";
                printButton.Size = new Size(180, 45);
                printButton.TabIndex = 5;
                printButton.Text = "Printează Nota de Plată";
                printButton.UseVisualStyleBackColor = true;
                printButton.Click += new EventHandler(printButton_Click);

                AutoScaleDimensions = new SizeF(12F, 30F);
                AutoScaleMode = AutoScaleMode.Font;
                ClientSize = new Size(768, 953);
                Controls.Add(printButton);
                Controls.Add(label1);
                Controls.Add(totalLabel);
                Controls.Add(itemsListBox);
                Controls.Add(receiptIdLabel);
                Controls.Add(dateLabel);
                Controls.Add(clientNameLabel);
                Margin = new Padding(4, 6, 4, 6);
                Name = "ReceiptForm";
                Text = "Bon de plată";
                ResumeLayout(false);
                PerformLayout();
            }

            public void SetReceiptDetails(string clientName, string date, string[] items, double total, string paymentMethod, int receiptId, string username)
            {
                clientNameLabel.Text = $"Client: {clientName}";
                dateLabel.Text = $"Data: {date}";
                itemsListBox.Items.Clear();
                itemsListBox.Items.AddRange(items);
                totalLabel.Text = $"Total: {total:F2} Lei";
                receiptIdLabel.Text = $"Nr. Bon: {receiptId}";
                this.paymentMethod = paymentMethod;
            }

            private void printButton_Click(object sender, EventArgs e)
            {
                PrintDialog printDialog = new PrintDialog();
                PrintDocument printDocument = new PrintDocument();
                printDocument.PrintPage += new PrintPageEventHandler(printDocument_PrintPage);
                printDialog.Document = printDocument;

                if (printDialog.ShowDialog() == DialogResult.OK)
                {
                    printDocument.Print();
                    DialogResult = DialogResult.OK;
                    ((Sales)this.Owner).ResetForm();
                }
            }

            private void printDocument_PrintPage(object sender, PrintPageEventArgs e)
            {
                float printableWidth = 200;
                float productPrintableWidth = 200;

                float xPosCenter = printableWidth / 5;

                string header = label1.Text;
                using (Font font = new Font("Segoe UI", 9, FontStyle.Bold))
                {
                    e.Graphics.DrawString(header, font, Brushes.Black, new PointF(xPosCenter - e.Graphics.MeasureString(header, font).Width / 2, 50));

                    string subHeader = "Bon Nefiscal";
                    using (Font subFont = new Font("Segoe UI", 8))
                    {
                        e.Graphics.DrawString(subHeader, subFont, Brushes.Black, new PointF(xPosCenter - e.Graphics.MeasureString(subHeader, subFont).Width / 2, 70));
                    }

                    using (Font infoFont = new Font("Segoe UI", 7))
                    {
                        e.Graphics.DrawString(receiptIdLabel.Text, infoFont, Brushes.Black, new PointF(10, 90));
                        e.Graphics.DrawString(clientNameLabel.Text, infoFont, Brushes.Black, new PointF(10, 110));
                        e.Graphics.DrawString(dateLabel.Text, infoFont, Brushes.Black, new PointF(10, 130));
                    }

                    float yPos = 150;
                    e.Graphics.DrawString(new string('-', 48), new Font("Segoe UI", 8), Brushes.Black, new PointF(10, yPos));
                    yPos += 15;

                    using (Font itemFont = new Font("Segoe UI", 9))
                    {
                        foreach (var item in itemsListBox.Items)
                        {
                            string text = item.ToString();
                            var lines = Sales.WrapText(text, itemFont, maxWidth: productPrintableWidth);
                            foreach (var line in lines)
                            {
                                e.Graphics.DrawString(line, itemFont, Brushes.Black, new PointF(2, yPos));
                                yPos += 15;
                            }
                        }
                    }

                    yPos += 15;
                    e.Graphics.DrawString(new string('-', 48), new Font("Segoe UI", 8), Brushes.Black, new PointF(10, yPos));
                    yPos += 15;

                    using (Font totalFont = new Font("Segoe UI", 8, FontStyle.Bold))
                    {
                        e.Graphics.DrawString($"Total: {totalLabel.Text}", totalFont, Brushes.Black, new PointF(10, yPos));
                        yPos += 20;
                        e.Graphics.DrawString("Metoda de plată: " + paymentMethod, totalFont, Brushes.Black, new PointF(10, yPos));
                    }

                    yPos += 30;
                    string footer = "Aventura te așteaptă! 0742-764041";
                    using (Font footerFont = new Font("Segoe UI", 7, FontStyle.Bold))
                    {
                        e.Graphics.DrawString(footer, footerFont, Brushes.Black, new PointF(xPosCenter - e.Graphics.MeasureString(footer, footerFont).Width / 2, yPos));
                    }

                    yPos += 35;
                    e.Graphics.DrawString(new string('-', 48), new Font("Segoe UI", 8), Brushes.Black, new PointF(10, yPos));
                    yPos += 45;
                }
            }

        }

        private ListBox receiptListBox;
        private Button button5;
        private Button button1;
    }
}
