using System;

namespace proj1.TwoArgumentsCalculators
{
    public class RemainderCalculator : ITwoArgumentsCalculator
    {
        double ITwoArgumentsCalculator.Calculate(double firstNumber, double secondNumber)
        {
            return firstNumber%secondNumber;
        }
    }
}
