using System.ComponentModel.DataAnnotations;

namespace Nursoft.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Email xanası boş ola bilməz")]
        [Display(Name = "Email")]
        public string Email { get; set; }
 
        [Required(ErrorMessage = "Parol xanası boş ola bilməz")]
        [DataType(DataType.Password)]
        [Display(Name = "Parol")]
        public string Password { get; set; }
 
        [Display(Name = "Yadda saxla?")]
        public bool RememberMe { get; set; }
 
        public string ReturnUrl { get; set; }
    }
}