using System;

namespace Number9
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter a number a1: ");
                int a1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter a number a2: ");
                int a2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter a number a3: ");
                int a3 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter a number b1: ");
                int b1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter a number b2: ");
                int b2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter a number b3: ");
                int b3 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter a number c1: ");
                int c1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter a number c2: ");
                int c2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter a number c3: ");
                int c3 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter a number d1: ");
                int d1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter a number d2: ");
                int d2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter a number d3: ");
                int d3 = Convert.ToInt32(Console.ReadLine());
                double determinant = a1 * (b2 * c3 - b3 * c2) - b1 * (a2 * c3 - a3 * c2) + c1 * (a2 * b3 - a3 * b2);
                if (determinant != 0)
                {
                    double determinantX = d1 * (b2 * c3 - b3 * c2) - b1 * (d2 * c3 - d3 * c2) + c1 * (d2 * b3 - d3 * b2);
                    double determinantY = a1 * (d2 * c3 - d3 * c2) - d1 * (a2 * c3 - a3 * c2) + c1 * (a2 * d3 - a3 * d2);
                    double determinantZ = a1 * (b2 * d3 - b3 * d2) - b1 * (a2 * d3 - a3 * d2) + d1 * (a2 * b3 - a3 * b2);
                    double X = determinantX / determinant;
                    double Y = determinantY / determinant;
                    double Z = determinantZ / determinant;
                    Console.WriteLine("Result: " + " x= " + X + ',' + " y= " + Y + ',' + " z= " + Z + '.');
                }
                else
                {
                    Console.WriteLine("Determinant can not be zero. Try again.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("FormatException");
            }


        }
        
    }
}
