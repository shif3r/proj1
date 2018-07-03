namespace proj1
{
    public class AddictionCalculator : ITwoArgumentsCalculator
    {
        double ITwoArgumentsCalculator.Calculate(double firstNumber, double secondNumber)
        {
            return firstNumber + secondNumber;
        }
    }
}
