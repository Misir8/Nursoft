using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Nursoft.Models
{
    public class CategoryProduct
    {
        public int Id { get; set; }
        [Required, StringLength(255)]
        public string Name { get; set; }
        public List<Product> Products { get; set; }
    }
}