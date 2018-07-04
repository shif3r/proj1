using NUnit.Framework;

namespace proj1.Tests.SingleArgumentCalculator
{
    [TestFixture]
    public class LogECalculatorTests
    {
        [Test]
        public void LogETest()
        {
            ISingleArgumentCalculator calculator = SingleArgumentFactory.CreateCalculator("Loge");
            double result = calculator.Calculate(1);
            Assert.AreEqual(0, result);
        }
    }
}
