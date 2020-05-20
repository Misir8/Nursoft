using System.Collections.Generic;
using Nursoft.Models;

namespace Nursoft.ViewModels
{
    public class ProductViewModel
    {
        public IEnumerable<Product> Products { get; set; }
        public Product Product { get; set; }
        public IEnumerable<CategoryProduct> CategoryProducts { get; set; }
        public CategoryProduct CategoryProduct { get; set; }
    }
}