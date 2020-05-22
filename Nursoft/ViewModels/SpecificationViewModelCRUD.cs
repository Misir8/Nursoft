using Nursoft.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nursoft.ViewModels
{
    public class SpecificationViewModelCRUD
    {
        public Specification   Specification { get; set; }
        public Product Product { get; set; }
        public IEnumerable<Specification> Specifications { get; set; }
        public string Name { get; set; }
        public int ProductId { get; set; }
    }
}
