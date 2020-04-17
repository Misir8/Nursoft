using System.Collections.Generic;
using Nursoft.Models;

namespace Nursoft.ViewModels
{
    public class ServiceViewModel
    {
        public IEnumerable<Models.Service> Services { get; set; }
        public Models.Service Service { get; set; }
    }
}