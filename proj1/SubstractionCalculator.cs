namespace proj1
{
    public class SubstractionCalculator : ITwoArgumentsCalculator
    {
        double ITwoArgumentsCalculator.Calculate(double firstNumber, double secondNumber)
        {
            return firstNumber - secondNumber;
        }
    }
}
