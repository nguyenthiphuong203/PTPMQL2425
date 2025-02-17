using DemoMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace DemoMVC.Controllers
{
    public class HoaDonController : Controller
    {
        public IActionResult Index()
        {
            return View(new HoaDon());
        }

        [HttpPost]
        public IActionResult Index(HoaDon model)
        {
            if (ModelState.IsValid)
            {
                return View("Result", model);
            }
            return View(model);
        }

        public IActionResult Result(HoaDon model)
        {
            return View(model);
        }
    }
}