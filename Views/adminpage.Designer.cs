using System.Data.SQLite;
using System.Data;

namespace AventuraPAY
{
    public partial class adminPage : Form
    {
        private System.ComponentModel.IContainer components = null;
        private TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Timer updateTimer;
        private DataTable receiptsTable;

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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminPage));
            splitter1 = new Splitter();
            pictureBox1 = new PictureBox();
            button0 = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            updateTimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();

            splitter1.Location = new Point(0, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(485, 1519);
            splitter1.TabIndex = 1;
            splitter1.TabStop = false;

            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(81, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(320, 305);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;

            button0.Font = new Font("Arial", 14F, FontStyle.Bold);
            button0.ForeColor = Color.FromArgb(0, 64, 0);
            button0.Location = new Point(42, 394);
            button0.Name = "button0";
            button0.Size = new Size(389, 69);
            button0.TabIndex = 3;
            button0.Text = "Vânzări";
            button0.UseVisualStyleBackColor = true;
            button0.Click += Button0_Click;

            button1.Font = new Font("Arial", 14F, FontStyle.Bold);
            button1.ForeColor = Color.FromArgb(0, 64, 0);
            button1.Location = new Point(42, 526);
            button1.Name = "button1";
            button1.Size = new Size(389, 69);
            button1.TabIndex = 4;
            button1.Text = "Administrare Utilizatori";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Button1_Click;

            button2.Font = new Font("Arial", 14F, FontStyle.Bold);
            button2.ForeColor = Color.FromArgb(0, 64, 0);
            button2.Location = new Point(42, 656);
            button2.Name = "button2";
            button2.Size = new Size(389, 69);
            button2.TabIndex = 5;
            button2.Text = "Administrare Produse";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Button2_Click;

            button3.Font = new Font("Arial", 14F, FontStyle.Bold);
            button3.ForeColor = Color.FromArgb(0, 64, 0);
            button3.Location = new Point(42, 788);
            button3.Name = "button3";
            button3.Size = new Size(389, 69);
            button3.TabIndex = 6;
            button3.Text = "Statistici";
            button3.UseVisualStyleBackColor = true;
            button3.Click += Button3_Click;

            button4.Font = new Font("Arial", 14F, FontStyle.Bold);
            button4.ForeColor = Color.FromArgb(0, 64, 0);
            button4.Location = new Point(42, 923);
            button4.Name = "button4";
            button4.Size = new Size(389, 69);
            button4.TabIndex = 7;
            button4.Text = "Utile";
            button4.UseVisualStyleBackColor = true;
            button4.Click += Button4_Click;

            button5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button5.BackColor = Color.FromArgb(0, 64, 0);
            button5.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.White;
            button5.Location = new Point(42, 1402);
            button5.Name = "button5";
            button5.Size = new Size(389, 69);
            button5.TabIndex = 8;
            button5.Text = "LOGOUT";
            button5.UseVisualStyleBackColor = false;
            button5.Click += Button5_Click;

            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Location = new Point(911, 136);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 20;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.Size = new Size(1552, 797);
            tableLayoutPanel1.TabIndex = 9;

            updateTimer.Interval = 1000;
            updateTimer.Tick += UpdateTimer_Tick;

            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2706, 1519);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(button0);
            Controls.Add(pictureBox1);
            Controls.Add(splitter1);
            Margin = new Padding(4);
            Name = "adminPage";
            Text = "Admin";
            Load += AdminPage_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        private Splitter splitter1;
        private PictureBox pictureBox1;
        private Button button0;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;

        public TableLayoutPanel TableLayoutPanel1
        {
            get { return tableLayoutPanel1; }
            internal set { tableLayoutPanel1 = value; }
        }

        private void AdminPage_Load(object sender, EventArgs e)
        {
            InitializeTableLayoutPanel();
            LoadReceiptsData();
            updateTimer.Start();
        }

        private void InitializeTableLayoutPanel()
        {
            tableLayoutPanel1.Controls.Clear();
            tableLayoutPanel1.RowStyles.Clear();
            tableLayoutPanel1.RowCount = 1;

            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.Controls.Add(new Label() { Text = "Bon", Font = new Font("Arial", 12F, FontStyle.Bold), AutoSize = true }, 0, 0);
            tableLayoutPanel1.Controls.Add(new Label() { Text = "Client", Font = new Font("Arial", 12F, FontStyle.Bold), AutoSize = true }, 1, 0);
            tableLayoutPanel1.Controls.Add(new Label() { Text = "Preț", Font = new Font("Arial", 12F, FontStyle.Bold), AutoSize = true }, 2, 0);
            tableLayoutPanel1.Controls.Add(new Label() { Text = "Timp Rămas", Font = new Font("Arial", 12F, FontStyle.Bold), AutoSize = true }, 3, 0);
        }

        private void LoadReceiptsData()
        {
            string connectionString = @"Data Source=D:\Projects\AventuraPAY\DB\aventuraDBnote.db;Version=3;";
            string query = "SELECT * FROM notedeplata WHERE DATE(Data) = DATE('now') ORDER BY id DESC";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(query, connection);
                    receiptsTable = new DataTable();
                    dataAdapter.Fill(receiptsTable);

                    tableLayoutPanel1.RowCount = receiptsTable.Rows.Count + 1;

                    tableLayoutPanel1.Controls.Clear();
                    InitializeTableLayoutPanel();

                    for (int i = 0; i < receiptsTable.Rows.Count; ++i)
                    {
                        DataRow row = receiptsTable.Rows[i];
                        DateTime dataCreare = DateTime.Parse(row["Data"].ToString());
                        TimeSpan timpulRamas = dataCreare.AddHours(2) - DateTime.Now;

                        string timpulRamasText = timpulRamas.TotalSeconds > 0
                            ? $"{timpulRamas.Hours:D2}:{timpulRamas.Minutes:D2}:{timpulRamas.Seconds:D2}"
                            : "Expirat";

                        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
                        tableLayoutPanel1.Controls.Add(new Label() { Text = row["id"].ToString(), AutoSize = true }, 0, i + 1);
                        tableLayoutPanel1.Controls.Add(new Label() { Text = row["DetaliiClient"].ToString(), AutoSize = true }, 1, i + 1);
                        tableLayoutPanel1.Controls.Add(new Label() { Text = row["Total"].ToString(), AutoSize = true }, 2, i + 1);
                        tableLayoutPanel1.Controls.Add(new Label() { Text = timpulRamasText, AutoSize = true, Name = $"timerLabel{i}" }, 3, i + 1);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"A apărut o eroare: {ex.Message}");
                }
            }
        }

        private void UpdateTimer_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            for (int i = 0; i < receiptsTable.Rows.Count; ++i)
            {
                DataRow row = receiptsTable.Rows[i];
                DateTime dataCreare = DateTime.Parse(row["Data"].ToString());
                TimeSpan timpulRamas = dataCreare.AddHours(2) - now;

                string timpulRamasText = timpulRamas.TotalSeconds > 0
                    ? $"{timpulRamas.Hours:D2}:{timpulRamas.Minutes:D2}:{timpulRamas.Seconds:D2}"
                    : "Expirat";

                Control[] timerLabels = tableLayoutPanel1.Controls.Find($"timerLabel{i}", true);
                if (timerLabels.Length > 0)
                {
                    timerLabels[0].Text = timpulRamasText;
                }
            }
        }

        internal void UpdateReceiptTable(DataTable receiptsTable)
        {
            throw new NotImplementedException();
        }
    }
}
