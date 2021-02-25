using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyTrashCollector.Data;
using MyTrashCollector.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace MyTrashCollector.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EmployeesController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var date = DateTime.Now.DayOfWeek;
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var employee = _context.Employee.Where(e => e.IdentityUserId == userId).FirstOrDefault();
            var trashZip = _context.Customer.Where(c => c.ZipCode == employee.ZipCode).Where(c => c.PickUpDay == date);

            if (employee == null)
            {
                return RedirectToAction(nameof(Create));
            }
            else
            {
                return View(trashZip);
            }
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Employee employee)
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            employee.IdentityUserId = userId;
            _context.Add(employee);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Details()
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var employee = _context.Employee.Where(e => e.IdentityUserId == userId).FirstOrDefault();
            var trashZip = _context.Customer.Where(c => c.ZipCode == employee.ZipCode);
            return View(trashZip);
        }

        public IActionResult Monday()
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var employee = _context.Employee.Where(e => e.IdentityUserId == userId).FirstOrDefault();
            var zipDay = _context.Customer.Where(c => c.ZipCode == employee.ZipCode).Where(c => c.PickUpDay == DayOfWeek.Monday);
            return View(zipDay);
        }

        public IActionResult Tuesday()
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var employee = _context.Employee.Where(e => e.IdentityUserId == userId).FirstOrDefault();
            var zipDay = _context.Customer.Where(c => c.ZipCode == employee.ZipCode).Where(c => c.PickUpDay == DayOfWeek.Tuesday);
            return View(zipDay);
        }

        public IActionResult Wednesday()
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var employee = _context.Employee.Where(e => e.IdentityUserId == userId).FirstOrDefault();
            var zipDay = _context.Customer.Where(c => c.ZipCode == employee.ZipCode).Where(c => c.PickUpDay == DayOfWeek.Wednesday);
            return View(zipDay);
        }

        public IActionResult Thursday()
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var employee = _context.Employee.Where(e => e.IdentityUserId == userId).FirstOrDefault();
            var zipDay = _context.Customer.Where(c => c.ZipCode == employee.ZipCode).Where(c => c.PickUpDay == DayOfWeek.Thursday);
            return View(zipDay);
        }

        public IActionResult Friday()
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var employee = _context.Employee.Where(e => e.IdentityUserId == userId).FirstOrDefault();
            var zipDay = _context.Customer.Where(c => c.ZipCode == employee.ZipCode).Where(c => c.PickUpDay == DayOfWeek.Friday);
            return View(zipDay);
        }


        public IActionResult CompletedPickup(string id)
        {
            var customer = _context.Customer.Where(c => c.IdentityUserId == id).FirstOrDefault();
            if (customer.CompletedPickup == false)
            {
                customer.CompletedPickup = true;
                customer.Balance += 20;
                _context.Update(customer);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return RedirectToAction(nameof(Index));
            }
        }
    }
}
