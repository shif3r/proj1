using System;
namespace proj1.SingleArgumentCalculators
{
    public class ArcCosinusCalculator : ISingleArgumentCalculator
    {
        double ISingleArgumentCalculator.Calculate(double firstNumber)
        {
            return Math.Pow(Math.Cos(firstNumber), -1);
        }
    }
}
