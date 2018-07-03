using System;
namespace proj1
{
    public class CosinusCalculator : ISingleArgumentCalculator
    {
        double ISingleArgumentCalculator.Calculate(double firstNumber)
        {
            return Math.Cos(firstNumber);
        }
    }
}
