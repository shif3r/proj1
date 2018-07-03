namespace proj1.SingleArgumentCalculators
{
    public class MinusCalculator : ISingleArgumentCalculator
    {
        double ISingleArgumentCalculator.Calculate(double firstNumber)
        {
            return -firstNumber;
        }
    }
}
