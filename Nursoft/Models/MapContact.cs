using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Nursoft.Models
{
    public class MapContact
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "ŞM.E xanası boş ola bilməz"), StringLength(255, ErrorMessage = "ŞM.E xanasında maksimum 255 simvol ola bilər")]
        [DisplayName("ŞM.E")]
        public string Lat { get; set; }
        [Required(ErrorMessage = "Ş.U xanası boş ola bilməz"), StringLength(255, ErrorMessage = "Ş.U xanasında maksimum 255 simvol ola bilər")]
        [DisplayName("Ş.U")]
        public string Lng { get; set; }
    }
}