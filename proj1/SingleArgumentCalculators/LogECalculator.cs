using System;
using proj1.Interfaces;

namespace proj1.SingleArgumentCalculators
{
    public class LogECalculator : ISingleArgumentCalculator
    {
        /// <summary>
        /// Calculate logarithm to the base e of number
        /// </summary>
        /// <param name="firstNumber">Argument</param>
        /// <returns>Result of logarithm to the base e operation</returns>
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
