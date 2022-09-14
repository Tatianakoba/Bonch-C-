using System;
//4.Задан массив действительных чисел из N элементов (используйте
//генератор случайных чисел). Определить количество элементов, значения
//которых находятся вне диапазона от -10 до +10.

namespace DZ_dop4
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите размерность массива");
            int N = int.Parse(Console.ReadLine());
            int[] array = new int[N];
            Random r = new Random();
            int kol = 0;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = r.Next(-100, 100);

                Console.WriteLine(array[i]);

            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < -10)
               {
                kol++;
               }     
                if (array[i] >10)
                {
                    kol++;
                }

            }
            Console.WriteLine($"Количество элементов вне диапазона от -10 до 10 = {kol}");
            Console.ReadKey();
        }
    }
}
