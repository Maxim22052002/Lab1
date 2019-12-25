using System;

namespace Price_List
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите: наименование товара, тип товара, цена за 1шт(грн), количество >");
            string name1 = Console.ReadLine();
            string type1 = Console.ReadLine();
            decimal price1 = Convert.ToDecimal(Console.ReadLine());
            int quan1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите: наименование товара, тип товара, цена за 1шт(грн), количество >");
            string name2 = Console.ReadLine();
            string type2 = Console.ReadLine();
            decimal price2 = Convert.ToDecimal(Console.ReadLine());
            int quan2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите: наименование товара, тип товара, цена за 1шт(грн), количество >");
            string name3 = Console.ReadLine();
            string type3 = Console.ReadLine();
            decimal price3 = Convert.ToDecimal(Console.ReadLine());
            int quan3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine("|Прайс-лист                                                          |");
            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine("| Наименование товара | Тип товара | Цена за 1 шт (грн) | Количество |");
            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine($"| {name1,-19} | {type1,-10} | {price1,-18} | {quan1,-10} |");
            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine($"| {name2,-19} | {type2,-10} | {price2,-18} | {quan2,-10} |");
            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine($"| {name3,-19} | {type3,-10} | {price3,-18} | {quan3,-10} |");
            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine("| Перечисляемый тип: К – канцтовары, О - оргтехника                  |");
            Console.WriteLine("----------------------------------------------------------------------");
            Console.ReadKey();
        }
    }
}
