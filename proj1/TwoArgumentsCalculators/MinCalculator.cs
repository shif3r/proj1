using System;

namespace proj1.TwoArgumentsCalculators
{
    public class MinCalculator : ITwoArgumentsCalculator
    {
        double ITwoArgumentsCalculator.Calculate(double firstNumber, double secondNumber)
        {
            return Math.Min(firstNumber,secondNumber);
        }
    }
}
