using CrudHub.WebApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudHub.WebApi.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly ModelContext _modelContext;

        public EmployeeService(ModelContext modelContext)
        {
            _modelContext = modelContext;
        }

        public IEnumerable<Employee> GetEmployees()
        {
            return _modelContext.Employees;
        }

        public Employee GetEmployee(int? id)
        {
            return _modelContext.Employees.Find(id);
        }

        public void PostEmployee(Employee? employee)
        {
            if (employee == null)
            {
                throw new NullReferenceException("Model to post is null");
            }
            _modelContext.Employees.Add(employee);
            _modelContext.SaveChanges();
        }

        public void EditEmployee(int? id, Employee? employee)
        {
            if (id == employee.EmployeeId)
            {
                _modelContext.Entry(employee).State = EntityState.Modified;
                _modelContext.SaveChanges();
            }
            else
            {
                throw new InvalidOperationException("Id don't match with model id");
            }
            
        }

        public void DeleteEmployee(Employee model)
        {
            _modelContext.Employees.Remove(model);
            _modelContext.SaveChanges();
        }       
    }
}
