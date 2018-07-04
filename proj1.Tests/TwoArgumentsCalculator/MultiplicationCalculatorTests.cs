using NUnit.Framework;
namespace proj1.Tests.TwoArgumentsCalculator
{
    [TestFixture]
    public class MultiplicationCalculatorTests
    {
        [Test]
        public void MultiplicationCalculatorTest()
        {
            ITwoArgumentsCalculator calculator = TwoArgumentsFactory.CreateCalculator("Multiply");
            double result = calculator.Calculate(4, 2);
            Assert.AreEqual(8, result);
        }
    }
}
