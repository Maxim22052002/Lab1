using System;

namespace number1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter fractional number: ");
                string a;
                a = Console.ReadLine();
                double x = Convert.ToDouble(a);

                int d = (int)((x - (int)x) * 10);
                Console.WriteLine("Result: "+ d);
            }
            catch (FormatException)
            {
                Console.WriteLine("FormatException");
                
            }




        }
    }
}
