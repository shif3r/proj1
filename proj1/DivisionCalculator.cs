namespace proj1
{
    public class DivisionCalculator : ITwoArgumentsCalculator
    {
        double ITwoArgumentsCalculator.Calculate(double firstNumber, double secondNumber)
        {
            return firstNumber / secondNumber;
        }
    }
}
