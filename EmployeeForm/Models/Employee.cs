using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeForm.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Notes { get; set; }
        public int DepartmentId { get; set; }
        [ForeignKey("DepartmentId")]
        public Department Department { get; set; }
        public PayRollType? PayRollTypes { get; set; }
    }
}
