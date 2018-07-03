using System;
namespace proj1.SingleArgumentCalculators
{
    public class LogECalculator : ISingleArgumentCalculator
    {
        double ISingleArgumentCalculator.Calculate(double firstNumber)
        {
            return Math.Log(firstNumber);
        }
    }
}
