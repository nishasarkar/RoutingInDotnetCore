using Lab_Routing_and_Navigation.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab_Routing_and_Navigation.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost] 
        public IActionResult Login(LoginViewModel model)
        {
            if (model.UserName == "user@gmail.com" && model.Password == "12345678")
            { 
                return RedirectToAction("Index", "Home", new { area = "User" });
            } 
            else if (model.UserName == "admin@gmail.com" && model.Password == "12345678")
            { return RedirectToAction("Index", "Home", new { area = "Admin" }); } 
            return View(); 
        }

        //
    }
}
