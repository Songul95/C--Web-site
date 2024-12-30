using Microsoft.AspNetCore.Mvc;

namespace BebekBakıcısı.Controllers
{
    public class KurslarController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Details()
        {
            return View();
        }
    }
}
