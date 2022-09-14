using System;
//Задание 12.Задан массив действительных чисел из N элементов. Определить
//количество элементов, значения которых находятся в диапазоне от -500 до
//+500. Решите задачу двумя способами: заполнение массива случайными
//числами или заполнение с клавиатуры.
namespace DZ4
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
                array[i] = r.Next(-10,10);
                if ((array[i] < 500) && (array[i] > -500))
                {
                    kol++;
                }

                Console.WriteLine(array[i]);

            }
            Console.WriteLine($"Количество элементов значения которых находятся в диапазоне от -500 до +500 массива = {kol} ");
            Console.ReadKey();
        }
    }
}
