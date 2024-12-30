using Data.Layer;
using Microsoft.AspNetCore.Mvc;
using System.Data.Entity;

namespace BebekBakıcısı.Controllers
{
    public class IletisimController : Controller
    {
        private readonly DbKıdsEntities _context;
        public IletisimController(DbKıdsEntities context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult Index()
        {

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(TblMessage message)
        {
            if (ModelState.IsValid)
            {
                _context.TblMessage.Add(message);
                await _context.SaveChangesAsync();
                return RedirectToAction("Success");
            }

            return View(message);
        }
    }
}
