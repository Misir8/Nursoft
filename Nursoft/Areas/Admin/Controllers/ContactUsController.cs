using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Nursoft.DAL;
using Nursoft.Models;

namespace Nursoft.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ContactUsController : Controller
    {
        private readonly DataContext _context;

        public ContactUsController(DataContext context)
        {
            _context = context;
        }
        // GET
        public IActionResult Index()
        {
            var contactUs = _context.ContactUses.ToList();
            return View(contactUs);
        }
        
        //EDIT GET 
        public IActionResult Edit(int? id)
        {
            if (id != null)
            {
                var contactUs = _context.ContactUses.FirstOrDefault(s => s.Id == id);
                if (contactUs != null)
                {
                    return View(contactUs);
                }
            }

            return NotFound();
        }
        
        //EDIT POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(ContactUs contactUs)
        {
            if (!ModelState.IsValid)
            {
                return View(contactUs);
            }

            var contactUsDb = await _context.ContactUses.FindAsync(contactUs.Id);

            contactUsDb.Email = contactUs.Email;
            contactUsDb.Address = contactUs.Address;
            contactUsDb.Phone = contactUs.Phone;
            await _context.SaveChangesAsync();
            TempData["warning"] = "Əlaqə məlumatı uğurla dəyişdirildi";
            return RedirectToAction(nameof(Index));
        }
        
    }
}