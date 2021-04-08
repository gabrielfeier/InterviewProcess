using System;

namespace Interview.Senior.Domain.Models
{
    public class Employee
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public double Salary { get; set; }

        public int MonthDayOfPayment { get; set; }
    }
}
