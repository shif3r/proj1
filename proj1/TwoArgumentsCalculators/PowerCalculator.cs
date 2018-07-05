using System;
using proj1.Interfaces;

namespace proj1.TwoArgumentsCalculators
{
    public class PowerCalculator : ITwoArgumentsCalculator
    {
        /// <summary>
        /// Calculates Bth power of the A-number
        /// </summary>
        /// <param name="firstNumber">A-Number</param>
        /// <param name="secondNumber">B-Number</param>
        /// <returns>Result of the power operation</returns>
        double ITwoArgumentsCalculator.Calculate(double firstNumber, double secondNumber)
        {
            return Math.Pow(firstNumber, secondNumber);
        }
    }
}
