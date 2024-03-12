using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace Wba.FormViewModelExample.Web.ViewModels
{
    public class AccountRegisterViewModel
    {
        [Required(ErrorMessage = "Gebruikersnaam verplicht")]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Gebruikersnaam")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Wachtwoord verplicht!")]
        [Display(Name = "Wachtwoord")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required(ErrorMessage = "Herhaal wachtwoord")]
        [Compare("Password",ErrorMessage = "Wachtwoorden moeten gelijk zijn!")]
        [Display(Name = "Herhaal wachtwoord")]
        [DataType(DataType.Password)]
        public string RepeatPassword { get; set; }
        public IEnumerable<SelectListItem> Countries { get; set; }
        [Required(ErrorMessage = "Land van herkomst verplicht!")]
        [Display(Name = "Land van herkomst")]
        public int SelectedCountryId { get; set; }
    }
}
