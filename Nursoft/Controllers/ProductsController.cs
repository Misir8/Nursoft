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
        public async Task<IActionResult> Index(int? category, string name, int page = 1,
            SortState sortOrder = SortState.NameAsc)
        {
            int pageSize = 4;

            //фильтрация
            IQueryable<Product> products = _context.Products.Include(x => x.CategoryProduct);

            if (category != null && category != 0)
            {
                products = products.Where(p => p.CategoryProductId == category);
            }
            if (!String.IsNullOrEmpty(name))
            {
                products = products.Where(p => p.Name.Contains(name));
            }

            // сортировка
            switch (sortOrder)
            {
                case SortState.NameDesc:
                    products = products.OrderByDescending(s => s.Name);
                    break;
                case SortState.AgeAsc:
                case SortState.CategoryAsc:
                    products = products.OrderBy(s => s.CategoryProduct.Name);
                    break;
                case SortState.CategoryDesc:
                    products = products.OrderByDescending(s => s.CategoryProduct.Name);
                    break;
                default:
                    products = products.OrderBy(s => s.Name);
                    break;
            }

            // пагинация
            var count = await products.CountAsync();
            var items = await products.Skip((page - 1) * pageSize).Take(pageSize).ToListAsync();

            // формируем модель представления
            ProductAndCategoryViewModel viewModel = new ProductAndCategoryViewModel
            {
                PageViewModel = new PageViewModel(count, page, pageSize),
                SortViewModel = new SortViewModel(sortOrder),
                FilterViewModel = new FilterViewModel(_context.CategoryProducts.ToList(), category, name),
                Products = items,
                CategoryProducts = await _context.CategoryProducts.ToListAsync()
            };
            return View(viewModel);

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


       
    }
}