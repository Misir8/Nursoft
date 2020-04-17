using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Nursoft.Models
{
    public class News
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Ad xanası boş ola bilməz"), StringLength(255, ErrorMessage = "Ad xanasında maksimum 255 simvol ola bilər")]
        [DisplayName("Ad")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Alt başlıq xanası boş ola bilməz"), StringLength(1000, ErrorMessage = "Alt başlıq xanasında maksimum 1000 simvol ola bilər")]
        [DisplayName("Alt başlıq")]
        public string Subtitle { get; set; }
        [Required(ErrorMessage = "Mətn xanası boş ola bilməz")]
        [DisplayName("Mətn")]
        public string Text { get; set; }
        [StringLength(255)]
        public string Image { get; set; }
        [NotMapped]
        [DisplayName("Şəkil")]
        public IFormFile Photo { get; set; }
    }
}
