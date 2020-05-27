using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Nursoft.DAL;
using Nursoft.Models;

namespace Nursoft.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "admin")]
    public class FeatureController : Controller
    {
        private readonly DataContext _context;

        public FeatureController(DataContext context)
        {
            _context = context;
        }
        // GET
        public IActionResult Index()
        {
            var features = _context.Features.ToList();
            return View(features);
        }
        
        //EDIT GET 
        public IActionResult Edit(int? id)
        {
            if (id != null)
            {
                var feature = _context.Features.FirstOrDefault(s => s.Id == id);
                if (feature != null)
                {
                    return View(feature);
                }
            }

            return NotFound();
        }
        
        //EDIT POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Feature feature)
        {
            if (!ModelState.IsValid)
            {
                return View(feature);
            }

            var featureDb = await _context.Features.FindAsync(feature.Id);

            featureDb.Name = feature.Name;
            featureDb.Description = feature.Description;
            await _context.SaveChangesAsync();
            TempData["warning"] = "Üstünlük uğurla dəyişdirildi";
            return RedirectToAction(nameof(Index));
        }
    }
}