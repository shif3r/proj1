using NUnit.Framework;
namespace proj1.Tests.TwoArgumentsCalculator
{
    [TestFixture]
    public class DivisionCalculatorTests
    {
        [Test]
        public void DivisionCalculatorTest()
        {
            ITwoArgumentsCalculator calculator = TwoArgumentsFactory.CreateCalculator("Minus");
            double result = calculator.Calculate(4, 2);
            Assert.AreEqual(2, result);
        }
    }
}
