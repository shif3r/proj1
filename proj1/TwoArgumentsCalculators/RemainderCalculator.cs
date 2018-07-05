using proj1.Interfaces;

namespace proj1.TwoArgumentsCalculators
{
    public class RemainderCalculator : ITwoArgumentsCalculator
    {
        /// <summary>
        /// Calculates remainder of division of A by B
        /// </summary>
        /// <param name="firstNumber">A-Numerator</param>
        /// <param name="secondNumber">B-Divisor</param>
        /// <returns>Remainder of the division operation</returns>
        double ITwoArgumentsCalculator.Calculate(double firstNumber, double secondNumber)
        {
            return firstNumber % secondNumber;
        }
    }
}
