using System;
//2.Даны два числа c клавиатуры. Найти среднее арифметическое и среднее геометрическое их  модулей. Math.Abc(a)*Math.Abc(b)

namespace Attest__2_
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите 2 целых числа a, b");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = (Math.Abs(a) + Math.Abs(b)) / 2;
            double d = Math.Sqrt((Math.Abs(a) + Math.Abs(b)));
            Console.WriteLine($"Среднее арифметическое модулей числа a = {a} b = {b} равно {Math.Round(c,2)}");
            Console.WriteLine($"Среднее геометрическое модулей числа a = {a} b = {b} равно {Math.Round(d, 2)}");
            Console.ReadKey();
        }
    }
}
