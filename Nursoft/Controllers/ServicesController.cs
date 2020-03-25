using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Nursoft.DAL;
using Nursoft.Models;
using Nursoft.ViewModels;

namespace Nursoft.Controllers
{
    public class ServicesController : Controller
    {
        private readonly DataContext _context;

        public ServicesController(DataContext context)
        {
            _context = context;
        }
        // GET
        public async Task<IActionResult> Index()
        {
            var services = await _context.Services.ToListAsync();
            return View(services);
        }

        public async Task<IActionResult> Service(int? id)
        {
            if (id != null)
            {
                ServiceViewModel vm = new ServiceViewModel
                {
                    Service = await _context.Services.FirstOrDefaultAsync(s => s.Id == id),
                    Services = await _context.Services.Take(5).ToListAsync()
                };
                if (vm.Service != null)
                {
                    return View(vm);
                }
            }

            return NotFound();
        }
    }
}