using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Nursoft.DAL;

namespace Nursoft.Controllers
{
    public class NewsController : Controller
    {
        private readonly DataContext _context;

        public NewsController(DataContext context)
        {
            _context = context;
        }

        // GET: News
        public async Task<ActionResult> Index(int p = 1)
        {
            

            int pageSize = 6;
            
            var news = _context.News.Skip((p - 1) * pageSize).Take(pageSize);
            ViewBag.Page = p;
            ViewBag.PageRange = pageSize;
            ViewBag.TotalPages = (int) Math.Ceiling((decimal) _context.News.Count() / pageSize);
            if (p > ViewBag.TotalPages || p <= 0)
            {
                return NotFound();
            }
            return View(await news.ToListAsync());
        }

        // GET: News/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var news = await _context.News.FirstOrDefaultAsync(n => n.Id == id);
            if (news == null)
            {
                return NotFound();
            }
            return View(news);
        }
    }
}