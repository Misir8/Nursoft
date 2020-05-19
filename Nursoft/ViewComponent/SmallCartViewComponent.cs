using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc;
using Nursoft.Extensions;
using Nursoft.Models;
using Nursoft.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nursoft.ViewComponent
{
    public class SmallCartViewComponent : Microsoft.AspNetCore.Mvc.ViewComponent
    {
        public string Invoke()
        {
            List<CartItem> cart = HttpContext.Session.GetJson<List<CartItem>>("Cart");
            SmallCartViewModel smallCartVM;

            if (cart == null || cart.Count == 0)
            {
                smallCartVM = null;
                return 0.ToString();
            }
            else
            {
                smallCartVM = new SmallCartViewModel
                {
                    NumberOfItem = cart.Sum(x => x.Quantity)
                };
                return smallCartVM.NumberOfItem.ToString();
            }

            
        }
    }
}
