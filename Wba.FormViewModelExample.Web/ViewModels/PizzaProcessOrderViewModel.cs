using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace Wba.FormViewModelExample.Web.ViewModels
{
    public class PizzaProcessOrderViewModel
    {
        [Required(ErrorMessage = "Email verplicht!")]
        [DataType(DataType.EmailAddress,ErrorMessage = "Geldig emailadres verplicht!")]
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Required]
        [Range(1,20,ErrorMessage = "Minstens 1 en max 20 stuks!")]
        [Display(Name = "Hoeveel:")]
        public int Quantity { get; set; }
        public IEnumerable<SelectListItem> Pizzas { get; set; }
        [Required(ErrorMessage = "Pizza verplicht!")]
        [Display(Name = "Pizza")]
        public int SelectedPizzaId { get; set; }
        public IEnumerable<SelectListItem> Sizes { get; set; }
        [Required(ErrorMessage = "Size verplicht!")]
        [Display(Name = "Size")]
        public int SelectedSizeId { get; set; }

        //multiple dropdown
        public IEnumerable<SelectListItem> ExtraToppings { get; set; }

        [Display(Name = "Extra toppings")]
        public IEnumerable<int> SelectedExtraToppings { get; set; }
    }
}
