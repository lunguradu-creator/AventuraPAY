using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using AventuraPAY.Models;
using AventuraPAY.Views;

namespace AventuraPAY.Controllers
{
    public class AdminPageController
    {
        private readonly adminPage view;
        private readonly ReceiptModel model;
        private DataTable receiptsTable;
        private Views.adminPage adminPage;

        public AdminPageController(adminPage view)
        {
            this.view = view;
            this.model = new ReceiptModel();
        }

        public AdminPageController(Views.adminPage adminPage)
        {
            this.adminPage = adminPage;
        }

        public void InitializeTableLayoutPanel()
        {
            var table = view.TableLayoutPanel1;
            table.Controls.Clear();
            table.RowStyles.Clear();
            table.RowCount = 1;

            table.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            table.Controls.Add(new Label() { Text = "Bon", Font = new Font("Arial", 12F, FontStyle.Bold), AutoSize = true }, 0, 0);
            table.Controls.Add(new Label() { Text = "Client", Font = new Font("Arial", 12F, FontStyle.Bold), AutoSize = true }, 1, 0);
            table.Controls.Add(new Label() { Text = "Preț", Font = new Font("Arial", 12F, FontStyle.Bold), AutoSize = true }, 2, 0);
            table.Controls.Add(new Label() { Text = "Timp Rămas", Font = new Font("Arial", 12F, FontStyle.Bold), AutoSize = true }, 3, 0);
        }

        public void LoadReceiptsData()
        {
            receiptsTable = model.GetReceiptsForToday();
            view.UpdateReceiptTable(receiptsTable);
        }

        public void UpdateTimer_Tick()
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

                Control[] timerLabels = view.TableLayoutPanel1.Controls.Find($"timerLabel{i}", true);
                if (timerLabels.Length > 0)
                {
                    timerLabels[0].Text = timpulRamasText;
                }
            }
        }

        public void NavigateToVanzari()
        {
            var vanzariForm = new vanzari();
            vanzariForm.WindowState = FormWindowState.Maximized;
            vanzariForm.Show();
            view.Close();
        }

        public void NavigateToUserdata()
        {
            var userdataForm = new userdata();
            userdataForm.WindowState = FormWindowState.Maximized;
            userdataForm.Show();
            view.Close();
        }

        public void NavigateToProduse()
        {
            var produseForm = new produse();
            produseForm.WindowState = FormWindowState.Maximized;
            produseForm.Show();
            view.Close();
        }

        public void NavigateToStatistica()
        {
            var statisticaForm = new statistica();
            statisticaForm.WindowState = FormWindowState.Maximized;
            statisticaForm.Show();
            view.Close();
        }

        public void NavigateToUtile()
        {
            var utileForm = new utile();
            utileForm.WindowState = FormWindowState.Maximized;
            utileForm.Show();
            view.Close();
        }

        public void Logout()
        {
            var AventuraPAYForm = new AventuraPAY();
            AventuraPAYForm.WindowState = FormWindowState.Maximized;
            AventuraPAYForm.Show();
            view.Close();
        }
    }
}
