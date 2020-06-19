using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebAPIDemo.Web.Models
{
    public class Employee
    {
        public int EmployeeID { get; set; }

        [Required(ErrorMessage ="Name is required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Age is required")]
        public Nullable<int> Age { get; set; }
        [Required(ErrorMessage = "Position is required")]
        public string Position { get; set; }
        [Required(ErrorMessage = "Salary is required")]
        public Nullable<int> Salary { get; set; }
    }
}