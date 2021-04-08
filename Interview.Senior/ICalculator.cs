using Interview.Senior.Domain.Models;

namespace Interview.Senior.Domain
{
    public interface ICalculator
    {
        int Sum(int num1, int num2);

        int Subtraction(int num1, int num2);

        int Division(int num1, int num2);

        int Multiplication(int num1, int num2);

        double CalculateFees(int num1, double feesPercentage);

        void IncreaseSalary(Employee employee, double percentageToIncrease);

        void AddEmployee(Employee employee);
    }
}
