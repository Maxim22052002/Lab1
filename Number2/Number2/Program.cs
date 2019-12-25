using System;

namespace Number2
{
    class Program
    {
        static void Main(string[] args)
        {
            try { 
                
                Console.WriteLine("Enter the number of seconds: ");
                int hours, min;
                int sec = Convert.ToInt32(Console.ReadLine());
                hours = sec / 3600;
                min = (sec % 3600) / 60;

                Console.WriteLine("It's " + hours + " hours " + min + " minutes.");
            }
            catch (FormatException)
            {
                Console.WriteLine("FormatException");

            }

                
            

        }
    }
}
