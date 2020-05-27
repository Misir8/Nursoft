using System.Collections.Generic;
using Nursoft.Models;

namespace Nursoft.ViewModels
{
    public class HomeIndexViewModel
    {
        public IEnumerable<Slider> Sliders { get; set; }
        public IEnumerable<Repair> Repairs { get; set; }
        public IEnumerable<Feature> Features { get; set; }
        public IEnumerable<Models.Service> Services { get; set; }
        public IEnumerable<Testimonial> Testimonials { get; set; }
        public IEnumerable<Counter> Counters { get; set; }
    }
}