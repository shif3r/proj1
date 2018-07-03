using System;
namespace proj1.SingleArgumentCalculators
{
    public class Pow2Calculator : ISingleArgumentCalculator
    {
        double ISingleArgumentCalculator.Calculate(double firstNumber)
        {
            return Math.Pow(firstNumber, 2);
        }
    }
}
