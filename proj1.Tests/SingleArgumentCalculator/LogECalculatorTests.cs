using System;
using NUnit.Framework;
using proj1.Interfaces;

namespace proj1.Tests.SingleArgumentCalculator
{
    [TestFixture]
    public class LogECalculatorTests
    {
        [Test]
        public void LogETest()
        {
            ISingleArgumentCalculator calculator = SingleArgumentFactory.CreateCalculator("Loge");
            double result = calculator.Calculate(1);
            Assert.AreEqual(0, result);
        }

        [Test]
        public void CalculateTest()
        {
            ISingleArgumentCalculator calculator = SingleArgumentFactory.CreateCalculator("Loge");
            Assert.Throws<Exception>(() => calculator.Calculate(0));
        }
    }
}
