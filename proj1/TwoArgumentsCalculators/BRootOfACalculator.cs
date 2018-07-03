using System;

namespace proj1.TwoArgumentsCalculators
{
    public class BRootOfACalculator : ITwoArgumentsCalculator
    {
        double ITwoArgumentsCalculator.Calculate(double firstNumber, double secondNumber)
        {
            return Math.Pow(firstNumber,1/secondNumber);
        }
    }
}
