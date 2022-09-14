using System;
/*Задание 6
Используя VisualStudio, создайте проект по шаблону ConsoleApplication.
Напишите программу, которая находит сумму и произведение трёх целых чисел, введённых с клавиатуры.*/

namespace SumProizv__6_
{
    internal class Program
    {
        static void Main()
        {

            Console.WriteLine("Введите 3 целых числа");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            double summa = a + b + c;
            double proizv = a * b * c;

            Console.WriteLine("Сумма трех чисел {0},{1},{2} равна {3}", a, b, c, summa);
            Console.WriteLine("Произведение трех чисел {0},{1},{2} равно {3}", a, b, c, proizv);

            Console.ReadKey();
        }
    }
}
