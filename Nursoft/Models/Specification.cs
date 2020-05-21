using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Nursoft.Models
{
    public class Specification
    {
        public int Id { get; set; }
        [DisplayName("Xüsusiyyət")]
        public string Name { get; set; }
        public Product Product { get; set; }
        public int Productİd { get; set; }
    }
}
