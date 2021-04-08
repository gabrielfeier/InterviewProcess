using Interview.Senior.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace Interview.Senior.Domain
{
    public class Context : DbContext
    {
        public List<Employee> Employees => FillEmployees();

        public List<Employee> FillEmployees() 
        {
            return new List<Employee>()
            {
                new Employee() { Id = new Guid(), Name = "Employee1", Salary = 2000.00, MonthDayOfPayment = 25},
                new Employee() { Id = new Guid(), Name = "Employee2", Salary = 2200.00, MonthDayOfPayment = 30},
                new Employee() { Id = new Guid(), Name = "Employee3", Salary = 2500.00, MonthDayOfPayment = 5}
            };
        }
    }
}
