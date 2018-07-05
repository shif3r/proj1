﻿using NUnit.Framework;
using proj1.Interfaces;

namespace proj1.Tests.TwoArgumentsCalculator
{
    [TestFixture]
    public class MaxCalculatorTests
    {
        [TestCase(2, 4, 4)]
        [TestCase(8, 4, 8)]
        [TestCase(-16, -4, -4)]
        public void CalculateTest(double firstValue, double secondValue, double expected)
        {
            ITwoArgumentsCalculator calculator = TwoArgumentsFactory.CreateCalculator("Maximum");
            var actualResult = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult);
        }
    }
}
