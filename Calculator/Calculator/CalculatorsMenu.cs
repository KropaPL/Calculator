using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class CalculatorsMenu
    {
        private static int enterNumberCounter = 1;
        private static int exitNumber = 7;
        public void MainMenu()
        {
            Console.WriteLine("Menu");
            Console.WriteLine("1 - add");
            Console.WriteLine("2 - subtract");
            Console.WriteLine("3 - multiply");
            Console.WriteLine("4 - divide");
            Console.WriteLine("5 - Exponentiation");
            Console.WriteLine("6 - Factorial");
            Console.WriteLine("7 - Exit");
            Console.WriteLine("Choose number to do action: ");
        }

        public void MenuForAdd(ICalculator calculator)
        {
            Console.WriteLine($"Result: {calculator.Add(EnterNumberForCalculation(),EnterNumberForCalculation())}");
        }

        public void MenuForSubtract(ICalculator calculator)
        {
            Console.WriteLine($"Result: {calculator.Subtract(EnterNumberForCalculation(), EnterNumberForCalculation())}");
        }

        public void MenuForDivision(ICalculator calculator)
        {
            Console.WriteLine($"Result: {calculator.Divide(EnterNumberForCalculation(), EnterNumberForCalculation())}");
        }

        public void MenuForMultiplying(ICalculator calculator)
        {
            Console.WriteLine($"Result: {calculator.Multiply(EnterNumberForCalculation(), EnterNumberForCalculation())}");
        }

        public void MenuForExponentiation(ICalculator calculator)
        {
            Console.WriteLine($"Result: {calculator.Exponentiation(EnterNumberForCalculation(), EnterNumberForCalculation())}");
        }
        public void MenuForFactorial(ICalculator calculator)
        {
            bool isFactorial = true;
            Console.WriteLine($"Result: {calculator.Factorial((ulong)EnterNumberForCalculation(isFactorial))}");
        }

        private double EnterNumberForCalculation(bool isFactorial = false)
        {
            if (!isFactorial) {
                Console.WriteLine($"Enter a {enterNumberCounter}. number: ");
                enterNumberCounter++;
                if (enterNumberCounter == 3)
                {
                    enterNumberCounter = 1;
                }
                return Convert.ToDouble(Console.ReadLine());
            } 
            else
            {
                Console.WriteLine($"Enter a number: ");
                ulong number = (ulong)Convert.ToUInt64(Console.ReadLine());
                return number;
            }

        }
       
    }
}
