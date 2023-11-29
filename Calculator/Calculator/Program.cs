namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var calculator = new Calculator();
            try 
            {
                calculator.Divide(10, 0);
            } catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }


        }
    }
}