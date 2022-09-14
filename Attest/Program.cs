using System;
//1.	Составить программу:
//а) вычисления значения функции y=7x2+3x+6 при любом значении x;
//б) вычисления значения функции x=12a2+7a+12 при любом значении а.


namespace Attest
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите 2 целых числа x, a");
            double x = double.Parse(Console.ReadLine());
            double a = double.Parse(Console.ReadLine());
            double y = (7*(Math.Pow(x, 2)) + (3 * x) + 6);
            Console.WriteLine($"Результатом выражения y=7x2+3x+6 при x = {x} будет {y}");
            x = (12 * (Math.Pow(a, 2)) + (7 * a) + 12);
            Console.WriteLine($"Результатом выражения x=12a2+7a+12 при a = {a} будет {x}");
            Console.ReadKey();

        }
    }
}
