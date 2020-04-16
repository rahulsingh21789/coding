using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace DisplayWordFromCurrencyAndName.Models
{
    public class Employee
    {
        [Required]
        [Display(Name="Employee Name")]
        public string EmpName { get; set; }

        [Required]
        public decimal Currency { get; set; } 

    }
}