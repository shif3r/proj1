using System;
namespace proj1.SingleArgumentCalculators
{
    public class CosinusCalculator : ISingleArgumentCalculator
    {
        double ISingleArgumentCalculator.Calculate(double firstNumber)
        {
            if (firstNumber > 1 || firstNumber < -1)
            {
                throw new Exception("Нельзя");
            }
            return Math.Cos(firstNumber);
        }
    }
}
