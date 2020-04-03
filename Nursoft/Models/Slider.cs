using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

namespace Nursoft.Models
{
    public class Slider
    {
        public int Id { get; set; }
        [StringLength(50, ErrorMessage = "Maksimum 50 simvol ola bilər")]
        [DisplayName("Başlıq")]
        public string Title { get; set; }
        [StringLength(255)]
        [DisplayName("Altbaşlıq")]
        public string Subtitle { get; set; }
        [DisplayName("Şəkil")]
        public string Image { get; set; }
        [DisplayName("Şəkil")]
        [NotMapped]
        public IFormFile Photo { get; set; }
    }
}