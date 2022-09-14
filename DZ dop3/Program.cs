using System;
//3.Задана квадратная матрица целых чисел. Выведите на печать координаты
//нулевых элементов (номер строки и номер столбца).

namespace DZ_dop3
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите размерность массива");
            int N = int.Parse(Console.ReadLine());
            int[,] array = new int[N, N];
            Random rnd = new Random();
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    array[i, j] = rnd.Next(-10, 10);

                }
            }

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write("{0} \t", array[i, j]);

                }
                Console.WriteLine();
            }
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (array[i, j] == 0)
                    {
                        Console.WriteLine($"Координаты нулевого элемента {i},{j}");
                    }
                    else
                    {
                        Console.WriteLine($"Нулевой элемент не найден");
                    }

                }
                Console.WriteLine();
            }

            Console.ReadKey();

        }
    }
}
