using System;
using System.Collections.Generic;
using System.Text;

namespace dfufhj
{

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the value x: ");
                double x = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter the value b: ");
                double b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter the value a: ");
                double a = Convert.ToDouble(Console.ReadLine());
                if (x != 0 && a != 0 && b != 0 && Math.Pow(x, 2) + b >= 0)
                {
                    double ω = Math.Sqrt(Math.Pow(x, 2) + b) - Math.Pow(b, 2) * Math.Pow(Math.Sin(x + a), 3) / x;
                    double y = Math.Pow(Math.Cos(Math.Pow(x, 3)), 2) - x / Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
                    Console.WriteLine(ω);
                    Console.WriteLine(y);
                    
                }
                else
                {
                    Console.WriteLine("Error! Try again.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("FormatException");
            }
        }
        

    }
}