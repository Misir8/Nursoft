using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Nursoft.Models
{
    public class Contact
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Ad xanası boş ola bilməz"), StringLength(255, ErrorMessage = "Ad xanasında maksimum 255 simvol ola bilər")]
        [DisplayName("Ad")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Email xanası boş ola bilməz"), EmailAddress, StringLength(255, ErrorMessage = "Email xanasında maksimum 255 simvol ola bilər")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Messaj xanası boş ola bilməz")]
        [DisplayName("Mesaj")]
        public string Message { get; set; }
    }
}