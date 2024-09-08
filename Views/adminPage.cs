using System;
using System.Data;
using System.Windows.Forms;
using AventuraPAY.Controllers;

namespace AventuraPAY.Views
{
    public partial class adminPage : Form
    {
        private AdminPageController controller;

        // Proprietate publică pentru a expune tableLayoutPanel1
        public TableLayoutPanel TableLayoutPanel1
        {
            get { return TableLayoutPanel1; }
        }

        public adminPage()
        {
            InitializeComponent();
            controller = new AdminPageController(this);
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        private void Button0_Click(object sender, EventArgs e)
        {
            controller.NavigateToVanzari();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            controller.NavigateToUserdata();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            controller.NavigateToProduse();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            controller.NavigateToStatistica();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            controller.NavigateToUtile();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            controller.Logout();
        }

        private void AdminPage_Load(object sender, EventArgs e)
        {
            controller.InitializeTableLayoutPanel();
            controller.LoadReceiptsData();
        }

        // Metodă pentru actualizarea UI-ului cu datele bonurilor
        public void UpdateReceiptTable(DataTable receiptsTable)
        {
            TableLayoutPanel1.Controls.Clear();
            controller.InitializeTableLayoutPanel();

            for (int i = 0; i < receiptsTable.Rows.Count; ++i)
            {
                DataRow row = receiptsTable.Rows[i];
                DateTime dataCreare = DateTime.Parse(row["Data"].ToString());
                TimeSpan timpulRamas = dataCreare.AddHours(2) - DateTime.Now;

                string timpulRamasText = timpulRamas.TotalSeconds > 0
                    ? $"{timpulRamas.Hours:D2}:{timpulRamas.Minutes:D2}:{timpulRamas.Seconds:D2}"
                    : "Expirat";

                TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
                TableLayoutPanel1.Controls.Add(new Label() { Text = row["id"].ToString(), AutoSize = true }, 0, i + 1);
                TableLayoutPanel1.Controls.Add(new Label() { Text = row["DetaliiClient"].ToString(), AutoSize = true }, 1, i + 1);
                TableLayoutPanel1.Controls.Add(new Label() { Text = row["Total"].ToString(), AutoSize = true }, 2, i + 1);
                TableLayoutPanel1.Controls.Add(new Label() { Text = timpulRamasText, AutoSize = true, Name = $"timerLabel{i}" }, 3, i + 1);
            }
        }
    }
}
