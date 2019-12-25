using System;

namespace Number4
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the first number: ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the second number: ");
                int b = Convert.ToInt32(Console.ReadLine());
                a = a + b;
                b = a - b;
                a = a - b;
                Console.WriteLine("Result: " + a + " , " + b);
            }
            catch (FormatException)
            {
                Console.WriteLine("FormatException");
            }
            

        }
    }
}
