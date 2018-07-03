using System;
namespace proj1
{
    public class SinusCalculator : ISingleArgumentCalculator
    {
        double ISingleArgumentCalculator.Calculate(double firstNumber)
        {
            return Math.Asin(firstNumber);
        }
    }
}
