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

        public void ChoosingOperation(ICalculator calculator)
        {
            ShowingMainMenu(calculator);
            int optionNumber = EnterChoiceNumber(calculator) - 1;
            CheckingFunctionFromList(optionNumber,calculator);
        }

        public void CheckingFunctionFromList(int choice, ICalculator calculator)
        {
            if (choice >= 0 && choice < calculator.ListOfMethods.Count)
            {
                if ("add".Equals(calculator.ListOfMethods[choice].ToLower()))
                {
                    ShowingMenuForAdd(calculator);
                }
                else if ("subtract".Equals(calculator.ListOfMethods[choice].ToLower()))
                {
                    ShowingMenuForSubtract(calculator);
                }
                else if ("multiply".Equals(calculator.ListOfMethods[choice].ToLower()))
                {
                    ShowingMenuForMultiplying(calculator);
                }
                else if ("divide".Equals(calculator.ListOfMethods[choice].ToLower()))
                {
                    ShowingMenuForDivision(calculator);
                }
                else if ("exponentiation".Equals(calculator.ListOfMethods[choice].ToLower()))
                {
                    ShowingMenuForExponentiation(calculator);
                }
                else if ("factorial".Equals(calculator.ListOfMethods[choice].ToLower()))
                {
                    ShowingMenuForFactorial(calculator);
                }
            }
            if (choice == exitNumber)
            {
                Environment.Exit(0);
            }
        }



        public void ShowingMainMenu(ICalculator calculator) 
        {
            Console.WriteLine("Calculator's Menu");
            for (int i = 0; i < calculator.ListOfMethods.Count; i++)
            {
                Console.WriteLine($"{i+1} - {calculator.ListOfMethods[i]}");
            }
            Console.WriteLine($"{calculator.ListOfMethods.Count + 1} - Exit");
            exitNumber = calculator.ListOfMethods.Count + 1;
        }

        public void ShowingMenuForAdd(ICalculator calculator)
        {
            Console.WriteLine("Addition");
            Console.WriteLine($"Result: {calculator.Add(EnterNumberForCalculation(),EnterNumberForCalculation())}");
        }

        public void ShowingMenuForSubtract(ICalculator calculator)
        {
            Console.WriteLine("Subtraction");
            Console.WriteLine($"Result: {calculator.Subtract(EnterNumberForCalculation(), EnterNumberForCalculation())}");
        }

        public void ShowingMenuForDivision(ICalculator calculator)
        {
            Console.WriteLine("Division");
            Console.WriteLine($"Result: {calculator.Divide(EnterNumberForCalculation(), EnterNumberForCalculation())}");
        }

        public void ShowingMenuForMultiplying(ICalculator calculator)
        {
            Console.WriteLine("Multiplying");
            Console.WriteLine($"Result: {calculator.Multiply(EnterNumberForCalculation(), EnterNumberForCalculation())}");
        }

        public void ShowingMenuForExponentiation(ICalculator calculator)
        {
            Console.WriteLine("Exponentiation");
            Console.WriteLine($"Result: {calculator.Exponentiation(EnterNumberForCalculation(), EnterNumberForCalculation())}");
        }
        public void ShowingMenuForFactorial(ICalculator calculator)
        {
            bool isFactorial = true;
            Console.WriteLine("Factorial");
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
        private int EnterChoiceNumber(ICalculator calculator)
        {
            Console.Write("Enter number for operation: ");
            int x = Convert.ToInt32(Console.ReadLine());
            if (x <= 0 || x > calculator.ListOfMethods.Count + 1)
            {
                Console.WriteLine("Entered wrong number");
                return 0;
            }
            return x;
        }
       
    }
}
