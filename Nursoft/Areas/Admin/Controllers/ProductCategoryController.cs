using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Nursoft.DAL;
using Nursoft.Extensions;
using Nursoft.Models;

namespace Nursoft.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductCategoryController : Controller
    {
        private readonly DataContext _context;

        public ProductCategoryController(DataContext context)
        {
            _context = context;
        }
        // GET
        public IActionResult Index()
        {
            var categories = _context.CategoryProducts.ToList();
            return View(categories);
        }
        
        //CREATE GET
        public IActionResult Create()
        {
            return View();
        }

        //CREATE POST
        [ValidateAntiForgeryToken]
        [HttpPost]
        public async Task<IActionResult> Create(CategoryProduct category)
        {
            if (!ModelState.IsValid)
            {
                return View(category);
            }
            await _context.CategoryProducts.AddAsync(category);
            await _context.SaveChangesAsync();
            TempData["success"] = "Məhsul kateqoriyası uğurla əlavə edildi";
            return RedirectToAction(nameof(Index));
        }
        
        //DELETE GET
        public IActionResult Delete(int? id)
        {
            if (id != null)
            {
                var category = _context.CategoryProducts.FirstOrDefault(s => s.Id == id);
                if (category != null)
                {
                    return View(category);
                }
            }

            return NotFound();
        }
        //DELETE POST
        [ValidateAntiForgeryToken]
        [HttpPost]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteCategory(int? id)
        {
            if (id != null)
            {
                var category = await _context.CategoryProducts.FirstOrDefaultAsync(s => s.Id == id);
                if (category != null)
                {
                    _context.CategoryProducts.Remove(category);
                    await _context.SaveChangesAsync();
                    TempData["danger"] = "Məhsul kateqoriyası uğurla silindi";
                    return RedirectToAction(nameof(Index));
                }
            }

            return NotFound();
        }
        
        //EDIT GET 
        public IActionResult Edit(int? id)
        {
            if (id != null)
            {
                var category = _context.CategoryProducts.FirstOrDefault(s => s.Id == id);
                if (category != null)
                {
                    return View(category);
                }
            }

            return NotFound();
        }
        
        //EDIT POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(CategoryProduct category)
        {
            if (!ModelState.IsValid)
            {
                return View(category);
            }
            
            var categoryDb = await _context.CategoryProducts.FindAsync(category.Id);
            
            categoryDb.Name = category.Name;
            await _context.SaveChangesAsync();
            TempData["warning"] = "Məhsul kateqoriyası uğurla dəyişdirildi";
            return RedirectToAction(nameof(Index));
        }

    }
}