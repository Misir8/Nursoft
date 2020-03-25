using System.Collections.Generic;
using Nursoft.Models;

namespace Nursoft.ViewModels
{
    public class AboutViewModel
    {
        public IEnumerable<About> Abouts { get; set; }
        public IEnumerable<Team> Teams { get; set; }
    }
}