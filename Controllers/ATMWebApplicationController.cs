using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ATMWebApplication.Data;
using ATMWebApplication.Models;
using Microsoft.EntityFrameworkCore;

namespace ATMWebApplication.Controllers
{
    public class ATMWebApplicationController : Controller
    {

        private readonly ATMWebApplicationContext _context;

        public ATMWebApplicationController(ATMWebApplicationContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }


    }
}

//return View(await _context.Customer.ToListAsync());