using System;
using proj1.Interfaces;

namespace proj1.TwoArgumentsCalculators
{
    public class MaxCalculator : ITwoArgumentsCalculator
    {
        /// <summary>
        /// Calculates maximum of two numbers
        /// </summary>
        /// <param name="firstNumber">First number</param>
        /// <param name="secondNumber">Second number</param>
        /// <returns>Largest number</returns>
        double ITwoArgumentsCalculator.Calculate(double firstNumber, double secondNumber)
        {
            return Math.Max(firstNumber,secondNumber);
        }
    }
}
