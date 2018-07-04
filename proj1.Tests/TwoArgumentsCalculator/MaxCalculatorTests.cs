using NUnit.Framework;
namespace proj1.Tests.TwoArgumentsCalculator
{
    [TestFixture]
    public class MaxCalculatorTests
    {
        [Test]
        public void MaxCalculatorTest()
        {
            ITwoArgumentsCalculator calculator = TwoArgumentsFactory.CreateCalculator("Maximum");
            double result = calculator.Calculate(4, 2);
            Assert.AreEqual(4, result);
        }
    }
}
