﻿using System.Collections.Generic;
using System.Linq;
using Nursoft.DAL;
using Nursoft.Models;

namespace Nursoft.ViewComponent
{
    public class EmailViewComponent : Microsoft.AspNetCore.Mvc.ViewComponent
    {
        private readonly DataContext _context;

        public EmailViewComponent(DataContext context)
        {
            _context = context;
        }
        private List<ContactUs> GetContact()
        {

            return _context.ContactUses.ToList();
        }
        public string Invoke()
        {
            return GetContact().ElementAt(0).Email;
        }
    }
}