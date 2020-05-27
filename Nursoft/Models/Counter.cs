using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Nursoft.Models
{
    public class Counter
    {
        public int Id { get; set; }
        [DisplayName("Razı müştərilər")]
        public int Client { get; set; }
        [DisplayName("Hazır işlər")]
        public int Project { get; set; }
        [DisplayName("Təmir olunan komputerlər")]
        public int Computer { get; set; }
    }
}
