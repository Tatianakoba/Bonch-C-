using System;
/*Задание 7
Используя VisualStudio, создайте проект по шаблону ConsoleApplication
Напишите программу для решения следующей задачи:
N школьников делят K яблок поровну, неделящийся остаток остается в корзинке. Сколько яблок достанется каждому школьнику?
Примечание: все исходные данные вводятся с клавиатуры*/

namespace Shkolniki__7_
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите количество школьников");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество яблок");
            int K = int.Parse(Console.ReadLine());
            int c = K / N;
            double b = K % N;

            Console.WriteLine("Каждому школьнику достанется по {0} яблок", c);
            Console.WriteLine("В корзине остается {0} яблок", b);
            Console.ReadKey();
        }
    }
}
