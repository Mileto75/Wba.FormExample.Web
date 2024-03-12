using System.ComponentModel.DataAnnotations;

namespace Wba.FormViewModelExample.Web.ViewModels
{
    public class AccountLoginViewModel
    {
        [Display(Name = "Gebruikersnaam")]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Gebruikersnaam verplicht!")]
        public string UserName { get; set; }
        [Display(Name = "Wachtwoord")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Wachtwoord verplicht!")]
        public string Password { get; set; }
        [Display(Name = "Onthoud mij")]
        public bool RememberMe { get; set; }
    }
}
