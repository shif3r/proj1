using System;

namespace proj1.TwoArgumentsCalculators
{
    public class DivisionCalculator : ITwoArgumentsCalculator
    {
        double ITwoArgumentsCalculator.Calculate(double firstNumber, double secondNumber)
        {
            if (secondNumber == 0)
            {
                throw new Exception("Деление на 0");
            }
            return firstNumber / secondNumber;
        }
    }
}
