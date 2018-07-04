using NUnit.Framework;

namespace proj1.Tests.SingleArgumentCalculator
{
    [TestFixture]
    public class CosinusCalculatorTests
    {
        [Test]
        public void CosinusTest()
        {
            ISingleArgumentCalculator calculator = SingleArgumentFactory.CreateCalculator("Cosinus");
            double result = calculator.Calculate(0);
            Assert.AreEqual(1, result);
        }
    }
}
