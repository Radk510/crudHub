using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CrudHub.WebClient.Models
{
    public class mvcEmployeeModel
    {
        
        public int EmployeeId { get; set; }

        [Required(ErrorMessage = "The Name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "The Position is required")]
        public string Position { get; set; }

        [Required(ErrorMessage = "The Age is required")]
        public int Age { get; set; }

        [Required(ErrorMessage = "The Salary is required")]
        public decimal Salary { get; set; }
    }
}
