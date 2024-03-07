using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace Wba.FormViewModelExample.Web.ViewModels
{
    public class AccountRegisterViewModel
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Gebruikersnaam")]
        public string Username { get; set; }
        [Required]
        [Display(Name = "Wachtwoord")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [Display(Name = "Herhaal wachtwoord")]
        [DataType(DataType.Password)]
        public string RepeatPassword { get; set; }
        public IEnumerable<SelectListItem> Countries { get; set; }
        [Required]
        [Display(Name = "Land van herkomst")]
        public int SelectedCountryId { get; set; }
    }
}
