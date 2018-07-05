using proj1.Interfaces;

namespace proj1.TwoArgumentsCalculators
{
    public class SubstractionCalculator : ITwoArgumentsCalculator
    {
        /// <summary>
        /// Calculates difference of A and B number
        /// </summary>
        /// <param name="firstNumber">A-Substracted</param>
        /// <param name="secondNumber">B-Substractor</param>
        /// <returns>Difference of A and B number</returns>
        double ITwoArgumentsCalculator.Calculate(double firstNumber, double secondNumber)
        {
            return firstNumber - secondNumber;
        }
    }
}
