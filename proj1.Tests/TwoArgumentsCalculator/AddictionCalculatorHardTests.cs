using NUnit.Framework;
namespace proj1.Tests.TwoArgumentsCalculator
{
    class AddictionCalculatorHardTests
    {
        [TestCase(0, 0, 0)]
        [TestCase(3, 4, 7)]
        [TestCase(-7, -2, -9)]
        public void CalculateTest(double firstValue, double secondValue, double expected)
        {
            ITwoArgumentsCalculator calculator = TwoArgumentsFactory.CreateCalculator("Plus");
            var actualResult = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult);
        }
    }
}
