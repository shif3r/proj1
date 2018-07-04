using System;
using NUnit.Framework;
using proj1.SingleArgumentCalculators;

namespace proj1.Tests.SingleArgumentCalculator
{
    [TestFixture]
    public class SingleArgumentCalculatorTests
    {
        [TestCase("Cosinus", typeof(CosinusCalculator))]
        [TestCase("Sinus", typeof(SinusCalculator))]
        [TestCase("Loge", typeof(LogECalculator))]
        [TestCase("Pow2", typeof(Pow2Calculator))]
        [TestCase("Logarifm10", typeof(Logarifm10Calculator))]
        public void CalculateTest(string name, Type type)
        {
            var calculator = SingleArgumentFactory.CreateCalculator(name);

            Assert.IsInstanceOf(type, calculator);
        }

    }
}
