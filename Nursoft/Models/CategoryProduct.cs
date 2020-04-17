using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Nursoft.Models
{
    public class CategoryProduct
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Ad xanası boş ola bilməz"), StringLength(255, ErrorMessage = "Ad xanasında maksimum 255 simvol ola bilər")]
        [DisplayName("Ad")]
        public string Name { get; set; }
        public List<Product> Products { get; set; }
    }
}