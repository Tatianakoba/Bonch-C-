using System;
/*Задание 8
Используя VisualStudio, создайте проект по шаблону ConsoleApplication
Напишите программу для решения следующей задачи:
Найдите гипотенузу прямоугольного треугольника с заданными катетами, которые пользователь вводит с клавиатуры. Входные данные – целые числа.
Примечание: формула для вычисления гипотенузы 𝑐 = √(а2 + b2)*/

namespace Gipotenuza__8_
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите катеты");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            double gip = Math.Sqrt(a * a + b * b);
            Console.WriteLine("Гипотенуза треугольника с катетами {0},{1} равно {2}", a, b, Math.Round(gip,3));

            Console.ReadKey();

        }
    }
}
