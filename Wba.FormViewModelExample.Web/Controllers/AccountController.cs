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
            if(accountLoginViewModel.UserName.Equals("mil@mil.com")
                && accountLoginViewModel.Password.Equals("bananaman75"))
            {
                //redirecten
                return RedirectToAction("Index","Home");
            }
            return View("Error");
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
            return View(accountRegisterViewModel);
        }
    }
}
