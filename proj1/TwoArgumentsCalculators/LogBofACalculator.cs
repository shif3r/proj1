using System;

namespace proj1.TwoArgumentsCalculators
{
    public class LogBofACalculator : ITwoArgumentsCalculator
    {
        /// <summary>
        /// Calculate logarithm to the base B of number A
        /// </summary>
        /// <param name="firstNumber">A - number</param>
        /// <param name="secondNumber">B - number</param>
        /// <returns>Result of logarithm operation</returns>
        double ITwoArgumentsCalculator.Calculate(double firstNumber, double secondNumber)
        {
            return Math.Log(firstNumber, secondNumber);
        }
    }
}
