using System;

namespace proj1.TwoArgumentsCalculators
{
    public class TwoArgumentsFactory
    {
        /// <summary>
        /// Returns instance of certain two arguments calculator
        /// </summary>
        /// <param name="calculatorName">Name of operation</param>
        /// <returns>The new instance of two arguments calculator</returns>
        public static ITwoArgumentsCalculator CreateCalculator(string calculatorName)
        {
            switch (calculatorName)
            {
                case "Multiply":
                    return new MultiplicationCalculator();
                case "Divide":
                    return new DivisionCalculator();
                case "Plus":
                    return new AddictionCalculator();
                case "Minus":
                    return new SubstractionCalculator();
                case "Power":
                    return new PowerCalculator();
                case "Remainder":
                    return new RemainderCalculator();
                case "Maximum":
                    return new MaxCalculator();
                case "Minimum":
                    return new MinCalculator();
                case "LogBofA":
                    return new LogBofACalculator();
                case "BRootOfA":
                    return new BRootOfACalculator();
                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}
