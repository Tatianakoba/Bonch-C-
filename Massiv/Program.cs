using System;


namespace Massiv
{
    internal class Program
    {
        static void Main()
        {
            for (int i = 0; i < 10; i++)//строка
            {
                // Выводим одну строку из 10 звездочек.
                for (int j = 0; j < 10; j++)//столбец
                {
                    Console.Write("*\t");

                }

                // Переход на новую строку.
                Console.WriteLine();// Console.Write("\n");
            }

            // Delay.
            Console.ReadKey();

        }
    }
}
