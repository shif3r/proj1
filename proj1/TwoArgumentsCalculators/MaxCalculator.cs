using System;

namespace proj1.TwoArgumentsCalculators
{
    public class MaxCalculator : ITwoArgumentsCalculator
    {
        double ITwoArgumentsCalculator.Calculate(double firstNumber, double secondNumber)
        {
            return Math.Max(firstNumber,secondNumber);
        }
    }
}
