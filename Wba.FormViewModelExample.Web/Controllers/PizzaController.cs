using Microsoft.AspNetCore.Mvc;

namespace Wba.FormViewModelExample.Web.Controllers
{
    public class PizzaController : Controller
    {
        [HttpGet]
        public IActionResult Order()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ProcessOrder()
        {
            return View();
        }
    }
}
