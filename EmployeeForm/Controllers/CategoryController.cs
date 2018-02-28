using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeForm.Models;
using EmployeeForm.Models.ViewMedels;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeForm.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            List<Category> clist = new List<Category>();
            clist.Add(new Category { Id = 1, Name = "Electronics" });
            clist.Add(new Category { Id = 2, Name = "Electrical" });
            clist.Add(new Category { Id = 3, Name = "Computer" });
            clist.Add(new Category { Id = 4, Name = "Machines" });

            CategoryViewModel cm = new CategoryViewModel();
            cm.ListCategory = clist;
            cm.SelectedAns = string.Empty;
            return View(cm);
        }

        [HttpPost]
        public IActionResult Index(CategoryViewModel catViewModel)
        {
            return RedirectToAction("Thanks", catViewModel);
        }

        public IActionResult Thanks(CategoryViewModel catViewModel)
        {
            return View(catViewModel);
        }
    }
}