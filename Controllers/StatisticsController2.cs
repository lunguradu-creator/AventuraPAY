using AventuraPAY.Models;
using AventuraPAY.Views;
using System;

namespace AventuraPAY.Controllers
{
    public class StatisticsController2
    {
        private readonly StatisticsModel model;
        private readonly statistica2 view;
        private Statistics2Controller statistica2;

        public StatisticsController2(statistica2 view)
        {
            this.model = new StatisticsModel();
            this.view = view;
        }

        internal StatisticsController2(Statistics2Controller statistica2)
        {
            this.statistica2 = statistica2;
        }

        public void LoadUsers()
        {
            var users = model.GetUsers();
            view.PopulateUserComboBox(users);
        }

        public void DisplayStatistics(DateTime startDate, DateTime endDate, string user)
        {
            var stats = model.GetStatistics(startDate, endDate, user);
            view.UpdateStatistics(stats.cardTotal, stats.cashTotal, stats.protocolTotal, stats.totalIncasari);
        }
    }
}
