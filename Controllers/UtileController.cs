using AventuraPAY.Views;

namespace AventuraPAY.Controllers
{
    public class UtileController
    {
        private readonly utile view;

        public UtileController(utile view)
        {
            this.view = view;
        }

        public void NavigateToAdminPage()
        {
            adminPage adminPageForm = new adminPage();
            adminPageForm.WindowState = FormWindowState.Maximized;
            adminPageForm.Show();
            view.Close();
        }
    }
}
