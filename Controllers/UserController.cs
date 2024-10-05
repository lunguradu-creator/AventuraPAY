using AventuraPAY.Models;
using AventuraPAY.Views;
using System;

namespace AventuraPAY.Controllers
{
    public class UserController
    {
        private readonly UserModel model;
        private readonly userdata view;

        public UserController(userdata view)
        {
            this.model = new UserModel();
            this.view = view;
        }

        public void LoadAllUsers()
        {
            var users = model.GetAllUsers();
            view.UpdateUserPanel(users);
        }

        public void LoadUsernames()
        {
            var usernames = model.GetUsernames();
            view.UpdateUserComboBox(usernames);
        }

        public void AddUser(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                view.ShowMessage("Numele de utilizator și parola nu pot fi goale.");
                return;
            }

            model.AddUser(username, password);
            LoadAllUsers();
            LoadUsernames();
        }

        public void DeleteUser(string username)
        {
            if (string.IsNullOrWhiteSpace(username))
            {
                view.ShowMessage("Selectați un utilizator pentru a-l șterge.");
                return;
            }

            model.DeleteUser(username);
            LoadAllUsers();
            LoadUsernames();
        }
    }
}
