using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal interface ICalculator
    {
        List<String> ListOfMethods { get; set; }
        int exit { get; set; }
        double Add (double x, double y);
        double Subtract (double x, double y);
        double Multiply (double x, double y);
        double Divide (double x, double y);
        double Exponentiation(double x, double y);
        public long Factorial(long x);

    }
}
