using NUnit.Framework;

namespace proj1.Tests.SingleArgumentCalculator
{
    [TestFixture]
    public class Logarifm10CalculatorTests
    {
        [Test]
        public void Log10Test()
        {
            ISingleArgumentCalculator calculator = SingleArgumentFactory.CreateCalculator("Logarifm10");
            double result = calculator.Calculate(10);
            Assert.AreEqual(1, result);
        }
    }
}
