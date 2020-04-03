using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Nursoft.Models
{
    public class Feature
    {
        public int Id { get; set; }
        [DisplayName("Ad")]
        [Required(ErrorMessage = "Ad mütləq doldurlmalıdır"), StringLength(50,ErrorMessage = "Üstündlüyün adı maksimum 50 simvoladan ibarət ola bilər")]
        public string Name { get; set; }
        [DisplayName("Mətn")]
        [Required(ErrorMessage = "Mətn mütləq doldurlmalıdır"), StringLength(500, ErrorMessage = "Üstündlüyün mətni maksimum 50 simvoladan ibarət ola bilər")]
        public string Description { get; set; }
    }
}