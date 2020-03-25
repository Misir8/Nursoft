using System.ComponentModel.DataAnnotations;

namespace Nursoft.Models
{
    public class ContactUs
    {
        public int Id { get; set; }
        [Required, StringLength(255)]
        public string Address { get; set; }
        [Required, StringLength(50)]
        public string Email { get; set; }
        [Required, StringLength(50)]
        public string Phone { get; set; }
    }
}