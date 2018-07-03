namespace proj1
{
    public class MultiplicationCalculator : ITwoArgumentsCalculator
    {
        double ITwoArgumentsCalculator.Calculate(double firstNumber, double secondNumber)
        {
            return firstNumber * secondNumber;
        }
    }
}
