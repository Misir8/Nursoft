using System.ComponentModel.DataAnnotations;

namespace Nursoft.ViewModels
{
    public class RegisterViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
 
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Parol")]
        public string Password { get; set; }
 
        [Required]
        [Compare("Password", ErrorMessage = "Parollar üst-üstə düşmür")]
        [DataType(DataType.Password)]
        [Display(Name = "Parolu təsdiq edin")]
        public string PasswordConfirm { get; set; }
    }
}