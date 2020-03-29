using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudHub.WebApi.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }

        public string Name { get; set; }

        public string Position { get; set; }

        public int Age { get; set; }

        public decimal Salary { get; set; }
    }
}
