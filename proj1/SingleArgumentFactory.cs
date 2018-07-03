using System;
using proj1.SingleArgumentCalculators;

namespace proj1
{
    public class SingleArgumentFactory
    {
        public static ISingleArgumentCalculator CreateCalculator(string calculatorName)
        {
            switch (calculatorName)
            {
                case "Sinus":
                    return new SinusCalculator();
                case "Loge":
                    return new LogECalculator();
                case "Cosinus":
                    return new CosinusCalculator();
                case "powE":
                    return new PowECalculator();
                case "Inversion":
                    return new MinusCalculator();
                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}
