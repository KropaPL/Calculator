using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal interface ICalculator
    {
        double Add (double x, double y);
        double Subtract (double x, double y);
        double Multiply (double x, double y);
        double Divide (double x, double y);
        double Exponentiation(double x, double y);
        public ulong Factorial(ulong x);

    }
}
