using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal  class CalculatorsMenu
    {
        private static int enterNumberCounter = 1;
        public static int exitNumber = 0;

        public void MainMenu(ICalculator calculator)
        {
            GeneratingMainMenu(calculator);
            int optionNumber = EnterChoiceNumber(calculator) - 1;
            CheckingFunctionFromList(optionNumber,calculator);
        }

        private void CheckingFunctionFromList(int choice, ICalculator calculator)
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
            if (choice == exitNumber - 1)
            {
                calculator.exit = CalculatorsMenu.exitNumber;
            }
        }



        public void GeneratingMainMenu(ICalculator calculator) 
        {
            Console.WriteLine("Calculator's Menu");
            for (int i = 0; i < calculator.ListOfMethods.Count; i++)
            {
                Console.WriteLine($"{i+1} - {calculator.ListOfMethods[i]}");
            }
            Console.WriteLine($"{calculator.ListOfMethods.Count + 1} - Exit");
            exitNumber = calculator.ListOfMethods.Count + 1;
        }

        private void ShowingMenuForAdd(ICalculator calculator)
        {
            Console.WriteLine("Addition");
            Console.WriteLine($"Result: {calculator.Add(EnterNumberForCalculation(),EnterNumberForCalculation())}");
        }

        private void ShowingMenuForSubtract(ICalculator calculator)
        {
            Console.WriteLine("Subtraction");
            Console.WriteLine($"Result: {calculator.Subtract(EnterNumberForCalculation(), EnterNumberForCalculation())}");
        }

        private void ShowingMenuForDivision(ICalculator calculator)
        {
            Console.WriteLine("Division");
            double result = calculator.Divide(EnterNumberForCalculation(), EnterNumberForCalculation());
            if (!(result == 0))
            {
                Console.WriteLine($"Result: {result}");
            }
        }

        private void ShowingMenuForMultiplying(ICalculator calculator)
        {
            Console.WriteLine("Multiplying");
            Console.WriteLine($"Result: {calculator.Multiply(EnterNumberForCalculation(), EnterNumberForCalculation())}");
        }

        private void ShowingMenuForExponentiation(ICalculator calculator)
        {
            Console.WriteLine("Exponentiation");
            Console.WriteLine($"Result: {calculator.Exponentiation(EnterNumberForCalculation(), EnterNumberForCalculation())}");
        }
        private void ShowingMenuForFactorial(ICalculator calculator)
        {
            bool isFactorial = true;
            Console.WriteLine("Factorial");
            long result = calculator.Factorial((long)EnterNumberForCalculation(isFactorial));
            if (!(result == 0))
            {
                Console.WriteLine($"Result: {result}");
            }
        }

        private double EnterNumberForCalculation(bool isFactorial = false)
        {
            if (!isFactorial) {

                if (enterNumberCounter == 3)
                {
                    enterNumberCounter = 1;
                }
                bool isNumber = false;
                while (!isNumber)
                {
                    SetColorGreen();
                    Console.WriteLine($"Enter a {enterNumberCounter}. number: ");
                    UnsetColor();
                    string x = Console.ReadLine();
                    if (double.TryParse(x, out double number))
                    {
                        isNumber = true;
                        enterNumberCounter++;
                        return number;
                    }
                    else
                    {
                        NoNumberEnteredAnnouncement();
                    }

                }
                return 0;
            } 
            else
            {
                bool isNumber = false;
                while (!isNumber)
                {
                    SetColorGreen();
                    Console.WriteLine($"Enter a number: ");
                    UnsetColor();
                    string x = Console.ReadLine();
                    if (long.TryParse(x, out long number))
                    {
                        isNumber = true;
                        return number;
                    }
                    else
                    {
                        NoNumberEnteredAnnouncement();
                    }
                }
                return 0;
            }
        }

        private int EnterChoiceNumber(ICalculator calculator)
        {
            Console.Write("Enter number for operation: ");
            string x = Console.ReadLine();
            if (int.TryParse(x, out int parsedValue))
            {
                if (parsedValue <= 0 || parsedValue > calculator.ListOfMethods.Count + 1)
                {
                    WrongNumberEnteredAnnouncement();
                    return 0;
                }
                return parsedValue;
            }
            else
            {
                NoNumberEnteredAnnouncement();
                return 0;
            }
        }

        private void NoNumberEnteredAnnouncement() 
        {
            SetColorRed();
            Console.WriteLine("You didn't enter a number, try again");
            UnsetColor();
        }

        private void WrongNumberEnteredAnnouncement()
        {
            SetColorRed();
            Console.WriteLine("Entered wrong number");
            UnsetColor();
        }

        private void SetColorGreen()
        {
            Console.ForegroundColor = ConsoleColor.Green;
        }
        private void SetColorRed()
        {
            Console.ForegroundColor = ConsoleColor.Red;
        }

        private void UnsetColor()
        {
            Console.ForegroundColor= ConsoleColor.White;
        }
       
    }
}
