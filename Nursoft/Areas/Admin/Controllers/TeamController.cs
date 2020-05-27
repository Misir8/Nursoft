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
    public class TeamController : Controller
    {
        private readonly DataContext _context;
        private readonly IWebHostEnvironment _env;

        public TeamController(DataContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        // GET
        public IActionResult Index()
        {
            var teams = _context.Teams.ToList();
            return View(teams);
        }
        
        //CREATE GET
        public IActionResult Create()
        {
            return View();
        }

        //CREATE POST
        [ValidateAntiForgeryToken]
        [HttpPost]
        public async Task<IActionResult> Create(Team team)
        {
            if (!ModelState.IsValid)
            {
                return View(team);
            }


            if (team.Photo == null)
            {
                ModelState.AddModelError("error", "Zəhmət olmasa şəkil seçin");
                return View(team);
            }

            if (!team.Photo.IsImage())
            {
                ModelState.AddModelError("Photo", "Şəkilin formatı jpg, jpeg, png, svg və ya gif formatında olmalıdır");
                return View(team);
            }

            if (!team.Photo.IsLarger(5))
            {
                ModelState.AddModelError("Photo", "Şəkilin həcmi 5mg-dan çox olmamalıdır");
                return View(team);
            }

            team.Image = await team.Photo.SaveFileAsync(_env.WebRootPath, "images/outsource/");
            await _context.Teams.AddAsync(team);
            await _context.SaveChangesAsync();
            TempData["success"] = "İşçi uğurla əlavə edildi";
            return RedirectToAction(nameof(Index));
        }
        
        //DELETE GET
        public IActionResult Delete(int? id)
        {
            if (id != null)
            {
                var team = _context.Teams.FirstOrDefault(s => s.Id == id);
                if (team != null)
                {
                    return View(team);
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
                var team = await _context.Teams.FirstOrDefaultAsync(s => s.Id == id);
                if (team != null)
                {
                    IFormFileExtension.Delete(_env.WebRootPath, "images/outsource/", team.Image);
                    _context.Teams.Remove(team);
                    await _context.SaveChangesAsync();
                    TempData["danger"] = "İşçi uğurla silindi";
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
                var team = _context.Teams.FirstOrDefault(s => s.Id == id);
                if (team != null)
                {
                    return View(team);
                }
            }

            return NotFound();
        }
        
        //EDIT POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Team team)
        {
            if (!ModelState.IsValid)
            {
                return View(team);
            }
            
           
            
            

            var teamDb = await _context.Teams.FindAsync(team.Id);
            if (team.Photo != null)
            {
                if (!team.Photo.IsImage())
                {
                    ModelState.AddModelError("Photo", "Şəkilin formatı jpg, jpeg, png, svg və ya gif formatında olmalıdır");
                    return View(team);
                }
                try
                {
                    var newPhoto = await team.Photo.SaveFileAsync(_env.WebRootPath, "images/outsource/");
                    IFormFileExtension.Delete(_env.WebRootPath, "images/outsource/", teamDb.Image);
                    teamDb.Image = newPhoto;
                }
                catch (Exception e)
                {

                    ModelState.AddModelError("", "Unexpected error happened while saving image. Please, try again.");
                    return View(team);
                }
            }

            teamDb.Name = team.Name;
            teamDb.Position = team.Position;
            await _context.SaveChangesAsync();
            TempData["warning"] = "İşçi uğurla dəyişdirildi";
            return RedirectToAction(nameof(Index));
        }
    }
}