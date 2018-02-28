using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeForm.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EmployeeForm.Controllers
{
    public class DropDownController : Controller
    {
        private readonly EmployeeDbContext _context;

        public DropDownController(EmployeeDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ListFromDatabase()
        {
            var fruitsList = _context.Fruits.ToList();
            SelectList list = new SelectList(fruitsList, "Id", "Name");
            ViewBag.FruitsList = list;

            return View();
        }
    }
}