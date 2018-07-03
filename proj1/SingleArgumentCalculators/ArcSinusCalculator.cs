using System;
namespace proj1.SingleArgumentCalculators
{
    public class ArcSinusCalculator : ISingleArgumentCalculator
    {
        double ISingleArgumentCalculator.Calculate(double firstNumber)
        {
            return Math.Pow(Math.Sin(firstNumber), -1);
        }
    }
}
