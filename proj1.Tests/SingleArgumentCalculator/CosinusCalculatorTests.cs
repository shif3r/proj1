using System;
using NUnit.Framework;
using proj1.Interfaces;

namespace proj1.Tests.SingleArgumentCalculator
{
    [TestFixture]
    public class CosinusCalculatorTests
    {
        [Test]
        public void CosinusTest()
        {
            ISingleArgumentCalculator calculator = SingleArgumentFactory.CreateCalculator("Cosinus");
            double result = calculator.Calculate(0);
            Assert.AreEqual(1, result);
        }
        [Test]
        public void CalculateTest()
        {
            ISingleArgumentCalculator calculator = SingleArgumentFactory.CreateCalculator("Cosinus");
            Assert.Throws<Exception>(() => calculator.Calculate(20));
        }
    }
}
