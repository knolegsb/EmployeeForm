using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeForm.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EmployeeForm.Controllers
{
    public class EnumController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult EnumView()
        {
            var branch = new List<SelectListItem>();
            branch.Add(new SelectListItem
            {
                Text = "Select",
                Value = ""
            });

            foreach(Branch item in Enum.GetValues(typeof(Branch)))
            {
                branch.Add(
                    new SelectListItem {
                        Text = Enum.GetName(typeof(Branch), item),
                        Value = item.ToString()
                    });
            }

            ViewBag.BranchItems = branch;
            return View();
        }
    }
}