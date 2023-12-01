namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var calculator = new Calculator();
            var calculatormenu = new CalculatorsMenu();
            try
            {
                calculatormenu.MainMenu(calculator);
                Console.WriteLine(CalculatorsMenu.exitNumber);
            }
            catch (Exception ex) 
            {
            Console.WriteLine(ex.Message);
            }


        }
    }
}