using System;
namespace proj1.SingleArgumentCalculators
{
    public class CosinusCalculator : ISingleArgumentCalculator
    {
        double ISingleArgumentCalculator.Calculate(double firstNumber)
        {
            return Math.Cos(firstNumber);
        }
    }
}
