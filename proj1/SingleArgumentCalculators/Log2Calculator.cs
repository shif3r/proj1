using System;
namespace proj1.SingleArgumentCalculators
{
    public class Logarifm2Calculator : ISingleArgumentCalculator
    {
        double ISingleArgumentCalculator.Calculate(double firstNumber)
        {
            return Math.Log(2, firstNumber);
        }
    }
}
