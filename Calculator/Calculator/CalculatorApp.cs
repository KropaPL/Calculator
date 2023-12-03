using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class CalculatorApp
    {
        public void StartCalculator(ICalculator calculator, CalculatorsMenu calculatorsMenu)
        {
            try
            {
                for (;;)
                {
                    calculatorsMenu.MainMenu(calculator);
                    if (calculator.exit == CalculatorsMenu.exitNumber)
                    {
                        break;
                    }
                }
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
