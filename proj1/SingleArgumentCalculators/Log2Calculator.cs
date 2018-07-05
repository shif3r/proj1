using System;

namespace proj1.SingleArgumentCalculators
{
    public class Logarifm2Calculator : ISingleArgumentCalculator
    {
        /// <summary>
        /// Calculate logarithm to the base 2 of number
        /// </summary>
        /// <param name="firstNumber">Argument</param>
        /// <returns>Result of logarithm to the base 2 operation</returns>
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
