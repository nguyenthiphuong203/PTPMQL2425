using System.ComponentModel.DataAnnotations;

namespace DemoMVC.Models
{
    public class BMI
    {
        [Required(ErrorMessage = "Gender is required")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Height is required")]
        [Range(0.1, 3.0, ErrorMessage = "Height must be between 0.1 and 3.0 meters")]
        public double Height { get; set; }

        [Required(ErrorMessage = "Weight is required")]
        [Range(1, 500, ErrorMessage = "Weight must be between 1 and 500 kg")]
        public double Weight { get; set; }
    }
}