using System;

namespace Number6
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter a four digit number: ");
                int x = Convert.ToInt32(Console.ReadLine());
                int a1, a2, a3, a4;
                a1 = x / 1000;
                a4 = x % 10;
                a2 = x / 100 % 10;
                a3 = x / 10 % 10;
                int result = a1 * a2 * a3 * a4;

                if (x > 999 && x < 10000)
                {
                    Console.WriteLine("Result: "+ a1 + '*'+ a2+  '*'+ a3 +'*'+ a4 +'=' + result);    //Console.WriteLine("Result: "+ result);
                }
                else
                {
                    Console.WriteLine("Oops, error! Try again.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("FormatException");
            }
             

            



        }
    }
}
