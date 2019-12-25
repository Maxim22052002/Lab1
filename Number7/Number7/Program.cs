using System;

namespace Number7
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the number: ");
                string text = Console.ReadLine();

                char[] letters = text.ToCharArray();
                Array.Reverse(letters);

                text = String.Concat(letters);
                int reversed = Convert.ToInt32(text);
                if (reversed >= 100 && reversed < 1000)
                {
                    Console.WriteLine("Reversed: " + reversed);
                }
                else { Console.WriteLine("Error! Try again."); }
            }
            catch (FormatException)
            {
                Console.WriteLine("FormatException");
            }
            



        }
    }
}
