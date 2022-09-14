using System;
//Задание 10.Найти среднее арифметическое n элементов одномерного массива с
//размерностью N. Количество элементов ввести с клавиатуры, массив заполнить
//случайными числами.

namespace DZ2
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите размерность массива");
            int N = int.Parse(Console.ReadLine());
            double[] array = new double[N];
            Random r = new Random();
            double sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = r.NextDouble();
                sum += array[i];

                Console.WriteLine(Math.Round(array[i], 2));

            }
            Console.WriteLine($"Среднее арифметическое массива из {N} чисел = {Math.Round(sum/N, 2)} ");
            Console.ReadKey();
        }
    }
}
