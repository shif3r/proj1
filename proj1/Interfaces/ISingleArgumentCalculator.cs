namespace proj1.Interfaces
{
    /// <summary>
    /// Programm interface for single argument maths operations
    /// </summary>
    public interface ISingleArgumentCalculator
    {
        /// <summary>
        /// Provides certain one argument math operation
        /// </summary>
        /// <param name="firstNumber">First argument</param>
        /// <returns>Result of one arguments math operation</returns>
        double Calculate(double firstNumber);
    }
}
