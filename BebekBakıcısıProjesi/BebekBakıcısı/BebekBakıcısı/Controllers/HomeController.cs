using Microsoft.AspNetCore.Mvc;

namespace BebekBakıcısı.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Index1()
        {
            return View();
        }
    }
}
