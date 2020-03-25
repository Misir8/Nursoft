using System.Collections.Generic;
using Nursoft.Models;

namespace Nursoft.ViewModels
{
    public class ServiceViewModel
    {
        public IEnumerable<Service> Services { get; set; }
        public Service Service { get; set; }
    }
}