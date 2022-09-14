using System;
//Задание 9.Найти сумму элементов массива из n вещественных чисел.
//Количество элементов ввести с клавиатуры, массив заполнить случайными
//числами.

namespace HomeWork_17._06._2022
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите размерность массива");
            int n = int.Parse(Console.ReadLine());
            double [] array = new double[n];
            Random r = new Random();
            double sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = r.NextDouble();
                sum += array[i];
                Console.WriteLine(Math.Round(array[i],2));

            }
            Console.WriteLine($"Сумма элементов массива = {Math.Round(sum,2)} ");
            Console.ReadKey();
        }
    }
}
