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
    public class NewsController : Controller
    {
        private readonly DataContext _context;
        private readonly IWebHostEnvironment _env;

        public NewsController(DataContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        // GET
        public IActionResult Index()
        {
            var news = _context.News.ToList();
            return View(news);
        }
        
        //CREATE GET
        public IActionResult Create()
        {
            return View();
        }

        //CREATE POST
        [ValidateAntiForgeryToken]
        [HttpPost]
        public async Task<IActionResult> Create(News news)
        {
            if (!ModelState.IsValid)
            {
                return View(news);
            }


            if (news.Photo == null)
            {
                ModelState.AddModelError("error", "Zəhmət olmasa şəkil seçin");
                return View(news);
            }

            if (!news.Photo.IsImage())
            {
                ModelState.AddModelError("Photo", "Şəkilin formatı jpg, jpeg, png, svg və ya gif formatında olmalıdır");
                return View(news);
            }

            if (!news.Photo.IsLarger(5))
            {
                ModelState.AddModelError("Photo", "Şəkilin həcmi 5mg-dan çox olmamalıdır");
                return View(news);
            }

            news.Image = await news.Photo.SaveFileAsync(_env.WebRootPath, "images/outsource/");
            await _context.News.AddAsync(news);
            await _context.SaveChangesAsync();
            TempData["success"] = "Xəbər uğurla əlavə edildi";
            return RedirectToAction(nameof(Index));
        }
        
        //DELETE GET
        public IActionResult Delete(int? id)
        {
            if (id != null)
            {
                var news = _context.News.FirstOrDefault(s => s.Id == id);
                if (news != null)
                {
                    return View(news);
                }
            }

            return NotFound();
        }
        //DELETE POST
        [ValidateAntiForgeryToken]
        [HttpPost]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteNews(int? id)
        {
            if (id != null)
            {
                var news = await _context.News.FirstOrDefaultAsync(s => s.Id == id);
                if (news != null)
                {
                    IFormFileExtension.Delete(_env.WebRootPath, "images/outsource/", news.Image);
                    _context.News.Remove(news);
                    await _context.SaveChangesAsync();
                    TempData["danger"] = "Xəbər uğurla silindi";
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
                var news = _context.News.FirstOrDefault(s => s.Id == id);
                if (news != null)
                {
                    return View(news);
                }
            }

            return NotFound();
        }
        
        //EDIT POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(News news)
        {
            if (!ModelState.IsValid)
            {
                return View(news);
            }
            

            var newsDb = await _context.News.FindAsync(news.Id);
            if (news.Photo != null)
            {
                if (!news.Photo.IsImage())
                {
                    ModelState.AddModelError("Photo", "Şəkilin formatı jpg, jpeg, png, svg və ya gif formatında olmalıdır");
                    return View(news);
                }
                try
                {
                    var newPhoto = await news.Photo.SaveFileAsync(_env.WebRootPath, "images/outsource/");
                    IFormFileExtension.Delete(_env.WebRootPath, "images/outsource/", newsDb.Image);
                    newsDb.Image = newPhoto;
                }
                catch (Exception e)
                {

                    ModelState.AddModelError("", "Unexpected error happened while saving image. Please, try again.");
                    return View(news);
                }
            }

            newsDb.Name = news.Name;
            newsDb.Subtitle = news.Subtitle;
            newsDb.Text = news.Text;
            await _context.SaveChangesAsync();
            TempData["warning"] = "Xəbər uğurla dəyişdirildi";
            return RedirectToAction(nameof(Index));
        }
    }
}