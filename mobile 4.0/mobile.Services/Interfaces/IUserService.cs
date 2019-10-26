using mobile.WebModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace mobile.Services.Interfaces
{
    public interface IUserService
    {
        void Register(RegisterViewModel registerModel);
        void Login(LoginViewModel loginModel);
        void Logout();
        UserViewModel GetCurrentUser(string username);
        IEnumerable<UserViewModel> GetAllUsers();
    }
}
