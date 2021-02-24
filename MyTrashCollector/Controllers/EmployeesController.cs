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
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var employee = _context.Employee.Where(e => e.IdentityUserId == userId).FirstOrDefault();
            var trashZip = _context.Customer.Where(c => c.ZipCode == employee.ZipCode).Where(c => c.PickUpDay == DateTime.Today);

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
    }
}
