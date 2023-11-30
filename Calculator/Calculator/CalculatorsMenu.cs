using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class CalculatorsMenu
    {
        private static int enterNumberCounter = 1;
        public void MainMenu()
        {
            Console.WriteLine("Menu");
            Console.WriteLine("1 - add");
            Console.WriteLine("2 - subtract");
            Console.WriteLine("3 - multiply");
            Console.WriteLine("4 - divide");
            Console.WriteLine("5 - Exponentiation");
            Console.WriteLine("6 - Factorial");
        }

        public void MenuForAdd(ICalculator calculator)
        {
            Console.WriteLine("Result: " + calculator.Add(EnterNumber(),EnterNumber()));
        }

        public void MenuForSubtract(ICalculator calculator)
        {
            Console.WriteLine("Result: " + calculator.Subtract(EnterNumber(), EnterNumber()));
        }

        public void MenuForDivision(ICalculator calculator)
        {
            Console.WriteLine("Result: " + calculator.Divide(EnterNumber(), EnterNumber()));
        }

        public void MenuForMultiplying(ICalculator calculator)
        {
            Console.WriteLine("Result: " + calculator.Multiply(EnterNumber(), EnterNumber()));
        }

        public void MenuForExponentiation(ICalculator calculator)
        {
            Console.WriteLine("Result: " + calculator.Exponentiation(EnterNumber(), EnterNumber()));

        }

        private double EnterNumber()
        {
            Console.WriteLine($"Enter a {enterNumberCounter}. number: ");
            enterNumberCounter++;
            if ( enterNumberCounter == 3 ) 
            {
            enterNumberCounter = 1;
            }
            return Convert.ToDouble(Console.ReadLine());
        }



    }
}
