using NUnit.Framework;
using proj1.TwoArgumentsCalculators;
using System;

namespace proj1.Tests.TwoArgumentsCalculator
{
    [TestFixture]
    public class TwoArgumentsCalculatorTests
    {
        [TestCase("Plus", typeof(AddictionCalculator))]
        [TestCase("Minus", typeof(SubstractionCalculator))]
        [TestCase("Divide", typeof(DivisionCalculator))]
        [TestCase("Multiply", typeof(MultiplicationCalculator))]
        [TestCase("Maximum", typeof(MaxCalculator))]
        public void CalculateTest(string name, Type type)
        {
            var calculator = TwoArgumentsFactory.CreateCalculator(name);

            Assert.IsInstanceOf(type, calculator);
        }

    }
}
