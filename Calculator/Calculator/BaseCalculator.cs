using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class BaseCalculator : ICalculator
    {
        public List<string> ListOfMethods { get; set; }
        public int exit { get; set; }

        public BaseCalculator()
        {
            ListOfMethods = new List<string>
        {
            "Add",
            "Subtract",
            "Multiply",
            "Divide",
            "Exponentiation",
            "Factorial"
        };
        }

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
                SetColorRed();
                Console.WriteLine("Division by zero is not allowed.");
                UnsetColor();
                return 0;
            }
            return a/b;
        }

        public double Exponentiation( double a, double b ) 
        {

            return Math.Pow(a,b);
        }

        public long Factorial( long a ) 
        {
            if (a < 0)
            {
                SetColorRed();
                Console.WriteLine("Entered a negative number");
                UnsetColor();
                return 0;
            }

            long result = 1;

            for (long i = 1; i <= a; i++)
            {
                result *= i;
            }

            return result;
        }

        public void SetColorRed()
        {
            Console.ForegroundColor = ConsoleColor.Red;
        }

        public void UnsetColor()
        {
            Console.ForegroundColor = ConsoleColor.White; 
        }
    }
}
