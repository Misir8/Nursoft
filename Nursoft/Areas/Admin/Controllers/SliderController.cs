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
    public class SliderController : Controller
    {
        private readonly DataContext _context;
        private readonly IWebHostEnvironment _env;

        public SliderController(DataContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        // GET
        public IActionResult Index()
        {
            var slider = _context.Sliders.ToList();
            return View(slider);
        }

        //CREATE GET
        public IActionResult Create()
        {
            return View();
        }

        //CREATE POST
        [ValidateAntiForgeryToken]
        [HttpPost]
        public async Task<IActionResult> Create(Slider slider)
        {
            if (!ModelState.IsValid)
            {
                return View(slider);
            }


            if (slider.Photo == null)
            {
                ModelState.AddModelError("error", "Zəhmət olmasa şəkil seçin");
                return View(slider);
            }

            if (!slider.Photo.IsImage())
            {
                ModelState.AddModelError("Photo", "Şəkilin formatı jpg, jpeg, png, svg və ya gif formatında olmalıdır");
                return View(slider);
            }

            if (!slider.Photo.IsLarger(5))
            {
                ModelState.AddModelError("Photo", "Şəkilin həcmi 5mg-dan çox olmamalıdır");
                return View(slider);
            }

            slider.Image = await slider.Photo.SaveFileAsync(_env.WebRootPath, "images/service/");
            await _context.Sliders.AddAsync(slider);
            await _context.SaveChangesAsync();
            TempData["success"] = "Slayder uğurla əlavə edildi";
            return RedirectToAction(nameof(Index));
        }

        //DELETE GET
        public IActionResult Delete(int? id)
        {
            if (id != null)
            {
                var slider = _context.Sliders.FirstOrDefault(s => s.Id == id);
                if (slider != null)
                {
                    return View(slider);
                }
            }

            return NotFound();
        }
        //DELETE POST
        [ValidateAntiForgeryToken]
        [HttpPost]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteSlider(int? id)
        {
            if (id != null)
            {
                var slider = await _context.Sliders.FirstOrDefaultAsync(s => s.Id == id);
                if (slider != null)
                {
                    IFormFileExtension.Delete(_env.WebRootPath, "images/service/", slider.Image);
                    _context.Sliders.Remove(slider);
                    await _context.SaveChangesAsync();
                    TempData["danger"] = "Slayder uğurla silindi";
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
                var slider = _context.Sliders.FirstOrDefault(s => s.Id == id);
                if (slider != null)
                {
                    return View(slider);
                }
            }

            return NotFound();
        }
        
        //EDIT POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Slider slider)
        {
            if (!ModelState.IsValid)
            {
                return View(slider);
            }

            var sliderDb = await _context.Sliders.FindAsync(slider.Id);
            if (slider.Photo != null)
            {
                try
                {
                    var newPhoto = await slider.Photo.SaveFileAsync(_env.WebRootPath, "images/service/");
                    IFormFileExtension.Delete(_env.WebRootPath, "images/service/", sliderDb.Image);
                    sliderDb.Image = newPhoto;
                }
                catch (Exception e)
                {

                    ModelState.AddModelError("", "Unexpected error happened while saving image. Please, try again.");
                    return View(slider);
                }
            }

            sliderDb.Title = slider.Title;
            sliderDb.Subtitle = slider.Subtitle;
            await _context.SaveChangesAsync();
            TempData["warning"] = "Slayder uğurla dəyişdirildi";
            return RedirectToAction(nameof(Index));
        }
    }
}