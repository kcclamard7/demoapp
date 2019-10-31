using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using WebMatrix.Data;

namespace EmployeeApp.Models
{
    public class Employee
    {
        
        public int id { get; set; }

        [Display(Name ="Employee Name")]
        [Required(ErrorMessage = "Please enter the employee name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter the employee name" )]
        [Display(Name="Job Title")]
        public string JobTitle { get; set; }
    }
}
