using System;
namespace proj1.SingleArgumentCalculators
{
    public class SinusCalculator : ISingleArgumentCalculator
    {
        double ISingleArgumentCalculator.Calculate(double firstNumber)
        {
            if (firstNumber > 1 || firstNumber < -1)
            {
                throw new Exception("Нельзя");
            }
            return Math.Asin(firstNumber);
        }
    }
}
