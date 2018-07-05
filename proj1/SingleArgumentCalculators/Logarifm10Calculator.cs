using System;

namespace proj1.SingleArgumentCalculators
{
    public class Logarifm10Calculator : ISingleArgumentCalculator
    {
        /// <summary>
        /// Calculate logarithm to the base 10 of number
        /// </summary>
        /// <param name="firstNumber">Argument</param>
        /// <returns>Result of logarithm to the base 10 operation</returns>
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
