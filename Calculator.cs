using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_XUnit___Acceptanstestning
{
    public class Calculator
    {
        private List<string> _calculationHistory = new List<string>();

        public double PerformAddition(double a, double b)
        {
            double result = a + b;
            SaveCalculation($"{a} + {b} = {result}");
            return result;
        }

        public double PerformSubtraction(double a, double b)
        {
            double result = a - b;
            SaveCalculation($"{a} - {b} = {result}");
            return result;
        }

        public double PerformMultiplication(double a, double b)
        {
            double result = a * b;
            SaveCalculation($"{a} * {b} = {result}");
            return result;
        }

        public double PerformDivision(double a, double b)
        {
            if (b == 0)
                throw new DivideByZeroException("Cannot divide by zero.");
            double result = a / b;
            SaveCalculation($"{a} / {b} = {result}");
            return result;
        }

        public void SaveCalculation(string calculation)
        {
            _calculationHistory.Add(calculation);
        }

        public List<string> GetPreviousCalculations()
        {
            return _calculationHistory;
        }
    }
}
