using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Wba.FormViewModelExample.Web.ViewModels;

namespace Wba.FormViewModelExample.Web.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            AccountLoginViewModel accountLoginViewModel
                = new();
            accountLoginViewModel.RememberMe = true;
            return View(accountLoginViewModel);
        }
        [HttpPost]
        public IActionResult Login(AccountLoginViewModel accountLoginViewModel)
        {
            if (ModelState.IsValid)
            {

                if (accountLoginViewModel.UserName.Equals("mil@mil.com")
                    && accountLoginViewModel.Password.Equals("bananaman75"))
                {
                    //redirecten
                    return RedirectToAction("Index", "Home");
                }
                ModelState.AddModelError("", "Wrong credentials!");
            }
            //we have form errors
            return View(accountLoginViewModel);
        }
        [HttpGet]
        public IActionResult Register()
        {
            var accountRegisterViewModel = new AccountRegisterViewModel
            { 
                Countries = new List<SelectListItem>
                {
                    new SelectListItem {Value = "1", Text = "Italië" },
                    new SelectListItem {Value = "2", Text = "Portugal" },
                    new SelectListItem {Value = "3", Text = "Spanje" },
                }
            };
            return View(accountRegisterViewModel);
        }
        [HttpPost]
        public IActionResult Register(AccountRegisterViewModel accountRegisterViewModel)
        {
            if(!ModelState.IsValid)
            {
                accountRegisterViewModel.Countries
                     = new List<SelectListItem>
                {
                    new SelectListItem {Value = "1", Text = "Italië" },
                    new SelectListItem {Value = "2", Text = "Portugal" },
                    new SelectListItem {Value = "3", Text = "Spanje" },
                };
                return View(accountRegisterViewModel);
            }
            return RedirectToAction("Registered");
        }
        [HttpGet]
        public IActionResult Registered()
        {
            return View();
        }
    }
}
