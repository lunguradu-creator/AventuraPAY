using AventuraPAY.Models;
using AventuraPAY.Views;
using System;

namespace AventuraPAY.Controllers
{
    public class StatisticsController
    {
        private readonly StatisticsModel model;
        private readonly statistica view;

        public StatisticsController(statistica view)
        {
            this.model = new StatisticsModel();
            this.view = view;
        }

        public void DisplayStatistics()
        {
            view.UpdateTotalIncasari(GetTotalIncasariToday());
            view.UpdateTotalIncasariIeri(GetTotalIncasariYesterday());
            view.UpdatePercentageChange(GetPercentageChange());
            view.UpdateTotal7Days(GetTotal7Days());
            view.UpdateTotal7DaysPrev(GetTotal7DaysPrev());
            view.UpdatePercentageChange7Days(GetPercentageChange7Days());
            view.UpdateTotal30Days(GetTotal30Days());
            view.UpdateTotal30DaysPrev(GetTotal30DaysPrev());
            view.UpdatePercentageChange30Days(GetPercentageChange30Days());
        }

        private decimal GetTotalIncasariToday()
        {
            string query = "SELECT SUM(Total) FROM notedeplata WHERE DATE(Data) = DATE('now')";
            return model.GetTotalIncasari(query);
        }

        private decimal GetTotalIncasariYesterday()
        {
            string query = "SELECT SUM(Total) FROM notedeplata WHERE DATE(Data) = DATE('now', '-1 day')";
            return model.GetTotalIncasari(query);
        }

        private decimal GetPercentageChange()
        {
            string queryToday = "SELECT SUM(Total) FROM notedeplata WHERE DATE(Data) = DATE('now')";
            string queryYesterday = "SELECT SUM(Total) FROM notedeplata WHERE DATE(Data) = DATE('now', '-1 day')";
            return model.GetPercentageChange(queryToday, queryYesterday);
        }

        private decimal GetTotal7Days()
        {
            string query = "SELECT SUM(Total) FROM notedeplata WHERE DATE(Data) BETWEEN DATE('now', '-6 day') AND DATE('now')";
            return model.GetTotalIncasari(query);
        }

        private decimal GetTotal7DaysPrev()
        {
            string query = "SELECT SUM(Total) FROM notedeplata WHERE DATE(Data) BETWEEN DATE('now', '-13 day') AND DATE('now', '-7 day')";
            return model.GetTotalIncasari(query);
        }

        private decimal GetPercentageChange7Days()
        {
            string query7Days = "SELECT SUM(Total) FROM notedeplata WHERE DATE(Data) BETWEEN DATE('now', '-6 day') AND DATE('now')";
            string query7DaysPrev = "SELECT SUM(Total) FROM notedeplata WHERE DATE(Data) BETWEEN DATE('now', '-13 day') AND DATE('now', '-7 day')";
            return model.GetPercentageChange(query7Days, query7DaysPrev);
        }

        private decimal GetTotal30Days()
        {
            string query = "SELECT SUM(Total) FROM notedeplata WHERE DATE(Data) BETWEEN DATE('now', '-29 day') AND DATE('now')";
            return model.GetTotalIncasari(query);
        }

        private decimal GetTotal30DaysPrev()
        {
            string query = "SELECT SUM(Total) FROM notedeplata WHERE DATE(Data) BETWEEN DATE('now', '-59 day') AND DATE('now', '-30 day')";
            return model.GetTotalIncasari(query);
        }

        private decimal GetPercentageChange30Days()
        {
            string query30Days = "SELECT SUM(Total) FROM notedeplata WHERE DATE(Data) BETWEEN DATE('now', '-29 day') AND DATE('now')";
            string query30DaysPrev = "SELECT SUM(Total) FROM notedeplata WHERE DATE(Data) BETWEEN DATE('now', '-59 day') AND DATE('now', '-30 day')";
            return model.GetPercentageChange(query30Days, query30DaysPrev);
        }
    }
}
