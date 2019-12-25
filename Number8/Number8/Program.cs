using System;

namespace Number8
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter number x: ");
                double x = Convert.ToDouble(Console.ReadLine());
                double result = 3 * Math.Pow(x, 4) - 5 * Math.Pow(x, 3) + 2 * Math.Pow(x, 2) - x + 7;
                Console.WriteLine("Result: " + result);
            }
            catch (FormatException)
            {
                Console.WriteLine("FormatException");
            }
        }
    }
}
