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
                calculatormenu.ChoosingOperation(calculator);
            }
            catch (Exception ex) 
            {
            Console.WriteLine(ex.Message);
            }


        }
    }
}