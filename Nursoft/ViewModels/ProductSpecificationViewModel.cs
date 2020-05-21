using Microsoft.AspNetCore.Http;
using Nursoft.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Nursoft.ViewModels
{
    public class ProductSpecificationViewModel
    {
        public int Id { get; set; }
        public string Image { get; set; }
        [Required(ErrorMessage = "Ad xanası boş ola bilməz"), StringLength(255, ErrorMessage = "Ad xanasında maksimum 255 simvol ola bilər")]
        [DisplayName("Ad")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Mətn xanası boş ola bilməz")]
        [DisplayName("Mətn")]
        public string Description { get; set; }
        [DisplayName("Şəkil")]
        [NotMapped]
        public IFormFile Photo { get; set; }
        public int CategoryProductId { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        [DisplayName("Qiymət")]
        public decimal Price { get; set; }
        [DisplayName("Xüsusiyyət")]
        public List<string> NameSpec { get; set; }
        public IEnumerable<Product> Products { get; set; }
        public IEnumerable<Specification> Specifications { get; set; }
        public Product Product { get; set; }
    }
}
