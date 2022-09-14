using System;
//3.	Известна стоимость 1 кг конфет, печенья и яблок. Найти стоимость всей покупки, если купили x кг конфет, у кг печенья и z кг яблок.

namespace Attest__3_
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите стоимость 1 кг конфет");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите стоимость 1 кг печенья");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите стоимость 1 кг яблок");
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество конфет в кг");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество печенья в кг");
            double y = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество яблок в кг");
            double z = double.Parse(Console.ReadLine());
            double sum = 0;
            double ax = a * x;
            double by = b * y;
            double cz = c * z;
            sum = ax + by + cz;
            Console.WriteLine($"Общая стоимость покупки  {a} кг конфет, {b} кг печенья и {c} кг яблок составит {Math.Round(sum, 2)} рублей");
            Console.ReadKey();
        }

    }
}
