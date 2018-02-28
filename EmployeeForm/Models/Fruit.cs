using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeForm.Models
{
    public class Fruit
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsCheck { get; set; }
    }

    public class FruitList
    {
        public List<Fruit> FruitLists { get; set; }
    }
}
