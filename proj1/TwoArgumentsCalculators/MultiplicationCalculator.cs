using proj1.Interfaces;

namespace proj1.TwoArgumentsCalculators
{
    public class MultiplicationCalculator : ITwoArgumentsCalculator
    {
        /// <summary>
        /// Calculates multiplication product of two numbers
        /// </summary>
        /// <param name="firstNumber">First number</param>
        /// <param name="secondNumber">Second number</param>
        /// <returns>Product</returns>
        double ITwoArgumentsCalculator.Calculate(double firstNumber, double secondNumber)
        {
            return firstNumber * secondNumber;
        }
    }
}
