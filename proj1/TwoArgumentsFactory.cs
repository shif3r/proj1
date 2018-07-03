using System;

namespace proj1
{
    public class TwoArgumentsFactory
    {
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
                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}
