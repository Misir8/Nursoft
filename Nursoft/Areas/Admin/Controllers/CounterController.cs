using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Nursoft.DAL;
using Nursoft.Models;

namespace Nursoft.Areas.Admin.Controllers
{
    [Area("admin")]
    public class CounterController : Controller
    {
        private readonly DataContext _context;

        public CounterController(DataContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var counter = _context.Counters.ToList();
            return View(counter);
        }

        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var counter = _context.Counters.FirstOrDefault(x => x.Id == id);
            if (counter == null)
            {
                return NotFound();
            }
            return View(counter);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Counter counter)
        {
            if (!ModelState.IsValid)
            {
                return View(counter);
            }

            var counterDb = await _context.Counters.FindAsync(counter.Id);

            counterDb.Client = counter.Client;
            counterDb.Computer = counter.Computer;
            counterDb.Project = counter.Project;
            await _context.SaveChangesAsync();
            TempData["warning"] = "Layihələrin sayı uğurla uğurla dəyişdirildi";
            return RedirectToAction(nameof(Index));
        }
    }
}