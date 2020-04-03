using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

namespace Nursoft.Models
{
    public class Team
    {
        public int Id { get; set; }
        [DisplayName("Ad")]
        [Required(ErrorMessage = "Ad mütləq doldurlmalıdır"), StringLength(255, ErrorMessage =  "İşçinin adı maksimum 255 simvoladan ibarət ola bilər")]
        public string Name { get; set; }
        [DisplayName("Vəzifə")]
        [Required(ErrorMessage = "Vəzifə mütləq doldurlmalıdır"), StringLength(100, ErrorMessage = "Vəzifənin adı maksimum 100 simvoladan ibarət ola bilər")]
        public string Position { get; set; }

        public string Image { get; set; }
        [DisplayName("Şəkil")]
        [NotMapped]
        public IFormFile Photo { get; set; }
    }
}