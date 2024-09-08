using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SQLite;
using Microsoft.PowerBI.Api;

namespace AventuraPAY
{
    partial class statistica : Form
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(statistica));
            splitContainer1 = new SplitContainer();
            button11 = new Button();
            backButton = new Button();
            buttonLogout = new Button();
            pictureBox1 = new PictureBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            button4 = new Button();
            button3 = new Button();
            totalIncasariCard = new Panel();
            totalIncasariLabel = new Label();
            totalIncasariIeriCard = new Panel();
            totalIncasariIeriLabel = new Label();
            percentageChangeCard = new Panel();
            percentageChangeLabel = new Label();
            total7DaysCard = new Panel();
            total7DaysLabel = new Label();
            total7DaysPrevCard = new Panel();
            total7DaysPrevLabel = new Label();
            percentageChange7DaysCard = new Panel();
            percentageChange7DaysLabel = new Label();
            total30DaysCard = new Panel();
            total30DaysLabel = new Label();
            total30DaysPrevCard = new Panel();
            total30DaysPrevLabel = new Label();
            percentageChange30DaysCard = new Panel();
            percentageChange30DaysLabel = new Label();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            totalIncasariCard.SuspendLayout();
            totalIncasariIeriCard.SuspendLayout();
            percentageChangeCard.SuspendLayout();
            total7DaysCard.SuspendLayout();
            total7DaysPrevCard.SuspendLayout();
            percentageChange7DaysCard.SuspendLayout();
            total30DaysCard.SuspendLayout();
            total30DaysPrevCard.SuspendLayout();
            percentageChange30DaysCard.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(button11);
            splitContainer1.Panel1.Controls.Add(backButton);
            splitContainer1.Panel1.Controls.Add(buttonLogout);
            splitContainer1.Panel1.Controls.Add(pictureBox1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(tableLayoutPanel2);
            splitContainer1.Panel2.Controls.Add(tableLayoutPanel1);
            splitContainer1.Size = new Size(2855, 1662);
            splitContainer1.SplitterDistance = 477;
            splitContainer1.TabIndex = 0;
            // 
            // button11
            // 
            button11.Font = new Font("Arial", 14F, FontStyle.Bold);
            button11.ForeColor = Color.FromArgb(0, 64, 0);
            button11.Location = new Point(38, 399);
            button11.Name = "button11";
            button11.Size = new Size(354, 95);
            button11.TabIndex = 2;
            button11.Text = "Statistica Personalizata";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // backButton
            // 
            backButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            backButton.Font = new Font("Arial", 14F, FontStyle.Bold);
            backButton.ForeColor = Color.FromArgb(0, 64, 0);
            backButton.Location = new Point(38, 1164);
            backButton.Margin = new Padding(4);
            backButton.Name = "backButton";
            backButton.Size = new Size(354, 90);
            backButton.TabIndex = 1;
            backButton.Text = "Revino la Pagina ADMIN";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // buttonLogout
            // 
            buttonLogout.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonLogout.BackColor = Color.FromArgb(0, 64, 0);
            buttonLogout.Font = new Font("Arial", 14F, FontStyle.Bold);
            buttonLogout.ForeColor = Color.White;
            buttonLogout.Location = new Point(38, 1279);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Size = new Size(354, 69);
            buttonLogout.TabIndex = 12;
            buttonLogout.Text = "LOGOUT";
            buttonLogout.UseVisualStyleBackColor = false;
            buttonLogout.Click += buttonLogout_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(54, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(320, 305);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 6;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.Location = new Point(78, 655);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(2227, 175);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 363F));
            tableLayoutPanel1.Controls.Add(button4, 2, 0);
            tableLayoutPanel1.Controls.Add(button3, 1, 0);
            tableLayoutPanel1.Controls.Add(totalIncasariCard, 0, 1);
            tableLayoutPanel1.Controls.Add(totalIncasariIeriCard, 1, 1);
            tableLayoutPanel1.Controls.Add(percentageChangeCard, 2, 1);
            tableLayoutPanel1.Controls.Add(total7DaysCard, 0, 2);
            tableLayoutPanel1.Controls.Add(total7DaysPrevCard, 1, 2);
            tableLayoutPanel1.Controls.Add(percentageChange7DaysCard, 2, 2);
            tableLayoutPanel1.Controls.Add(total30DaysCard, 0, 3);
            tableLayoutPanel1.Controls.Add(total30DaysPrevCard, 1, 3);
            tableLayoutPanel1.Controls.Add(percentageChange30DaysCard, 2, 3);
            tableLayoutPanel1.Controls.Add(button2, 0, 0);
            tableLayoutPanel1.Location = new Point(75, 109);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 18.6471672F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 26.04651F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 28.83721F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 26.9767437F));
            tableLayoutPanel1.Size = new Size(2233, 430);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button4.Font = new Font("Arial", 14.1428576F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(1873, 3);
            button4.Name = "button4";
            button4.Size = new Size(357, 73);
            button4.TabIndex = 14;
            button4.Text = "Crestere, Scadere";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button3.Font = new Font("Arial", 14.1428576F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(938, 3);
            button3.Name = "button3";
            button3.Size = new Size(929, 73);
            button3.TabIndex = 13;
            button3.Text = "Perioada 2";
            button3.UseVisualStyleBackColor = true;
            // 
            // totalIncasariCard
            // 
            totalIncasariCard.BorderStyle = BorderStyle.FixedSingle;
            totalIncasariCard.Controls.Add(totalIncasariLabel);
            totalIncasariCard.Dock = DockStyle.Fill;
            totalIncasariCard.Location = new Point(3, 82);
            totalIncasariCard.Name = "totalIncasariCard";
            totalIncasariCard.Size = new Size(929, 105);
            totalIncasariCard.TabIndex = 3;
            // 
            // totalIncasariLabel
            // 
            totalIncasariLabel.AutoSize = true;
            totalIncasariLabel.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            totalIncasariLabel.Location = new Point(20, 20);
            totalIncasariLabel.Name = "totalIncasariLabel";
            totalIncasariLabel.Size = new Size(303, 38);
            totalIncasariLabel.TabIndex = 0;
            totalIncasariLabel.Text = "Total Incasari Azi: ";
            // 
            // totalIncasariIeriCard
            // 
            totalIncasariIeriCard.BorderStyle = BorderStyle.FixedSingle;
            totalIncasariIeriCard.Controls.Add(totalIncasariIeriLabel);
            totalIncasariIeriCard.Dock = DockStyle.Fill;
            totalIncasariIeriCard.Location = new Point(938, 82);
            totalIncasariIeriCard.Name = "totalIncasariIeriCard";
            totalIncasariIeriCard.Size = new Size(929, 105);
            totalIncasariIeriCard.TabIndex = 4;
            // 
            // totalIncasariIeriLabel
            // 
            totalIncasariIeriLabel.AutoSize = true;
            totalIncasariIeriLabel.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            totalIncasariIeriLabel.Location = new Point(20, 20);
            totalIncasariIeriLabel.Name = "totalIncasariIeriLabel";
            totalIncasariIeriLabel.Size = new Size(304, 38);
            totalIncasariIeriLabel.TabIndex = 0;
            totalIncasariIeriLabel.Text = "Total Incasari Ieri: ";
            // 
            // percentageChangeCard
            // 
            percentageChangeCard.BorderStyle = BorderStyle.FixedSingle;
            percentageChangeCard.Controls.Add(percentageChangeLabel);
            percentageChangeCard.Dock = DockStyle.Fill;
            percentageChangeCard.Location = new Point(1873, 82);
            percentageChangeCard.Name = "percentageChangeCard";
            percentageChangeCard.Size = new Size(357, 105);
            percentageChangeCard.TabIndex = 5;
            // 
            // percentageChangeLabel
            // 
            percentageChangeLabel.AutoSize = true;
            percentageChangeLabel.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            percentageChangeLabel.Location = new Point(14, 20);
            percentageChangeLabel.Name = "percentageChangeLabel";
            percentageChangeLabel.Size = new Size(43, 38);
            percentageChangeLabel.TabIndex = 0;
            percentageChangeLabel.Text = "%";
            // 
            // total7DaysCard
            // 
            total7DaysCard.BorderStyle = BorderStyle.FixedSingle;
            total7DaysCard.Controls.Add(total7DaysLabel);
            total7DaysCard.Dock = DockStyle.Fill;
            total7DaysCard.Location = new Point(3, 193);
            total7DaysCard.Name = "total7DaysCard";
            total7DaysCard.Size = new Size(929, 117);
            total7DaysCard.TabIndex = 6;
            // 
            // total7DaysLabel
            // 
            total7DaysLabel.AutoSize = true;
            total7DaysLabel.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            total7DaysLabel.Location = new Point(20, 20);
            total7DaysLabel.Name = "total7DaysLabel";
            total7DaysLabel.Size = new Size(389, 38);
            total7DaysLabel.TabIndex = 0;
            total7DaysLabel.Text = "Incasari Ultimele 7 Zile: ";
            // 
            // total7DaysPrevCard
            // 
            total7DaysPrevCard.BorderStyle = BorderStyle.FixedSingle;
            total7DaysPrevCard.Controls.Add(total7DaysPrevLabel);
            total7DaysPrevCard.Dock = DockStyle.Fill;
            total7DaysPrevCard.Location = new Point(938, 193);
            total7DaysPrevCard.Name = "total7DaysPrevCard";
            total7DaysPrevCard.Size = new Size(929, 117);
            total7DaysPrevCard.TabIndex = 7;
            // 
            // total7DaysPrevLabel
            // 
            total7DaysPrevLabel.AutoSize = true;
            total7DaysPrevLabel.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            total7DaysPrevLabel.Location = new Point(20, 20);
            total7DaysPrevLabel.Name = "total7DaysPrevLabel";
            total7DaysPrevLabel.Size = new Size(425, 38);
            total7DaysPrevLabel.TabIndex = 0;
            total7DaysPrevLabel.Text = "Incasari Anterioare 7 Zile: ";
            // 
            // percentageChange7DaysCard
            // 
            percentageChange7DaysCard.BorderStyle = BorderStyle.FixedSingle;
            percentageChange7DaysCard.Controls.Add(percentageChange7DaysLabel);
            percentageChange7DaysCard.Dock = DockStyle.Fill;
            percentageChange7DaysCard.Location = new Point(1873, 193);
            percentageChange7DaysCard.Name = "percentageChange7DaysCard";
            percentageChange7DaysCard.Size = new Size(357, 117);
            percentageChange7DaysCard.TabIndex = 8;
            // 
            // percentageChange7DaysLabel
            // 
            percentageChange7DaysLabel.AutoSize = true;
            percentageChange7DaysLabel.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            percentageChange7DaysLabel.Location = new Point(14, 20);
            percentageChange7DaysLabel.Name = "percentageChange7DaysLabel";
            percentageChange7DaysLabel.Size = new Size(43, 38);
            percentageChange7DaysLabel.TabIndex = 0;
            percentageChange7DaysLabel.Text = "%";
            // 
            // total30DaysCard
            // 
            total30DaysCard.BorderStyle = BorderStyle.FixedSingle;
            total30DaysCard.Controls.Add(total30DaysLabel);
            total30DaysCard.Dock = DockStyle.Fill;
            total30DaysCard.Location = new Point(3, 316);
            total30DaysCard.Name = "total30DaysCard";
            total30DaysCard.Size = new Size(929, 111);
            total30DaysCard.TabIndex = 9;
            // 
            // total30DaysLabel
            // 
            total30DaysLabel.AutoSize = true;
            total30DaysLabel.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            total30DaysLabel.Location = new Point(20, 20);
            total30DaysLabel.Name = "total30DaysLabel";
            total30DaysLabel.Size = new Size(407, 38);
            total30DaysLabel.TabIndex = 0;
            total30DaysLabel.Text = "Incasari Ultimele 30 Zile: ";
            // 
            // total30DaysPrevCard
            // 
            total30DaysPrevCard.BorderStyle = BorderStyle.FixedSingle;
            total30DaysPrevCard.Controls.Add(total30DaysPrevLabel);
            total30DaysPrevCard.Dock = DockStyle.Fill;
            total30DaysPrevCard.Location = new Point(938, 316);
            total30DaysPrevCard.Name = "total30DaysPrevCard";
            total30DaysPrevCard.Size = new Size(929, 111);
            total30DaysPrevCard.TabIndex = 10;
            // 
            // total30DaysPrevLabel
            // 
            total30DaysPrevLabel.AutoSize = true;
            total30DaysPrevLabel.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            total30DaysPrevLabel.Location = new Point(20, 20);
            total30DaysPrevLabel.Name = "total30DaysPrevLabel";
            total30DaysPrevLabel.Size = new Size(443, 38);
            total30DaysPrevLabel.TabIndex = 0;
            total30DaysPrevLabel.Text = "Incasari Anterioare 30 Zile: ";
            // 
            // percentageChange30DaysCard
            // 
            percentageChange30DaysCard.BorderStyle = BorderStyle.FixedSingle;
            percentageChange30DaysCard.Controls.Add(percentageChange30DaysLabel);
            percentageChange30DaysCard.Dock = DockStyle.Fill;
            percentageChange30DaysCard.Location = new Point(1873, 316);
            percentageChange30DaysCard.Name = "percentageChange30DaysCard";
            percentageChange30DaysCard.Size = new Size(357, 111);
            percentageChange30DaysCard.TabIndex = 11;
            // 
            // percentageChange30DaysLabel
            // 
            percentageChange30DaysLabel.AutoSize = true;
            percentageChange30DaysLabel.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            percentageChange30DaysLabel.Location = new Point(14, 20);
            percentageChange30DaysLabel.Name = "percentageChange30DaysLabel";
            percentageChange30DaysLabel.Size = new Size(43, 38);
            percentageChange30DaysLabel.TabIndex = 0;
            percentageChange30DaysLabel.Text = "%";
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button2.Font = new Font("Arial", 14.1428576F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(3, 3);
            button2.Name = "button2";
            button2.Size = new Size(929, 73);
            button2.TabIndex = 12;
            button2.Text = "Perioada 1";
            button2.UseVisualStyleBackColor = true;
            // 
            // statistica
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2855, 1662);
            Controls.Add(splitContainer1);
            Name = "statistica";
            Text = "statistica";
            Load += statistica_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            totalIncasariCard.ResumeLayout(false);
            totalIncasariCard.PerformLayout();
            totalIncasariIeriCard.ResumeLayout(false);
            totalIncasariIeriCard.PerformLayout();
            percentageChangeCard.ResumeLayout(false);
            percentageChangeCard.PerformLayout();
            total7DaysCard.ResumeLayout(false);
            total7DaysCard.PerformLayout();
            total7DaysPrevCard.ResumeLayout(false);
            total7DaysPrevCard.PerformLayout();
            percentageChange7DaysCard.ResumeLayout(false);
            percentageChange7DaysCard.PerformLayout();
            total30DaysCard.ResumeLayout(false);
            total30DaysCard.PerformLayout();
            total30DaysPrevCard.ResumeLayout(false);
            total30DaysPrevCard.PerformLayout();
            percentageChange30DaysCard.ResumeLayout(false);
            percentageChange30DaysCard.PerformLayout();
            ResumeLayout(false);
        }

        private void statistica_Load(object sender, EventArgs e)
        {
            // Call the methods to fetch and display total incasari
            DisplayTotalIncasari();
            DisplayTotalIncasariIeri();
            DisplayPercentageChange();
            DisplayTotal7Days();
            DisplayTotal7DaysPrev();
            DisplayPercentageChange7Days();
            DisplayTotal30Days();
            DisplayTotal30DaysPrev();
            DisplayPercentageChange30Days();
            DisplayMonthlyIncasari();
        }

        private void DisplayTotalIncasari()
        {
            string connectionString = @"Data Source=D:\Projects\AventuraPAY\DB\aventuraDBnote.db;Version=3;";
            string query = "SELECT SUM(Total) FROM notedeplata WHERE DATE(Data) = DATE('now')";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                SQLiteCommand command = new SQLiteCommand(query, connection);
                connection.Open();
                object result = command.ExecuteScalar();
                decimal totalIncasari = result != DBNull.Value ? Convert.ToDecimal(result) : 0;
                totalIncasariLabel.Text = "Total Incasari Azi: " + totalIncasari.ToString("N2") + " Lei";
            }
        }

        private void DisplayTotalIncasariIeri()
        {
            string connectionString = @"Data Source=D:\Projects\AventuraPAY\DB\aventuraDBnote.db;Version=3;";
            string query = "SELECT SUM(Total) FROM notedeplata WHERE DATE(Data) = DATE('now', '-1 day')";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                SQLiteCommand command = new SQLiteCommand(query, connection);
                connection.Open();
                object result = command.ExecuteScalar();
                decimal totalIncasariIeri = result != DBNull.Value ? Convert.ToDecimal(result) : 0;
                totalIncasariIeriLabel.Text = "Total Incasari Ieri: " + totalIncasariIeri.ToString("N2") + " Lei";
            }
        }

        private void DisplayPercentageChange()
        {
            string connectionString = @"Data Source=D:\Projects\AventuraPAY\DB\aventuraDBnote.db;Version=3;";
            string queryToday = "SELECT SUM(Total) FROM notedeplata WHERE DATE(Data) = DATE('now')";
            string queryYesterday = "SELECT SUM(Total) FROM notedeplata WHERE DATE(Data) = DATE('now', '-1 day')";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                SQLiteCommand commandToday = new SQLiteCommand(queryToday, connection);
                SQLiteCommand commandYesterday = new SQLiteCommand(queryYesterday, connection);

                object resultToday = commandToday.ExecuteScalar();
                object resultYesterday = commandYesterday.ExecuteScalar();

                decimal totalIncasariToday = resultToday != DBNull.Value ? Convert.ToDecimal(resultToday) : 0;
                decimal totalIncasariYesterday = resultYesterday != DBNull.Value ? Convert.ToDecimal(resultYesterday) : 0;

                decimal percentageChange = 0;
                if (totalIncasariYesterday != 0)
                {
                    percentageChange = ((totalIncasariToday - totalIncasariYesterday) / totalIncasariYesterday) * 100;
                }

                percentageChangeLabel.Text = percentageChange.ToString("N2") + "%";
            }
        }

        private void DisplayTotal7Days()
        {
            string connectionString = @"Data Source=D:\Projects\AventuraPAY\DB\aventuraDBnote.db;Version=3;";
            string query = "SELECT SUM(Total) FROM notedeplata WHERE DATE(Data) BETWEEN DATE('now', '-6 day') AND DATE('now')";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                SQLiteCommand command = new SQLiteCommand(query, connection);
                connection.Open();
                object result = command.ExecuteScalar();
                decimal total7Days = result != DBNull.Value ? Convert.ToDecimal(result) : 0;
                total7DaysLabel.Text = "Incasari Ultimele 7 Zile: " + total7Days.ToString("N2") + " Lei";
            }
        }

        private void DisplayTotal7DaysPrev()
        {
            string connectionString = @"Data Source=D:\Projects\AventuraPAY\DB\aventuraDBnote.db;Version=3;";
            string query = "SELECT SUM(Total) FROM notedeplata WHERE DATE(Data) BETWEEN DATE('now', '-13 day') AND DATE('now', '-7 day')";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                SQLiteCommand command = new SQLiteCommand(query, connection);
                connection.Open();
                object result = command.ExecuteScalar();
                decimal total7DaysPrev = result != DBNull.Value ? Convert.ToDecimal(result) : 0;
                total7DaysPrevLabel.Text = "Incasari Anterioare 7 Zile: " + total7DaysPrev.ToString("N2") + " Lei";
            }
        }

        private void DisplayPercentageChange7Days()
        {
            string connectionString = @"Data Source=D:\Projects\AventuraPAY\DB\aventuraDBnote.db;Version=3;";
            string query7Days = "SELECT SUM(Total) FROM notedeplata WHERE DATE(Data) BETWEEN DATE('now', '-6 day') AND DATE('now')";
            string query7DaysPrev = "SELECT SUM(Total) FROM notedeplata WHERE DATE(Data) BETWEEN DATE('now', '-13 day') AND DATE('now', '-7 day')";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                SQLiteCommand command7Days = new SQLiteCommand(query7Days, connection);
                SQLiteCommand command7DaysPrev = new SQLiteCommand(query7DaysPrev, connection);

                object result7Days = command7Days.ExecuteScalar();
                object result7DaysPrev = command7DaysPrev.ExecuteScalar();

                decimal total7Days = result7Days != DBNull.Value ? Convert.ToDecimal(result7Days) : 0;
                decimal total7DaysPrev = result7DaysPrev != DBNull.Value ? Convert.ToDecimal(result7DaysPrev) : 0;

                decimal percentageChange7Days = 0;
                if (total7DaysPrev != 0)
                {
                    percentageChange7Days = ((total7Days - total7DaysPrev) / total7DaysPrev) * 100;
                }

                percentageChange7DaysLabel.Text = percentageChange7Days.ToString("N2") + "%";
            }
        }

        private void DisplayTotal30Days()
        {
            string connectionString = @"Data Source=D:\Projects\AventuraPAY\DB\aventuraDBnote.db;Version=3;";
            string query = "SELECT SUM(Total) FROM notedeplata WHERE DATE(Data) BETWEEN DATE('now', '-29 day') AND DATE('now')";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                SQLiteCommand command = new SQLiteCommand(query, connection);
                connection.Open();
                object result = command.ExecuteScalar();
                decimal total30Days = result != DBNull.Value ? Convert.ToDecimal(result) : 0;
                total30DaysLabel.Text = "Incasari Ultimele 30 Zile: " + total30Days.ToString("N2") + " Lei";
            }
        }

        private void DisplayTotal30DaysPrev()
        {
            string connectionString = @"Data Source=D:\Projects\AventuraPAY\DB\aventuraDBnote.db;Version=3;";
            string query = "SELECT SUM(Total) FROM notedeplata WHERE DATE(Data) BETWEEN DATE('now', '-59 day') AND DATE('now', '-30 day')";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                SQLiteCommand command = new SQLiteCommand(query, connection);
                connection.Open();
                object result = command.ExecuteScalar();
                decimal total30DaysPrev = result != DBNull.Value ? Convert.ToDecimal(result) : 0;
                total30DaysPrevLabel.Text = "Incasari Anterioare 30 Zile: " + total30DaysPrev.ToString("N2") + " Lei";
            }
        }

        private void DisplayPercentageChange30Days()
        {
            string connectionString = @"Data Source=D:\Projects\AventuraPAY\DB\aventuraDBnote.db;Version=3;";
            string query30Days = "SELECT SUM(Total) FROM notedeplata WHERE DATE(Data) BETWEEN DATE('now', '-29 day') AND DATE('now')";
            string query30DaysPrev = "SELECT SUM(Total) FROM notedeplata WHERE DATE(Data) BETWEEN DATE('now', '-59 day') AND DATE('now', '-30 day')";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                SQLiteCommand command30Days = new SQLiteCommand(query30Days, connection);
                SQLiteCommand command30DaysPrev = new SQLiteCommand(query30DaysPrev, connection);

                object result30Days = command30Days.ExecuteScalar();
                object result30DaysPrev = command30DaysPrev.ExecuteScalar();

                decimal total30Days = result30Days != DBNull.Value ? Convert.ToDecimal(result30Days) : 0;
                decimal total30DaysPrev = result30DaysPrev != DBNull.Value ? Convert.ToDecimal(result30DaysPrev) : 0;

                decimal percentageChange30Days = 0;
                if (total30DaysPrev != 0)
                {
                    percentageChange30Days = ((total30Days - total30DaysPrev) / total30DaysPrev) * 100;
                }

                percentageChange30DaysLabel.Text = percentageChange30Days.ToString("N2") + "%";
            }
        }

        private void DisplayMonthlyIncasari()
        {
            string connectionString = @"Data Source=D:\Projects\AventuraPAY\DB\aventuraDBnote.db;Version=3;";
            Color[] colors = { Color.Blue, Color.Green, Color.Red, Color.Purple, Color.Orange, Color.Pink, Color.Brown, Color.Magenta, Color.Teal, Color.Olive, Color.Maroon, Color.Navy };
            string[] monthNames = { "Ianuarie", "Februarie", "Martie", "Aprilie", "Mai", "Iunie", "Iulie", "August", "Septembrie", "Octombrie", "Noiembrie", "Decembrie" };

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                for (int month = 1; month <= 12; ++month)
                {
                    string query = $"SELECT SUM(Total) FROM notedeplata WHERE strftime('%m', Data) = '{month:D2}'";
                    SQLiteCommand command = new SQLiteCommand(query, connection);
                    object result = command.ExecuteScalar();
                    decimal totalIncasari = result != DBNull.Value ? Convert.ToDecimal(result) : 0;

                    Label monthLabel = new Label
                    {
                        Text = $"{monthNames[month - 1]}: {totalIncasari.ToString("N2")} Lei",
                        Font = new Font("Arial", 8F, FontStyle.Bold),
                        AutoSize = false,
                        ForeColor = colors[month - 1],
                        TextAlign = ContentAlignment.MiddleCenter,
                        Dock = DockStyle.Fill
                    };

                    Panel cellPanel = new Panel
                    {
                        BorderStyle = BorderStyle.FixedSingle,
                        Dock = DockStyle.Fill
                    };
                    cellPanel.Controls.Add(monthLabel);

                    int row = (month - 1) / 6;
                    int column = (month - 1) % 6;
                    tableLayoutPanel2.Controls.Add(cellPanel, column, row);
                }
            }
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
            statistica2 statistica2Form = new statistica2();
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

        #endregion

        private SplitContainer splitContainer1;
        private PictureBox pictureBox1;
        private Button button11;
        private Button backButton;
        private Button buttonLogout;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel totalIncasariCard;
        private Label totalIncasariLabel;
        private Panel totalIncasariIeriCard;
        private Label totalIncasariIeriLabel;
        private Panel percentageChangeCard;
        private Label percentageChangeLabel;
        private Panel total7DaysCard;
        private Label total7DaysLabel;
        private Panel total7DaysPrevCard;
        private Label total7DaysPrevLabel;
        private Panel percentageChange7DaysCard;
        private Label percentageChange7DaysLabel;
        private Panel total30DaysCard;
        private Label total30DaysLabel;
        private Panel total30DaysPrevCard;
        private Label total30DaysPrevLabel;
        private Panel percentageChange30DaysCard;
        private Label percentageChange30DaysLabel;
        private Button button4;
        private Button button3;
        private Button button2;
        private TableLayoutPanel tableLayoutPanel2;
    }
}
