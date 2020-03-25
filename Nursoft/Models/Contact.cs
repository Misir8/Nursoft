using System.ComponentModel.DataAnnotations;

namespace Nursoft.Models
{
    public class Contact
    {
        public int Id { get; set; }
        [Required, StringLength(255)]
        public string Name { get; set; }
        [Required, EmailAddress, StringLength(255)]
        public string Email { get; set; }
        [Required]
        public string Message { get; set; }
    }
}