using NUnit.Framework;
namespace proj1.Tests.TwoArgumentsCalculator
{
    [TestFixture]
    public class DivisionCalculatorHardTests
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
    }
}
