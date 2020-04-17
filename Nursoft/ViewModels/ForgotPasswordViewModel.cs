using System.ComponentModel.DataAnnotations;

namespace Nursoft.ViewModels
{
    public class ForgotPasswordViewModel
    {
        [Required(ErrorMessage = "Email xanası boş ola bilməz")]
        [EmailAddress(ErrorMessage = "Düzgün email daxil edin")]
        public string Email { get; set; }
    }
}