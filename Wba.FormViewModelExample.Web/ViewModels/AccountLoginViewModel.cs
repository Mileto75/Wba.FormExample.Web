using System.ComponentModel.DataAnnotations;

namespace Wba.FormViewModelExample.Web.ViewModels
{
    public class AccountLoginViewModel
    {
        [Display(Name = "Gebruikersnaam")]
        [DataType(DataType.EmailAddress)]
        public string UserName { get; set; }
        [Display(Name = "Wachtwoord")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Display(Name = "Onthoud mij")]
        public bool RememberMe { get; set; }
    }
}
