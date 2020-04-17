using System.ComponentModel.DataAnnotations;

namespace Nursoft.ViewModels
{
    public class ResetPasswordViewModel
    {
        [Required(ErrorMessage = "Email xanası boş ola bilməz")]
        [EmailAddress(ErrorMessage = "Düzgün email daxil edin")]
        public string Email { get; set; }
 
        [Required]
        [StringLength(100, ErrorMessage = "Parolda minimum 6 simvol olmalıdır", MinimumLength = 6)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
 
        [DataType(DataType.Password)]
        [Display(Name = "Parolu təstiqlə")]
        [Compare("Password", ErrorMessage = "Parollar üst-üstə düşmür")]
        public string ConfirmPassword { get; set; }
 
        public string Code { get; set; }
    }
}