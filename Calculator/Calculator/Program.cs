namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var calculator = new Calculator();
            var calculatormenu = new CalculatorsMenu();

            calculatormenu.MenuForAdd(calculator);

        }
    }
}