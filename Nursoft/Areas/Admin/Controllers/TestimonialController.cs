using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Nursoft.DAL;
using Nursoft.Models;

namespace Nursoft.Areas.Admin.Controllers
{
    [Area("admin")]
    public class TestimonialController : Controller
    {
        private readonly DataContext _context;

        public TestimonialController(DataContext context)
        {
            _context = context;
        }
        // GET: Testimonial
        public async Task<ActionResult> Index()
        {
            var testimonials = await _context.Testimonials.ToListAsync();
            return View(testimonials);
        }


        // GET: Testimonial/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Testimonial/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Testimonial testimonial)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(testimonial);
                }
               await _context.Testimonials.AddAsync(testimonial);
               await _context.SaveChangesAsync();
               TempData["success"] = "Rəy uğurla əlavə edildi";
               return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(testimonial);
            }
        }

        // GET: Testimonial/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var testimonial = _context.Testimonials.FirstOrDefault(x => x.Id == id);
            if (testimonial == null)
            {
                return NotFound();
            }
            return View(testimonial);
        }

        // POST: Testimonial/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(Testimonial testimonial)
        {
            if (!ModelState.IsValid)
            {
                return View(testimonial);
            }


            var testDb = await _context.Testimonials.FindAsync(testimonial.Id);

            testDb.Name = testimonial.Name;
            testDb.Description = testimonial.Description;
            testDb.Position = testimonial.Position;
            await _context.SaveChangesAsync();
            TempData["warning"] = "Rəy uğurla dəyişdirildi";
            return RedirectToAction(nameof(Index));
        }

        // GET: Testimonial/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var testimonial = _context.Testimonials.FirstOrDefault(x => x.Id == id);
            if (testimonial == null)
            {
                return NotFound();
            }
            return View(testimonial);
        }

        // POST: Testimonial/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public ActionResult DeleteTestimonial(int? id)
        {
            try
            {
                // TODO: Add delete logic here
                if (id == null)
                {
                    return NotFound();
                }

                var testimonial = _context.Testimonials.FirstOrDefault(x => x.Id == id);
                if (testimonial == null)
                {
                    return NotFound();
                }
                _context.Testimonials.Remove(testimonial);
                _context.SaveChanges();
                TempData["danger"] = "Rəy uğurla silindi";
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}