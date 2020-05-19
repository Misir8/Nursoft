using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Nursoft.DAL;
using Nursoft.Extensions;
using Nursoft.Models;
using Nursoft.ViewModels;
using Org.BouncyCastle.Math.EC.Rfc7748;

namespace Nursoft.Controllers
{
    public class CartController : Controller
    {
        private readonly DataContext _context;

        public CartController(DataContext context)
        {
            _context = context;
        }
        // GET: Cart
        public ActionResult Index()
        {
            List<CartItem> cart = HttpContext.Session.GetJson<List<CartItem>>("Cart") ?? new List<CartItem>();
            CartViewModel cartVM = new CartViewModel
            {
                CartItems = cart,
                GrandTotal = cart.Sum(x => x.Price * x.Quantity)
            };
            return View(cartVM);
        }

        public async Task<ActionResult> Add(int id)
        {
            Product product = await _context.Products.FindAsync(id);
            List<CartItem> cart = HttpContext.Session.GetJson<List<CartItem>>("Cart") ?? new List<CartItem>();
            CartItem cartItem = cart.Where(x => x.ProductId == id).FirstOrDefault();

            if (cartItem == null)
            {
                cart.Add(new CartItem(product));
            }
            else
            {
                cartItem.Quantity += 1;
            }

            HttpContext.Session.SetJson("Cart", cart);
            if (HttpContext.Request.Headers["X-Requested-With"] != "XMLHttpRequest")
            {
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return ViewComponent("SmallCart");
            }

            
        }

        public async Task<ActionResult> Decrease(int id)
        {
            List<CartItem> cart = HttpContext.Session.GetJson<List<CartItem>>("Cart");
            CartItem cartItem = cart.Where(x => x.ProductId == id).FirstOrDefault();

            if (cartItem.Quantity > 1)
            {
                --cartItem.Quantity;
            }
            else
            {
                cart.RemoveAll(x => x.ProductId == id);
            }

            HttpContext.Session.SetJson("Cart", cart);
            if (cart.Count == 0)
            {
                HttpContext.Session.Remove("Cart");
            }

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int id)
        {
            List<CartItem> cart = HttpContext.Session.GetJson<List<CartItem>>("Cart");
            CartItem cartItem = cart.Where(x => x.ProductId == id).FirstOrDefault();
            cart.RemoveAll(x => x.ProductId == id);
            HttpContext.Session.SetJson("Cart", cart);
            return RedirectToAction(nameof(Index));
        }

        public async Task<ActionResult> Clear()
        { 
           HttpContext.Session.Remove("Cart");

           return RedirectToAction(nameof(Index));
        }
    }
}