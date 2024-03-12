using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Wba.FormViewModelExample.Web.ViewModels;

namespace Wba.FormViewModelExample.Web.Controllers
{
    public class PizzaController : Controller
    {
        [HttpGet]
        public IActionResult Order()
        {
            //display the form
            PizzaProcessOrderViewModel pizzaProcessOrderViewmodel = new PizzaProcessOrderViewModel
            {
                Pizzas = new List<SelectListItem>
                {
                    new SelectListItem{Text="<Select Pizza>"},
                    new SelectListItem { Value = "1", Text = "Pizza Pepperoni" },
                    new SelectListItem { Value = "2", Text = "Pizza Funghi" },
                    new SelectListItem { Value = "3", Text = "Pizza Buratta" },
                    new SelectListItem { Value = "4", Text = "Pizza Pomodore" },
                    new SelectListItem { Value = "5", Text = "Pizza 4 stagionni" },
                    new SelectListItem { Value = "6", Text = "Pizza con Fruiti di mare" },
                }
            };

            pizzaProcessOrderViewmodel.ExtraToppings = new List<SelectListItem>
                {
                    new SelectListItem{Text="<Select Toppings>"},
                    new SelectListItem { Value = "1", Text = "extra cheese" },
                    new SelectListItem { Value = "2", Text = "extra onion" },
                    new SelectListItem { Value = "3", Text = "extra olives" },
                    new SelectListItem { Value = "4", Text = "extra mince" },
                    new SelectListItem { Value = "5", Text = "extra peperoni" },
                    new SelectListItem { Value = "6", Text = "extra veggies" }
                };
            pizzaProcessOrderViewmodel.Sizes = new List<SelectListItem>
                {
                    new SelectListItem{Text="<Select Size>"},
                    new SelectListItem { Value = "S", Text = "Small" },
                    new SelectListItem { Value = "M", Text = "Medium" },
                    new SelectListItem { Value = "L", Text = "Large" },
                };
            return View(pizzaProcessOrderViewmodel);
        }
        [HttpPost]
        public IActionResult ProcessOrder(PizzaProcessOrderViewModel pizzaProcessOrderViewModel)
        {
            //process the form data
            if(!ModelState.IsValid)
            {
                pizzaProcessOrderViewModel.Pizzas = new List<SelectListItem>
                {
                    new SelectListItem{Text="<Select Pizza>"},
                    new SelectListItem { Value = "1", Text = "Pizza Pepperoni" },
                    new SelectListItem { Value = "2", Text = "Pizza Funghi" },
                    new SelectListItem { Value = "3", Text = "Pizza Buratta" },
                    new SelectListItem { Value = "4", Text = "Pizza Pomodore" },
                    new SelectListItem { Value = "5", Text = "Pizza 4 stagionni" },
                    new SelectListItem { Value = "6", Text = "Pizza con Fruiti di mare" },
                };

                pizzaProcessOrderViewModel.ExtraToppings = new List<SelectListItem>
                {
                    new SelectListItem{Text="<Select Toppings>"},
                    new SelectListItem { Value = "1", Text = "extra cheese" },
                    new SelectListItem { Value = "2", Text = "extra onion" },
                    new SelectListItem { Value = "3", Text = "extra olives" },
                    new SelectListItem { Value = "4", Text = "extra mince" },
                    new SelectListItem { Value = "5", Text = "extra peperoni" },
                    new SelectListItem { Value = "6", Text = "extra veggies" }
                };
                pizzaProcessOrderViewModel.Sizes = new List<SelectListItem>
                {
                    new SelectListItem{Text="<Select Size>"},
                    new SelectListItem { Value = "S", Text = "Small" },
                    new SelectListItem { Value = "M", Text = "Medium" },
                    new SelectListItem { Value = "L", Text = "Large" },
                };
                return View("Order",pizzaProcessOrderViewModel);
            }
            return RedirectToAction("OrderSuccesful");
        }
        [HttpGet]
        public IActionResult OrderSuccesful()
        {
            return View();
        }
    }
}
