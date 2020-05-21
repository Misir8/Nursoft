using Nursoft.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nursoft.ViewModels
{
    public class ProductCrudViewModel
    {
        public IEnumerable<Specification> Specifications { get; set; }
        public IEnumerable<Product> Products { get; set; }
        public Product Product { get; set; }
    }
}
