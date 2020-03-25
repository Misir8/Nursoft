using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Nursoft.DAL;
using Nursoft.Models;

namespace Nursoft.Controllers
{
    public class ContactController : Controller
    {
        private readonly DataContext _context;

        public ContactController(DataContext context)
        {
            _context = context;
        }

        // GET
        public IActionResult Index()
        {
            ViewBag.Map = _context.MapContacts.ToList();
            ViewBag.ContactUs = _context.ContactUses.ToList();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(Contact contact)
        {
            if (ModelState.IsValid)
            {
                await _context.Contacts.AddAsync(contact);
                await _context.SaveChangesAsync();
                TempData["successContact"] = "Mesajınız uğurla göndərildi!";
                return RedirectToAction(nameof(Index));
            }
            ViewBag.Map = _context.MapContacts.ToList();
            ViewBag.ContactUs = _context.ContactUses.ToList();
            return View(contact);
        }
    }
}