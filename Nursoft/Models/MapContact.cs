using System.ComponentModel.DataAnnotations;

namespace Nursoft.Models
{
    public class MapContact
    {
        public int Id { get; set; }
        [Required, StringLength(255)]
        public string Lat { get; set; }
        [Required, StringLength(255)]
        public string Lng { get; set; }
    }
}