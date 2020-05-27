using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Nursoft.DAL;
using Nursoft.Extensions;
using Nursoft.Models;

namespace Nursoft.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "admin")]
    public class ServiceController : Controller
    {
        private readonly DataContext _context;
        private readonly IWebHostEnvironment _env;

        public ServiceController(DataContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        // GET
        public IActionResult Index()
        {
            var services = _context.Services.ToList();
            return View(services);
        }
        
        //CREATE GET
        public IActionResult Create()
        {
            return View();
        }

        //CREATE POST
        [ValidateAntiForgeryToken]
        [HttpPost]
        public async Task<IActionResult> Create(Models.Service service)
        {
            if (!ModelState.IsValid)
            {
                return View(service);
            }


            if (service.Photo == null)
            {
                ModelState.AddModelError("error", "Zəhmət olmasa şəkil seçin");
                return View(service);
            }

            if (!service.Photo.IsImage())
            {
                ModelState.AddModelError("Photo", "Şəkilin formatı jpg, jpeg, png, svg və ya gif formatında olmalıdır");
                return View(service);
            }

            if (!service.Photo.IsLarger(5))
            {
                ModelState.AddModelError("Photo", "Şəkilin həcmi 5mg-dan çox olmamalıdır");
                return View(service);
            }

            service.Image = await service.Photo.SaveFileAsync(_env.WebRootPath, "images/service/");
            await _context.Services.AddAsync(service);
            await _context.SaveChangesAsync();
            TempData["success"] = "Xidmət uğurla əlavə edildi";
            return RedirectToAction(nameof(Index));
        }
        
        //DELETE GET
        public IActionResult Delete(int? id)
        {
            if (id != null)
            {
                var service = _context.Services.FirstOrDefault(s => s.Id == id);
                if (service != null)
                {
                    return View(service);
                }
            }

            return NotFound();
        }
        //DELETE POST
        [ValidateAntiForgeryToken]
        [HttpPost]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteService(int? id)
        {
            if (id != null)
            {
                var service = await _context.Services.FirstOrDefaultAsync(s => s.Id == id);
                if (service != null)
                {
                    IFormFileExtension.Delete(_env.WebRootPath, "images/service/", service.Image);
                    _context.Services.Remove(service);
                    await _context.SaveChangesAsync();
                    TempData["danger"] = "Xidmət uğurla silindi";
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
                var service = _context.Services.FirstOrDefault(s => s.Id == id);
                if (service != null)
                {
                    return View(service);
                }
            }

            return NotFound();
        }
        
        //EDIT POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Models.Service service)
        {
            if (!ModelState.IsValid)
            {
                return View(service);
            }
            
           
            
            

            var serviceDb = await _context.Services.FindAsync(service.Id);
            if (service.Photo != null)
            {
                if (!service.Photo.IsImage())
                {
                    ModelState.AddModelError("Photo", "Şəkilin formatı jpg, jpeg, png, svg və ya gif formatında olmalıdır");
                    return View(service);
                }
                try
                {
                    var newPhoto = await service.Photo.SaveFileAsync(_env.WebRootPath, "images/service/");
                    IFormFileExtension.Delete(_env.WebRootPath, "images/service/", serviceDb.Image);
                    serviceDb.Image = newPhoto;
                }
                catch (Exception e)
                {

                    ModelState.AddModelError("", "Unexpected error happened while saving image. Please, try again.");
                    return View(service);
                }
            }

            serviceDb.Name = service.Name;
            serviceDb.Description = service.Description;
            await _context.SaveChangesAsync();
            TempData["warning"] = "Xidmət uğurla dəyişdirildi";
            return RedirectToAction(nameof(Index));
        }

    }
}