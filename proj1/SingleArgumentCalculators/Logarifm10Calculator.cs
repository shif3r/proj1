using System;
namespace proj1.SingleArgumentCalculators
{
    public class Logarifm10Calculator : ISingleArgumentCalculator
    {
        double ISingleArgumentCalculator.Calculate(double firstNumber)
        {
            if (firstNumber == 0)
            {
                throw new Exception("Логарифм из 0");
            }
            return Math.Log10(firstNumber);
        }
    }
}
