using Microsoft.AspNetCore.Mvc;
using DemoMVC.Models;

namespace DemoMVC.Controllers
{
    public class BMIController : Controller
    {
        // Hiển thị form nhập liệu
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        // Xử lý dữ liệu từ form
        [HttpPost]
        public IActionResult Index(BMI model)
        {
            if (ModelState.IsValid)
            {
                // Tính toán BMI
                double bmi = model.Weight / (model.Height * model.Height);
                string category = GetBMICategory(bmi);

                // Truyền kết quả sang View
                ViewBag.BMIModel = $"Your BMI is: {bmi:F2} ({category})";
            }

            // Trả về view với model (để hiển thị lại form nếu có lỗi)
            return View(model);
        }

        // Phân loại BMI
        private string GetBMICategory(double bmi)
        {
            if (bmi < 18.5) return "Underweight";
            if (bmi < 24.9) return "Normal";
            if (bmi < 29.9) return "Overweight";
            return "Obese";
        }
    }
}