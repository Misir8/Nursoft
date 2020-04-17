using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

namespace Nursoft.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Ad xanası boş ola bilməz"), StringLength(255, ErrorMessage = "Ad xanasında maksimum 255 simvol ola bilər")]
        [DisplayName("Ad")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Mətn xanası boş ola bilməz")]
        [DisplayName("Mətn")]
        public string Description { get; set; }
        public string Image { get; set; }
        [DisplayName("Şəkil")]
        [NotMapped]
        public IFormFile Photo { get; set; }
        [DisplayName("Kateqoriya")]
        public CategoryProduct CategoryProduct { get; set; }
        public int CategoryProductId { get; set; }
    }
}