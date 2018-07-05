using System;
using proj1.Interfaces;
using proj1.SingleArgumentCalculators;

namespace proj1
{
    public class SingleArgumentFactory
    {
        /// <summary>
        /// Returns instance of certain single argument calculator
        /// </summary>
        /// <param name="calculatorName">Name of operation</param>
        /// <returns>The new instance of single argument calculator</returns>
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
                case "Logarifm2":
                    return new Logarifm2Calculator();
                case "Logarifm10":
                    return new Logarifm10Calculator();
                case "Pow2":
                    return new Pow2Calculator();
                case "ArcSinus":
                    return new ArcSinusCalculator();
                case "ArcCosinus":
                    return new ArcCosinusCalculator();
                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}
