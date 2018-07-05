using NUnit.Framework;
using proj1.Interfaces;

namespace proj1.Tests.SingleArgumentCalculator
{
    [TestFixture]
    public class Pow2CalculatorTests
    {
        [Test]
        public void Pow2Test()
        {
            ISingleArgumentCalculator calculator = SingleArgumentFactory.CreateCalculator("Pow2");
            double result = calculator.Calculate(4);
            Assert.AreEqual(16, result);
        }
    }
}
