namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var calculator = new BaseCalculator();
            var calculatormenu = new CalculatorsMenu();
            var calculatorApp = new CalculatorApp();

            calculatorApp.StartCalculator(calculator, calculatormenu);

        }
    }
}