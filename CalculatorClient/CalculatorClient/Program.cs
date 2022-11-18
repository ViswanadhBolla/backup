using CalculatorLib;
namespace CalculatorClient
{
    internal class Program
    {
        public static Calculator cal = new Calculator();

        public static void main(string[] args)
        {
            float result = cal.div(5,2);
            Console.WriteLine(result);
        }
    } 
}