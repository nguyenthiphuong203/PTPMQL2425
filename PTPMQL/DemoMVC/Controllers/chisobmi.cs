using Microsoft.AspNetCore.Mvc;
using DemoMVC.Models;

namespace DemoMVC.Controllers{
    public class chisoBMIController : Controller{
        [HttpGet]
        public IActionResult Dochiso(){
            return View();
        }
        [HttpPost]        
        public IActionResult Dochiso(chisoBMI std){
           
                std.BMI = std.Weight/(std.Height*std.Height)*10000;
                ViewBag.BMI = std.BMI;
                
            return View();
    }
}
}