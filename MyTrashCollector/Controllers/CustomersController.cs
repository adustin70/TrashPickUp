using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MyTrashCollector.Data;
using MyTrashCollector.Models;

namespace MyTrashCollector.Controllers
{
    [Authorize(Roles = "Customer")]
    public class CustomersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CustomersController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var customer = _context.Customer.Where(c => c.IdentityUserId == userId).SingleOrDefault();

            if (customer == null)
            {
                return RedirectToAction("Create");
            }
            else
            {
                return View(customer);
            }
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Customer customer)
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            customer.IdentityUserId = userId;
            _context.Add(customer);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Edit()
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var user = _context.Customer.Where(c => c.IdentityUserId == userId).FirstOrDefault();
            return View(user);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Customer customer)
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var user = _context.Customer.Where(c => c.IdentityUserId == userId).FirstOrDefault();
            user.PickUpDay = customer.PickUpDay;
            _context.Update(user);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index)); 
        }

        public IActionResult RequestOneTime()
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var user = _context.Customer.Where(c => c.IdentityUserId == userId).FirstOrDefault();
            return View(user);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult RequestOneTime(Customer customer)
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var user = _context.Customer.Where(c => c.IdentityUserId == userId).FirstOrDefault();
            user.ExtraPickUp = customer.ExtraPickUp;
            _context.Update(user);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult StartVacation()
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var user = _context.Customer.Where(c => c.IdentityUserId == userId).FirstOrDefault();
            return View(user);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult StartVacation(Customer customer)
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var user = _context.Customer.Where(c => c.IdentityUserId == userId).FirstOrDefault();
            user.StartDay = customer.StartDay;
            user.EndDay = customer.EndDay;

            _context.Update(user);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
