using Interview.Senior.Domain;
using Interview.Senior.Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interview.Senior.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        public IEmployeeCalculator EmployeeCalculator { get; set; }

        public EmployeeController(IEmployeeCalculator employeeCalculator)
        {
            EmployeeCalculator = employeeCalculator;
        }

        [HttpPut]
        public void AddEmployee(Employee employee) 
        {
            EmployeeCalculator.AddEmployee(employee);
        }

        [HttpPost]
        public void IncreaseSalary(Employee employee, double percentageToIncrease) 
        {
            EmployeeCalculator.IncreaseSalary(employee, percentageToIncrease);
        } 
    }
}
