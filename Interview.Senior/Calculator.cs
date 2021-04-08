using Interview.Senior.Domain.Models;
using System;

namespace Interview.Senior.Domain
{
    public class Calculator : ICalculator
    {
        private readonly Context _context;

        public Calculator()
        {
            _context = new Context();
        }

        public int Sum(int num1, int num2)
        {
            return num1 + num2;
        }

        public int Subtraction(int num1, int num2)
        {
            return num1 - num2;
        }

        public int Division(int num1, int num2)
        {
            return num1 / num2;
        }

        public int Multiplication(int num1, int num2)
        {
            throw new NotImplementedException();
        }

        public double CalculateFees(int num1, double feesPercentage)
        {
            return num1 + (num1 / 100 * feesPercentage);
        }

        public void IncreaseSalary(Employee employee, double percentageToIncrease)
        {

        }

        public void AddEmployee(Employee employee)
        {
            _context.Add(employee);
        }
    }
}
