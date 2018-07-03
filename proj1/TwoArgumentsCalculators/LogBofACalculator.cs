using System;

namespace proj1.TwoArgumentsCalculators
{
    public class LogBofACalculator : ITwoArgumentsCalculator
    {
        double ITwoArgumentsCalculator.Calculate(double firstNumber, double secondNumber)
        {
            return Math.Log(firstNumber) / Math.Log(secondNumber);
        }
    }
}
