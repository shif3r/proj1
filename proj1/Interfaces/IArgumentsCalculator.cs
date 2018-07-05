namespace proj1.Interfaces
{
    /// <summary>
    /// Programm interface for double arguments maths operations
    /// </summary>
    public interface ITwoArgumentsCalculator
    {
        /// <summary>
        /// Provides certaion two arguments math operation
        /// </summary>
        /// <param name="firstNumber">First argument</param>
        /// <param name="secondNumber">Second argument</param>
        /// <returns>Result of two arguments math operation</returns>
        double Calculate(double firstNumber, double secondNumber);
    }
}