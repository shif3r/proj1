using System;
using proj1.Interfaces;

namespace proj1.SingleArgumentCalculators
{
    public class CosinusCalculator : ISingleArgumentCalculator
    {
        /// <summary>
        /// Calculate cosinus of number
        /// </summary>
        /// <param name="firstNumber">Argument</param>
        /// <returns>Result of cos operation</returns>
        double ISingleArgumentCalculator.Calculate(double firstNumber)
        {
            if (firstNumber > 1 || firstNumber < -1)
            {
                throw new Exception("Нельзя");
            }
            return Math.Cos(firstNumber);
        }
    }
}
