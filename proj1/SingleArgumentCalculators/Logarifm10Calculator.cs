using System;
namespace proj1.SingleArgumentCalculators
{
    public class Logarifm10Calculator : ISingleArgumentCalculator
    {
        double ISingleArgumentCalculator.Calculate(double firstNumber)
        {
            return Math.Log10(firstNumber);
        }
    }
}
