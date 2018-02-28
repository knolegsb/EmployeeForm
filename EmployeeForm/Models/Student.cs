using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeForm.Models
{
    public class Student
    {
        public int Id { get; set; }
        public Branch Branch { get; set; }
    }

    public enum Branch
    {
        CS, IT, EL, ME
    }
}
