﻿using Microsoft.AspNetCore.Mvc;

namespace Lab_Routing_and_Navigation.Areas.Admin.Controllers
{
    public class AccountController :BaseController
    {
        public IActionResult Profile()
        {
            return View();
        }
        public IActionResult LogOut()
        { 
            return View();
        }
    }
}
