using System;
using proj1.Interfaces;

namespace proj1.SingleArgumentCalculators
{
    public class PowECalculator : ISingleArgumentCalculator
    {
        /// <summary>
        /// Raises e to the argumenth power
        /// </summary>
        /// <param name="firstNumber">Argument</param>
        /// <returns>Result raising to the power operation</returns>
        double ISingleArgumentCalculator.Calculate(double firstNumber)
        {
            return Math.Pow(Math.E, firstNumber);
        }
    }
}
