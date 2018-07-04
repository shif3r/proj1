using System;
namespace proj1.SingleArgumentCalculators
{
    public class Logarifm2Calculator : ISingleArgumentCalculator
    {
        double ISingleArgumentCalculator.Calculate(double firstNumber)
        {
            if (firstNumber == 0)
            {
                throw new Exception("Логарифм из 0");
            }
            return Math.Log(2, firstNumber);
        }
    }
}
