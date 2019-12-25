using System;

namespace Number3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            { try
                {
                    Console.WriteLine("Введите число часов, минут и секунд: ");
                    int hours = Convert.ToInt32(Console.ReadLine());
                    int min = Convert.ToInt32(Console.ReadLine());
                    int sec = Convert.ToInt32(Console.ReadLine());
                    if (hours >= 0 && hours < 12 && min >= 0 && min < 60 && sec >= 0 && sec < 60)
                    {
                        double totalH = (double)hours + (double)min / 60 + (double)sec / 3600;

                        Console.WriteLine("Pre reserved: " + totalH);
                        double corner = totalH * (360 / 12);
                        Console.WriteLine("Result: " + corner);
                    }
                    else
                    {
                        Console.WriteLine("Error.");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("FormatException");
                }
            }

        }
    }
}
