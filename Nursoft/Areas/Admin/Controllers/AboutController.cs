using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Nursoft.DAL;
using Nursoft.Extensions;
using Nursoft.Models;

namespace Nursoft.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AboutController : Controller
    {
        private readonly DataContext _context;
        private readonly IWebHostEnvironment _env;

        public AboutController(DataContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        // GET
        public IActionResult Index()
        {
            var abouts = _context.Abouts.ToList();
            return View(abouts);
        }
        
        //EDIT GET 
        public IActionResult Edit(int? id)
        {
            if (id != null)
            {
                var about = _context.Abouts.FirstOrDefault(s => s.Id == id);
                if (about != null)
                {
                    return View(about);
                }
            }

            return NotFound();
        }
        
        //EDIT POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(About about)
        {
            if (!ModelState.IsValid)
            {
                return View(about);
            }
            
            

            var aboutDb = await _context.Abouts.FindAsync(about.Id);
            if (about.Photo != null)
            {
                if (!about.Photo.IsImage())
                {
                    ModelState.AddModelError("Photo", "Şəkilin formatı jpg, jpeg, png, svg və ya gif formatında olmalıdır");
                    return View(about);
                }
                try
                {
                    var newPhoto = await about.Photo.SaveFileAsync(_env.WebRootPath, "images/service/");
                    IFormFileExtension.Delete(_env.WebRootPath, "images/service/", aboutDb.Image);
                    aboutDb.Image = newPhoto;
                }
                catch (Exception e)
                {

                    ModelState.AddModelError("", "Unexpected error happened while saving image. Please, try again.");
                    return View(about);
                }
            }

            aboutDb.Description = about.Description;
            await _context.SaveChangesAsync();
            TempData["warning"] = "Hqqında məlumatı uğurla dəyişdirildi";
            return RedirectToAction(nameof(Index));
        }
    }
}