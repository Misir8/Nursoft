using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

namespace Nursoft.Models
{
    public class Testimonial
    {
        public int Id { get; set; }
        [Required, StringLength(100), DisplayName("Ad")]
        public string Name { get; set; }
        [Required, StringLength(5000), DisplayName("Rəy")]
        public string Description { get; set; }
        [Required, StringLength(100), DisplayName("Vəzifə")]
        public string Position { get; set; }

    }
}