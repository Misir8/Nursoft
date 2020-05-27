using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Nursoft.DAL;
using Nursoft.Models;

namespace Nursoft.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "admin")]
    public class MapContactController : Controller
    {
        private readonly DataContext _context;

        public MapContactController(DataContext context)
        {
            _context = context;
        }
        // GET
        public IActionResult Index()
        {
            var mapContact = _context.MapContacts.ToList();
            return View(mapContact);
        }
        
        //EDIT GET 
        public IActionResult Edit(int? id)
        {
            if (id != null)
            {
                var mapContact = _context.MapContacts.FirstOrDefault(s => s.Id == id);
                if (mapContact != null)
                {
                    return View(mapContact);
                }
            }

            return NotFound();
        }
        
        //EDIT POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(MapContact mapContact)
        {
            if (!ModelState.IsValid)
            {
                return View(mapContact);
            }

            var mapContactDb = await _context.MapContacts.FindAsync(mapContact.Id);

            mapContactDb.Lng = mapContact.Lng;
            mapContactDb.Lat = mapContact.Lat;
            await _context.SaveChangesAsync();
            TempData["warning"] = "Yerləşmə yeri uğurla dəyişdirildi";
            return RedirectToAction(nameof(Index));
        }
    }
}