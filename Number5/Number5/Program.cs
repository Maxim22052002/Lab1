using System;

namespace Number5
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double perimetr, area;
                Console.WriteLine("Enter the length of the first leg:");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter the length of the second leg:");
                double b = Convert.ToDouble(Console.ReadLine());
                double c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
                perimetr = a + b + c;
                Console.WriteLine("Perimetr: " + perimetr);
                area = (a * b) / 2;
                Console.WriteLine("Area: " + area);
            }
            catch(FormatException)
            {
                Console.WriteLine("FormatException");

            }

        }
    }
}
