using System;

namespace proj1.SingleArgumentCalculators
{
    public class ArcSinusCalculator : ISingleArgumentCalculator
    {
        /// <summary>
        /// Calculate arcsinus of number
        /// </summary>
        /// <param name="firstNumber">Argument</param>
        /// <returns>Result of arcsin operation</returns>
        double ISingleArgumentCalculator.Calculate(double firstNumber)
        {
            return Math.Pow(Math.Sin(firstNumber), -1);
        }
    }
}
