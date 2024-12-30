using Microsoft.AspNetCore.Mvc;

namespace BebekBakıcısı.Controllers
{
    public class SepetController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult OdemeProcess()
        {
            return View();
        }
    }
}
