using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeForm.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeForm.Controllers
{
    public class FruitController : Controller
    {
        public IActionResult Index()
        {
            List<Fruit> fruits = new List<Fruit>();
            fruits.Add(new Fruit() { Id = 1, Name = "Apple", IsCheck = false });
            fruits.Add(new Fruit() { Id = 2, Name = "Mango", IsCheck = false });
            fruits.Add(new Fruit() { Id = 3, Name = "Orange", IsCheck = false });
            fruits.Add(new Fruit() { Id = 4, Name = "Grapes", IsCheck = false });

            FruitList frList = new FruitList();
            frList.FruitLists = fruits;

            return View(frList);
        }

        [HttpPost]
        public IActionResult Index(FruitList fr)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in fr.FruitLists)
            {
                if (item.IsCheck)
                {
                    sb.Append(item.Name + ", ");
                }
            }
            ViewBag.SelectedFruit = "Selected Fruits are " + sb.ToString();

            return View(fr);
        }
    }
}