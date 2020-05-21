using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Nursoft.DAL;
using Nursoft.Models;
using Nursoft.ViewModels;

namespace Nursoft.Controllers
{
    public class ProductsController : Controller
    {
        private readonly DataContext _context;

        public ProductsController(DataContext context)
        {
            _context = context;
        }

        // GET
        public IActionResult Index(int p = 1)
        {
            int pageSize = 8;
            
            var vm = new ProductViewModel
            {
                Products =  _context.Products.Skip((p-1)* pageSize).Take(pageSize),
                CategoryProducts =  _context.CategoryProducts.ToList()
            };
            ViewBag.Page = p;
            ViewBag.PageRange = pageSize;
            ViewBag.TotalPages = (int) Math.Ceiling((decimal) _context.Products.Count() / pageSize);
            if (p > ViewBag.TotalPages || p <= 0)
            {
                return NotFound();
            }
            return View(vm);
            
        }

        public async Task<IActionResult> CategoryDetails(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var vm = new ProductViewModel
            {
                Products = await _context.Products.ToListAsync(),
                CategoryProduct = await _context.CategoryProducts.FirstOrDefaultAsync(c => c.Id == id),
                CategoryProducts = await _context.CategoryProducts.ToListAsync()
            };
            if (vm.CategoryProduct == null)
            {
                return NotFound();
            }

            return View(vm);
        }

        public async Task<IActionResult> ProductDetails(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var product = await _context.Products.FirstOrDefaultAsync(p => p.Id == id);
            var productVM = new ProductViewModel
            {
                Product = product,
                CategoryProduct = await _context.CategoryProducts.FirstOrDefaultAsync(c => c.Id == product.CategoryProductId),
                CategoryProducts = await _context.CategoryProducts.ToListAsync(),
                Specifications = await _context.Specifications.ToListAsync()
            };
            if (productVM.Product == null)
            {
                return NotFound();
            }

            return View(productVM);
        }


        public async Task<IActionResult> GetProduct(string query)
        {
            switch (query)
            {
                case "asc":
                    var vm = new ProductViewModel
                    {
                        Products = await _context.Products.OrderBy(p => p.Name).Take(6).ToListAsync(),
                        CategoryProducts = await _context.CategoryProducts.ToListAsync()
                    };
                    return PartialView("_GetProductPartial", vm);
                case "desc":
                    var vmD = new ProductViewModel
                    {
                        Products = await _context.Products.OrderByDescending(p => p.Name).Take(6).ToListAsync(),
                        CategoryProducts = await _context.CategoryProducts.ToListAsync()
                    };
                    return PartialView("_GetProductPartial", vmD);
                default:
                    var vmDD = new ProductViewModel
                    {
                        Products = await _context.Products.ToListAsync(),
                        CategoryProducts = await _context.CategoryProducts.ToListAsync()
                    };
                    return PartialView("_GetProductPartial", vmDD);
            }
        }
    }
}