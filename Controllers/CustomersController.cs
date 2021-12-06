using System;
using System.Web;
//using System.Web.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Session;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ATMWebApplication.Data;
using ATMWebApplication.Models;
using System.Diagnostics;
using Microsoft.AspNetCore.Http;


namespace ATMWebApplication.Controllers
{

    public class CustomersController : Controller
    {

        private readonly ATMWebApplicationContext _context;

        //private DB_Entities _db = new DB_Entities();

        public CustomersController(ATMWebApplicationContext context)
        {
            _context = context;
        }

        public ActionResult Login()
        {
            Console.WriteLine("Login Page.");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(string AccountNum, string Pin)
        {
            Console.WriteLine("accountNumber: " + AccountNum);
            Console.WriteLine("pin: " + Pin);
            if (ModelState.IsValid)
            {
                //var f_password = GetMD5(password);
         
                var data = _context.Customer.Where(c => c.AccountNum.Equals(AccountNum) && c.Pin.Equals(Pin)).ToList();
                Console.WriteLine(data);
                if (data.Count() > 0)
                {
                    //add session              
                    HttpContext.Session.SetString("Full Name", data.FirstOrDefault().FullName);
                    HttpContext.Session.SetString("Account Number", data.FirstOrDefault().AccountNum);
                    HttpContext.Session.SetInt32("Balance", data.FirstOrDefault().Balance);
                    Console.WriteLine("Login Succeed.");             
                    return RedirectToAction("Welcome");
                }
                else
                {
                    //Login fail message has to be fixed!
                    ViewBag.Message = "Login failed";
                    Console.WriteLine("Login Failed."); 
                    return RedirectToAction("Login");
                }
            }
            return View();
        }

        [HttpGet]
        public ActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }

        public ActionResult Welcome()
        {
            return View();
        }

        public ActionResult CheckBalance()
        {
            if (HttpContext.Session.GetString("Full Name") == "")
            {
                //HttpContext.Session.SetString("message", "You are not logged in yet.");
            }
            return View();
        }

        [HttpGet]
        public ActionResult Deposit()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Deposit(String Balance)
        {
            // adding deposit to balance of customer
            Int32 bal = HttpContext.Session.GetInt32("Balance").Value;
            bal += int.Parse(Balance);
            HttpContext.Session.SetInt32("Balance", bal);
            var AccountNum = HttpContext.Session.GetString("Account Number");
            var user = _context.Customer.FirstOrDefault(c => c.AccountNum.Equals(AccountNum));
            user.Balance = bal;
            Console.WriteLine("Customer's balance: " + user.Balance);
            //DB update
            _context.Update(user);
            _context.SaveChanges();

            return RedirectToAction("CheckBalance");
        }

        [HttpGet]
        public ActionResult Withdrawal()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Withdrawal(String Balance)
        {
            Int32 bal = HttpContext.Session.GetInt32("Balance").Value;
            bal -= int.Parse(Balance);
            HttpContext.Session.SetInt32("Balance", bal);
            var AccountNum = HttpContext.Session.GetString("Account Number");
            var user = _context.Customer.FirstOrDefault(c => c.AccountNum.Equals(AccountNum));
            user.Balance = bal;
            Console.WriteLine("Customer's balance: " + user.Balance);

            return View();
        }

        // GET: Customers
        public async Task<IActionResult> Index()
        {

            return View(await _context.Customer.ToListAsync());
        }

        // GET: Customers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = await _context.Customer
                .FirstOrDefaultAsync(m => m.ID == id);
            if (customer == null)
            {
                return NotFound();
            }

            return View(customer);
        }

        // GET: Customers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Customers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,fullName,accountNum,pin,balance")] Customer customer)
        {
            if (ModelState.IsValid)
            {
                _context.Add(customer);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(customer);
        }

        // GET: Customers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = await _context.Customer.FindAsync(id);
            if (customer == null)
            {
                return NotFound();
            }
            return View(customer);
        }

        // POST: Customers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,fullName,accountNum,pin,balance")] Customer customer)
        {
            if (id != customer.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(customer);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CustomerExists(customer.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(customer);
        }

        // GET: Customers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = await _context.Customer
                .FirstOrDefaultAsync(m => m.ID == id);
            if (customer == null)
            {
                return NotFound();
            }

            return View(customer);
        }

        // POST: Customers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var customer = await _context.Customer.FindAsync(id);
            _context.Customer.Remove(customer);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CustomerExists(int id)
        {
            return _context.Customer.Any(e => e.ID == id);
        }
    }
}
