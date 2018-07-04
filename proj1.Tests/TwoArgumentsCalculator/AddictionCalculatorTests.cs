using NUnit.Framework;
namespace proj1.Tests.TwoArgumentsCalculator
{
    [TestFixture]
    public class AddictionCalculatorTests
    {
        [Test]
        public void AddictionTest()
        {
            ITwoArgumentsCalculator calculator = TwoArgumentsFactory.CreateCalculator("Plus");
            double result = calculator.Calculate(2, 2);
            Assert.AreEqual(4, result);
        }
    }
}
