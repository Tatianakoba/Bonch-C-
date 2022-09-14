using System;
//Тернарный оператор

namespace Lesson4
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите два числа a и b");
            int a = int.Parse(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int max = 0;
            max = (a > b) ? a : b;

            Console.WriteLine("Максимальное:");
            Console.WriteLine(max);
            Console.WriteLine(Math.Max(a,b));

            Console.ReadKey();
        }
    }
}
