using System;
using proj1.Interfaces;

namespace proj1.SingleArgumentCalculators
{
    public class Pow2Calculator : ISingleArgumentCalculator
    {
        /// <summary>
        /// Squares the number
        /// </summary>
        /// <param name="firstNumber">Argument</param>
        /// <returns>Result of squaring operation</returns>
        double ISingleArgumentCalculator.Calculate(double firstNumber)
        {
            return Math.Pow(firstNumber, 2);
        }
    }
}
