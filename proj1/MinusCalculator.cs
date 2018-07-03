namespace proj1
{
    public class MinusCalculator : ISingleArgumentCalculator
    {
        double ISingleArgumentCalculator.Calculate(double firstNumber)
        {
            return -firstNumber;
        }
    }
}
