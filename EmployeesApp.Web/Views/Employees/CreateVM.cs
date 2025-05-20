using EmployeesApp.Web.Models;
using System.ComponentModel.DataAnnotations;

namespace EmployeesApp.Web.Views.Employees
{
    public class CreateVM
    {

        [Required(ErrorMessage = "You must specify a name")]
        [SuspiciousPerson("Pontus Wittenmark", ErrorMessage = "Suspicious person detected!")]
        public string Name { get; set; }

        [Display(Name = "E-mail")]
        [EmailAddress(ErrorMessage = "Invalid e-mail address")]
        [Required(ErrorMessage = "You must specify an e-mail address")]
        public string Email { get; set; } = null!;

        [Display(Name = "What is 2 + 2?")]
        [Range(4, 4, ErrorMessage = "Incorrect answer")]
        [Required(ErrorMessage = "Please answer the overlord")]
        public int BotCheck { get; set; } = 4;
    }
}
