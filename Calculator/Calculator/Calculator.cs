using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Calculator : ICalculator
    {

        public double Add( double a, double b )
        {
            return a + b;
        }

        public double Subtract( double a, double b) 
        { 
            return a-b;
        }
        
        public double Multiply( double a, double b )
        {
            return a*b;
        }

        public double Divide( double a, double b )
        {
            if ( b == 0 ) 
            {
                throw new ArgumentException("Division by zero is not allowed.");
            }
            return a/b;
        }

        public double Exponentiation( double a, double b ) 
        {
            return Math.Pow(a,b);
        }

        public ulong Factorial( ulong a ) 
        {
            ulong result = 1;

            for (ulong i = 1; i <= a; i++)
            {
                result *= i;
            }

            return result;
        }
    }
}
