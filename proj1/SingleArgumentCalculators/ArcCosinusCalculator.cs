using System;
using proj1.Interfaces;

namespace proj1.SingleArgumentCalculators
{
    public class ArcCosinusCalculator : ISingleArgumentCalculator
    {
        /// <summary>
        /// Calculate arcosinus of number
        /// </summary>
        /// <param name="firstNumber">Argument</param>
        /// <returns>Result of arccos operation</returns>
        double ISingleArgumentCalculator.Calculate(double firstNumber)
        {
            return Math.Pow(Math.Cos(firstNumber), -1);
        }
    }
}
