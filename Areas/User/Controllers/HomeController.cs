using Microsoft.AspNetCore.Mvc;

namespace Lab_Routing_and_Navigation.Areas.User.Controllers
{
    public class HomeController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
