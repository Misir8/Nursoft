using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Nursoft.DAL;
using Nursoft.Extensions;
using Nursoft.Models;
using Nursoft.ViewModels;

namespace Nursoft.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "admin")]
    public class ProductController : Controller
    {
        private readonly DataContext _context;
        private readonly IWebHostEnvironment _env;
        private Product productt;

        public ProductController(DataContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        // GET
        public async Task<IActionResult> Index()
        {
            var products = new ProductCrudViewModel
            {
                Products = await _context.Products.ToListAsync()
            };
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
        public async Task<IActionResult> Create(ProductSpecificationViewModel psVM)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Categories = new SelectList(_context.CategoryProducts, "Id", "Name");
                return View(psVM);
            }


            if (psVM.Photo == null)
            {
                ModelState.AddModelError("error", "Zəhmət olmasa şəkil seçin");
                return View(psVM);
            }

            if (!psVM.Photo.IsImage())
            {
                ModelState.AddModelError("Photo", "Şəkilin formatı jpg, jpeg, png, svg və ya gif formatında olmalıdır");
                return View(psVM);
            }

            if (!psVM.Photo.IsLarger(5))
            {
                ModelState.AddModelError("Photo", "Şəkilin həcmi 5mg-dan çox olmamalıdır");
                return View(psVM);
            }

            productt = new Product
            {
                Name = psVM.Name,
                Image = await psVM.Photo.SaveFileAsync(_env.WebRootPath, "images/shop/"),
                CategoryProductId = psVM.CategoryProductId,
                Description = psVM.Description,
                Price = psVM.Price,
            };


            await _context.Products.AddAsync(productt);
            await _context.SaveChangesAsync();

            for (int i = 0; i < psVM.NameSpec.Count(); i++)
            {
                Specification specification = new Specification
                {
                    Name = psVM.NameSpec.ElementAt(i),
                    Productİd = productt.Id
                };
                await _context.Specifications.AddRangeAsync(specification);
                await _context.SaveChangesAsync();
            }

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
        public async Task<IActionResult> Edit(int? id)
        {
            if (id != null)
            {
                var prod = await _context.Products.FirstOrDefaultAsync(s => s.Id == id);

                ProductSpecificationViewModel vm = new ProductSpecificationViewModel
                {
                    Product = await _context.Products.FirstOrDefaultAsync(s => s.Id == id),
                    Specifications = _context.Specifications.Include(x => x.Productİd == id),
                    Name = prod.Name,
                    CategoryProductId = prod.CategoryProductId,
                    Description = prod.Description,
                    Photo = prod.Photo,
                    Price = prod.Price,
                    Id = prod.Id,
                    Image = prod.Image,
                };
                if (vm.Product != null)
                {
                    ViewBag.Categories = new SelectList(_context.CategoryProducts, "Id", "Name");
                    return View(vm);
                }
            }

            return NotFound();
        }

        //EDIT POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(ProductSpecificationViewModel product)
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

        public async Task<IActionResult> Specification(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var product = await _context.Products.FirstOrDefaultAsync(x => x.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            SpecificationViewModelCRUD vm = new SpecificationViewModelCRUD
            {
                Specifications = await _context.Specifications.Where(x => x.Productİd == id).ToListAsync(),
                Product = product
            };

            return View(vm);
        }
        [HttpPost]
        public IActionResult SpecCreate(SpecificationViewModelCRUD vm)
        {
            if (!ModelState.IsValid)
            {
                return View(vm);
            }

            Specification specification = new Specification
            {
                Name = vm.Name,
                Productİd = vm.ProductId
            };
             _context.Specifications.Add(specification);
             _context.SaveChanges();
            TempData["success"] = "Xüsusiyyət uğurla əlavə edildi";
            return RedirectToAction(nameof(Specification), new { id = vm.ProductId });
        }

        
        public async Task<IActionResult> DeleteSpec(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var spec = await _context.Specifications.FirstOrDefaultAsync(s => s.Id == id);
            var myId = spec.Productİd;
            if (spec == null)
            {
                return NotFound();
            }
            _context.Specifications.Remove(spec);
            await _context.SaveChangesAsync();
            TempData["danger"] = "Xüsusiyyət uğurla silindi";
            return RedirectToAction(nameof(Specification), new { id = myId });
        }

        public async Task<IActionResult> EditSpec(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var spec = await _context.Specifications.FirstOrDefaultAsync(x => x.Id == id);

            if (spec == null)
            {
                return NotFound();
            }

            return View(spec);
        }

        [HttpPost]
        public async Task<IActionResult> EditSpec(Specification specification)
        {
            if (!ModelState.IsValid)
            {
                return View(specification);
            }

            var specDb = await _context.Specifications.FirstOrDefaultAsync(x => x.Id == specification.Id);
            specDb.Name = specification.Name;
            await _context.SaveChangesAsync();



            TempData["warning"] = "Xüsusiyyət uğurla dəyişdirildi";
            return RedirectToAction(nameof(Specification), new { id = specDb.Productİd });

        }
    }
}