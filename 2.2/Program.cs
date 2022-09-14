using System;
/*Упражнение 2
Напишите программу, которая выводит на консоль таблицу умножения*/

namespace _2._2
{
    internal class Program
    {
        static void Main()
        {
            int sum = 0;
            for (int i = 1; i < 10; i++)//строка
            {
                // Выводим одну строку из 10 звездочек.
                for (int j = 1; j < 10; j++)//столбец
                {
                    sum = i * j;
                    Console.Write("{0}\t", sum);

                }

                // Переход на новую строку.
                Console.WriteLine();// Console.Write("\n");
            }

            // Delay.
            Console.ReadKey();
        }
    }
}
