using System;
namespace proj1.SingleArgumentCalculators
{
    public class LogECalculator : ISingleArgumentCalculator
    {
    double ISingleArgumentCalculator.Calculate(double firstNumber)
        {
            if (firstNumber == 0)
            {
                throw new Exception("Логарифм из 0");
            }
            return Math.Log(firstNumber);
        }
    }
}
