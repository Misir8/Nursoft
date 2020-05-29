using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

namespace Nursoft.Models
{
    public class About
    {
        public int Id { get; set; }
        [Required, DisplayName("Mətn")]
        public string Description { get; set; }

        public string Image { get; set; }
        [NotMapped, DisplayName("Şəkil")]
        public IFormFile Photo { get; set; }
    }
}