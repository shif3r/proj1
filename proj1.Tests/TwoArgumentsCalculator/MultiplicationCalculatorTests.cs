using NUnit.Framework;
namespace proj1.Tests.TwoArgumentsCalculator
{
    [TestFixture]
    public class MultiplicationCalculatorTests
    {
        [TestCase(2, 4, 8)]
        [TestCase(8, 4, 32)]
        [TestCase(-16, -4, 64)]
        public void CalculateTest(double firstValue, double secondValue, double expected)
        {
            ITwoArgumentsCalculator calculator = TwoArgumentsFactory.CreateCalculator("Multiply");
            var actualResult = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult);
        }
    }
}
