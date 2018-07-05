using System;

namespace proj1.TwoArgumentsCalculators
{
    public class BRootOfACalculator : ITwoArgumentsCalculator
    {
        /// <summary>
        /// Calculates the root of bth power of the a number
        /// </summary>
        /// <param name="firstNumber">a - Rooted number</param>
        /// <param name="secondNumber">b - Power of root</param>
        /// <returns>Result of the root operation</returns>
        double ITwoArgumentsCalculator.Calculate(double firstNumber, double secondNumber)
        {
            return Math.Pow(firstNumber,1/secondNumber);
        }
    }
}
