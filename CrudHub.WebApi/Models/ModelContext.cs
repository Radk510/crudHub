using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudHub.WebApi.Models
{
    public class ModelContext : DbContext
    {
        public ModelContext(DbContextOptions<ModelContext> option)
            : base(option)
        {
        }

        public DbSet<Employee> Employees { get; set; }

        protected override void  OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    EmployeeId = 1,
                    Name = "Semen Semyonovich",
                    Age = 55,
                    Position = "Tokar",
                    Salary = 333
                },
                new Employee
                {
                    EmployeeId = 2,
                    Name = "Aleksandr Prilykin",
                    Age = 45,
                    Position = "Stolar",
                    Salary = 432
                },
                new Employee
                {
                    EmployeeId = 3,
                    Name = "Evgen BadComediant",
                    Age = 28,
                    Position = "Bloger",
                    Salary = 129202
                },
                new Employee
                {
                    EmployeeId = 4,
                    Name = "Petro Vogyr",
                    Age = 23,
                    Position = "Programmer",
                    Salary = 33231
                },
                new Employee
                {
                    EmployeeId = 5,
                    Name = "Karzen Viktorov",
                    Age = 34,
                    Position = "Office manager",
                    Salary = 32421
                }
            );
        }
    }
}
