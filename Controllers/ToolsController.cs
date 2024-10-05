using AventuraPAY.Views;

namespace AventuraPAY.Controllers
{
    public class ToolsController
    {
        private readonly Tools view;

        public ToolsController(Tools view)
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
