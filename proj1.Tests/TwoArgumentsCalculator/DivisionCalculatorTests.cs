using System;
using NUnit.Framework;
using proj1.TwoArgumentsCalculators;

namespace proj1.Tests.TwoArgumentsCalculator
{
    [TestFixture]
    public class DivisionCalculatorTests
    {
        [TestCase(2, 2, 1)]
        [TestCase(8, 4, 2)]
        [TestCase(-16, -4, 4)]
        public void CalculateTest(double firstValue, double secondValue, double expected)
        {
            ITwoArgumentsCalculator calculator = TwoArgumentsFactory.CreateCalculator("Divide");
            var actualResult = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult);
        }

        [Test]
        public void CalculateTest()
        {
            ITwoArgumentsCalculator calculator = TwoArgumentsFactory.CreateCalculator("Divide");
            Assert.Throws<Exception>(() => calculator.Calculate(5, 0));
        }
    }
}
