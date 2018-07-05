using proj1.Interfaces;

namespace proj1.TwoArgumentsCalculators
{
    public class AddictionCalculator : ITwoArgumentsCalculator
    {
        /// <summary>
        /// Calculates the sum of two numbers
        /// </summary>
        /// <param name="firstNumber">First number</param>
        /// <param name="secondNumber">Second number</param>
        /// <returns>Sum</returns>
        double ITwoArgumentsCalculator.Calculate(double firstNumber, double secondNumber)
        {
            return firstNumber + secondNumber;
        }
    }
}
