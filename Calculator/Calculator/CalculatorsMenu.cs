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
        public static int exitNumber = 0;
        public void MainMenu(ICalculator calculator) 
        {
            for (int i = 0; i < calculator.ListOfMethods.Count; i++)
            {
                Console.WriteLine($"{i+1} - {calculator.ListOfMethods[i]}");
            }
            Console.WriteLine($"{calculator.ListOfMethods.Count + 1} - Exit");
            exitNumber = calculator.ListOfMethods.Count + 1;
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
            Console.WriteLine($"Result: {calculator.Factorial((long)EnterNumberForCalculation(isFactorial))}");
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
                long number = (long)Convert.ToInt32(Console.ReadLine());
                return number;
            }

        }
        private int EnterChoiceNumber()
        {
            int x = Convert.ToInt32(Console.ReadLine());
            if (x <= 0)
            {
                Console.WriteLine("Entered wrong number");
                return 0;
            }
            return x;
        }
       
    }
}
