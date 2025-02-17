using DemoMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace DemoMVC.Controllers
{
    public class DiemController : Controller
    {
        public IActionResult Index()
        {
            return View(new DiemMonHoc());
        }

        [HttpPost]
        public IActionResult Index(DiemMonHoc model)
        {
            if (ModelState.IsValid)
            {
                return View("Result", model);
            }
            return View(model);
        }

        public IActionResult Result(DiemMonHoc model)
        {
            return View(model);
        }
    }
}