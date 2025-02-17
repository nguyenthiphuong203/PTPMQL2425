public class BMIController : Controller
{
    [HttpGet]
    public ActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public ActionResult Calculate(BMIModel model)
    {
        if (ModelState.IsValid)
        {
            double ChiềucaoInMeters = model.Chiềucao / 100;
            double bmi = model.Cânnặng / (ChiềucaoInMeters * ChiềucaoInMeters);

            ViewBag.BMIResult = bmi.ToString("F2");
        }

        return View("Index", model);
    }
}