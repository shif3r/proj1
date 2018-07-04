using System;
using NUnit.Framework;

namespace proj1.Tests.SingleArgumentCalculator
{
    [TestFixture]
    public class SinusCalculatorTests
    {
        [Test]
        public void SinusTest()
        {
            ISingleArgumentCalculator calculator = SingleArgumentFactory.CreateCalculator("Sinus");
            double result = calculator.Calculate(0);
            Assert.AreEqual(0, result);
        }
        [Test]
        public void CalculateTest()
        {
            ISingleArgumentCalculator calculator = SingleArgumentFactory.CreateCalculator("Sinus");
            Assert.Throws<Exception>(() => calculator.Calculate(10));
        }
    }
}
