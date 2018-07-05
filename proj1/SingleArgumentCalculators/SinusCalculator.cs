using System;

namespace proj1.SingleArgumentCalculators
{
    public class SinusCalculator : ISingleArgumentCalculator
    {
        /// <summary>
        /// Calculate sinus of number
        /// </summary>
        /// <param name="firstNumber">Argument</param>
        /// <returns>Result of sinus operation</returns>
        double ISingleArgumentCalculator.Calculate(double firstNumber)
        {
            if (firstNumber > 1 || firstNumber < -1)
            {
                throw new Exception("Нельзя");
            }
            return Math.Asin(firstNumber);
        }
    }
}
