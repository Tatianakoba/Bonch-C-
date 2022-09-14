using System;
/*Задание 10
Используя VisualStudio, создайте проект по шаблону ConsoleApplication.
Напишите программу для решения следующей задачи:
Дано натуральное число, выведите его последнюю цифру*/

namespace Cifra
{
    internal class Program
    {
        static void Main()
        {

            Console.WriteLine("Введите натуральное число");
            int N = int.Parse(Console.ReadLine());
            int result = N % 10;
            Console.WriteLine("Последняя цифра числа {0} равна {1}",N, result);
            Console.ReadKey();
        }
    }
}
