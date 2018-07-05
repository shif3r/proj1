using System;

namespace proj1.TwoArgumentsCalculators
{
    public class MinCalculator : ITwoArgumentsCalculator
    {
        /// <summary>
        /// Calculates minimum of two numbers
        /// </summary>
        /// <param name="firstNumber">First number</param>
        /// <param name="secondNumber">Second number</param>
        /// <returns>Smallest number</returns>
        double ITwoArgumentsCalculator.Calculate(double firstNumber, double secondNumber)
        {
            return Math.Min(firstNumber,secondNumber);
        }
    }
}
