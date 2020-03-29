using CrudHub.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudHub.WebApi.Services
{
    public interface IEmployeeService
    {
        IEnumerable<Employee> GetEmployees();

        Employee GetEmployee(int? id);

        void PostEmployee(Employee? employee);

        void EditEmployee(int? id, Employee? employee);

        void DeleteEmployee(Employee employee);
    }
}
