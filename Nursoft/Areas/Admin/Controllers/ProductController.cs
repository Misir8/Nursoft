using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Nursoft.DAL;
using Nursoft.Extensions;
using Nursoft.Models;

namespace Nursoft.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        private readonly DataContext _context;
        private readonly IWebHostEnvironment _env;

        public ProductController(DataContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        // GET
        public IActionResult Index()
        {
            var products = _context.Products.ToList();
            return View(products);
        }
        
        //CREATE GET
        public IActionResult Create()
        {
            ViewBag.Categories = new SelectList(_context.CategoryProducts, "Id", "Name");
            return View();
        }

        //CREATE POST
        [ValidateAntiForgeryToken]
        [HttpPost]
        public async Task<IActionResult> Create(Product product)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Categories = new SelectList(_context.CategoryProducts, "Id", "Name");
                return View(product);
            }


            if (product.Photo == null)
            {
                ModelState.AddModelError("error", "Zəhmət olmasa şəkil seçin");
                return View(product);
            }

            if (!product.Photo.IsImage())
            {
                ModelState.AddModelError("Photo", "Şəkilin formatı jpg, jpeg, png, svg və ya gif formatında olmalıdır");
                return View(product);
            }

            if (!product.Photo.IsLarger(5))
            {
                ModelState.AddModelError("Photo", "Şəkilin həcmi 5mg-dan çox olmamalıdır");
                return View(product);
            }

            product.Image = await product.Photo.SaveFileAsync(_env.WebRootPath, "images/shop/");
            await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync();
            TempData["success"] = "Məhsul uğurla əlavə edildi";
            return RedirectToAction(nameof(Index));
        }
        
        //DELETE GET
        public IActionResult Delete(int? id)
        {
            if (id != null)
            {
                var product = _context.Products.FirstOrDefault(s => s.Id == id);
                if (product != null)
                {
                    return View(product);
                }
            }

            return NotFound();
        }
        //DELETE POST
        [ValidateAntiForgeryToken]
        [HttpPost]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteProduct(int? id)
        {
            if (id != null)
            {
                var product = await _context.Products.FirstOrDefaultAsync(s => s.Id == id);
                if (product != null)
                {
                    IFormFileExtension.Delete(_env.WebRootPath, "images/shop/", product.Image);
                    _context.Products.Remove(product);
                    await _context.SaveChangesAsync();
                    TempData["danger"] = "Məhsul uğurla silindi";
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
                var product = _context.Products.FirstOrDefault(s => s.Id == id);
                if (product != null)
                {
                    ViewBag.Categories = new SelectList(_context.CategoryProducts, "Id", "Name");
                    return View(product);
                }
            }

            return NotFound();
        }
        
        //EDIT POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Product product)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Categories = new SelectList(_context.CategoryProducts, "Id", "Name");
                return View(product);
            }
            
            var productDb = await _context.Products.FindAsync(product.Id);
            if (product.Photo != null)
            {
                if (!product.Photo.IsImage())
                {
                    ModelState.AddModelError("Photo", "Şəkilin formatı jpg, jpeg, png, svg və ya gif formatında olmalıdır");
                    return View(product);
                }
                try
                {
                    var newPhoto = await product.Photo.SaveFileAsync(_env.WebRootPath, "images/shop/");
                    IFormFileExtension.Delete(_env.WebRootPath, "images/shop/", productDb.Image);
                    productDb.Image = newPhoto;
                }
                catch (Exception e)
                {

                    ModelState.AddModelError("", "Unexpected error happened while saving image. Please, try again.");
                    return View(product);
                }
            }

            productDb.Name = product.Name;
            productDb.Description = product.Description;
            productDb.CategoryProductId = product.CategoryProductId;
            productDb.Price = product.Price;
            await _context.SaveChangesAsync();
            TempData["warning"] = "Məhsul uğurla dəyişdirildi";
            return RedirectToAction(nameof(Index));
        }
    }
}