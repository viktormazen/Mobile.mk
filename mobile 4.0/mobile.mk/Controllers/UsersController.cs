using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using mobile.Services.Interfaces;
using mobile.WebModels;

namespace mobile.WebApp.Controllers
{
    [Authorize]
    public class UsersController : Controller
    {
            private readonly IUserService _userService;

            public UsersController(IUserService userService)
            {
                _userService = userService;
            }

            [AllowAnonymous]
            public IActionResult Login()
            {
                return View(new LoginViewModel());
            }

            [AllowAnonymous]
            [HttpPost]
            public IActionResult Login(LoginViewModel model)
            {
                _userService.Login(model);

                //if (User.IsInRole("customer"))
                //    return RedirectToAction("Index", "Vehicles");

                return RedirectToAction("Index", "Vehicles");
            }

            [AllowAnonymous]
            public IActionResult Register()
            {
                return View(new RegisterViewModel());
            }

            [AllowAnonymous]
            [HttpPost]
            public IActionResult Register(RegisterViewModel model)
            {
                _userService.Register(model);
                return RedirectToAction("Index", "Vehicles");
            }

            [Authorize(Roles = "customer, admin")]
            public IActionResult LogOut()
                {
                    _userService.Logout();
                    return RedirectToAction("Login", "Users");
                }

            [Authorize(Roles = "admin")]
            public IActionResult ListUsers()
                {
                    return View(_userService.GetAllUsers());
                }
            }
}