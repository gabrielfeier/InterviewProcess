using Interview.Senior.Domain;
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
    public class FinantialCalculatorController : ControllerBase
    {
        private IFinantialCalculator _finantialCalculator;

        public FinantialCalculatorController(IFinantialCalculator finantialCalculator) 
        {
            _finantialCalculator = finantialCalculator;
        }

        [HttpGet]
        public double CalculateFees([FromBody] int num1, [FromBody] double feesPercentage) 
        {
            return _finantialCalculator.CalculateFees(num1, feesPercentage);
        }
    }
}
