using NUnit.Framework;

namespace Interview.Senior.Domain.UnitTests
{
    public class CalculatorTests
    {
        private Calculator _calculator;

        [SetUp]
        public void Setup()
        {
            _calculator = new Calculator();
        }

        [Test]
        public void Sum()
        {
            //Arange
            var sum = (1, 5);
            var expectedResult = 6;

            //Act
            var result = _calculator.Sum(sum.Item1, sum.Item2);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void Subtraction()
        {
            //Arange
            var sum = (1, 5);
            var expectedResult = -4;

            //Act
            var result = _calculator.Sum(sum.Item1, sum.Item2);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void Multiplication()
        {
            //Arange
            var sum = (1, 5);
            var expectedResult = 5;

            //Act
            var result = _calculator.Sum(sum.Item1, sum.Item2);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void Division()
        {
            //Arange
            var sum = (1, 5);
            var expectedResult = 0.2;

            //Act
            var result = _calculator.Sum(sum.Item1, sum.Item2);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}