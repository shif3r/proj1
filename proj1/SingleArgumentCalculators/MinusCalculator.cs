using proj1.Interfaces;

namespace proj1.SingleArgumentCalculators
{
    public class MinusCalculator : ISingleArgumentCalculator
    {
        /// <summary>
        /// Inverts the number
        /// </summary>
        /// <param name="firstNumber">Argument</param>
        /// <returns>Result of inversion</returns>
        double ISingleArgumentCalculator.Calculate(double firstNumber)
        {
            return -firstNumber;
        }
    }
}
