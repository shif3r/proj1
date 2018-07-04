using NUnit.Framework;
namespace proj1.Tests.TwoArgumentsCalculator
{
    [TestFixture]
    public class MinCalculatorTests
    {
        [Test]
        public void MinCalculatorTest()
        {
            ITwoArgumentsCalculator calculator = TwoArgumentsFactory.CreateCalculator("Minimum");
            double result = calculator.Calculate(4, 2);
            Assert.AreEqual(2, result);
        }
    }
}
