using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Nursoft.DAL;
using Nursoft.Models;
using Nursoft.ViewModels;

namespace Nursoft.Controllers
{
    public class AboutController : Controller
    {
        private readonly DataContext _context;

        public AboutController(DataContext context)
        {
            _context = context;
        }
        // GET
        public async Task<IActionResult> Index()
        {
            var vm = new AboutViewModel
            {
                Abouts = await _context.Abouts.ToListAsync(),
                Teams = await _context.Teams.ToListAsync()
            };
            return View(vm);
        }
    }
}