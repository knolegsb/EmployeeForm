using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeForm.Models
{
    public enum PayRollType
    {
        [Display(Name = "W-2")]
        W2 = 1,

        [Display(Name = "1099")]
        TenNineNine = 2,

        [Display(Name = "None")]
        None = 3
    }
}
