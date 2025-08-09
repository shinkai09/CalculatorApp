using CalculatorApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace CalculatorApp.Controllers
{
    public class CalculatorController : Controller
    {
        public IActionResult Index()
        {
            var model = new CalculatorModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult Calculate(CalculatorModel model)
        {
            if (ModelState.IsValid)
            {
                model.Calculate();
            }

            return View("Index", model);
        }

    }
}
