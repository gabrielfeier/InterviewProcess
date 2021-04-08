using Interview.Senior.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Interview.Senior.Api.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class CalculatorController : ControllerBase
    {
        private readonly ILogger<CalculatorController> _logger;
        private readonly ICalculator _calculator;

        public CalculatorController(ILogger<CalculatorController> logger, ICalculator calculator)
        {
            _logger = logger;
            _calculator = calculator;
        }

        [HttpPost]
        public int Sum([FromBody] int num1, [FromBody] int num2)
        {
            return _calculator.Sum(num1, num2);
        }
        
        [HttpPost]
        public int Subtraction([FromBody] int num1, [FromBody] int num2)
        {
            return _calculator.Subtraction(num1, num2);
        }
        
        [HttpPost]
        public int Division([FromBody] int num1, [FromBody] int num2)
        {
            return _calculator.Division(num1, num2);
        }
        
        [HttpPost]
        public int Multiplication([FromBody] int num1, [FromBody] int num2)
        {
            return _calculator.Multiplication(num1, num2);
        }

        [HttpPost]
        public double CalculateFees([FromBody] int num1, [FromBody] double feesPercentage)
        {
            return _calculator.CalculateFees(num1, feesPercentage);
        }
    }
}
