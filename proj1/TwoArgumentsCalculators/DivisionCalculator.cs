using System;
using proj1.Interfaces;

namespace proj1.TwoArgumentsCalculators
{
    public class DivisionCalculator : ITwoArgumentsCalculator
    {
        /// <summary>
        /// Calculates the quotient of two numbers
        /// </summary>
        /// <param name="firstNumber">Numerator</param>
        /// <param name="secondNumber">Divider</param>
        /// <returns>Quotient</returns>
        double ITwoArgumentsCalculator.Calculate(double firstNumber, double secondNumber)
        {
            if (secondNumber == 0)
            {
                throw new Exception("Деление на 0");
            }
            return firstNumber / secondNumber;
        }
    }
}
