using System;
//Задание 11.Задана квадратная матрица целых чисел. Подсчитайте количество
//отрицательных и положительных элементов, количество нулевых элементов,
//сумму элементов по главной диагонали. Массив заполнять случайным образом.
namespace DZ3
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите размерность массива");
            int N = int.Parse(Console.ReadLine());
            int[,] array = new int[N,N];
            Random r = new Random();
            


            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    array[i, j] = r.Next(-10, 10);

                }
            }
            int sumOtr = 0;
            int sumPol = 0;
            int sumNull = 0;
            int sumDiag = 0;

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {

                    Console.Write("{0} \t", array[i, j]);
                    if (array[i, j] < 0)
                    {
                        sumOtr++;
                    }
                    if (array[i, j] > 0)
                    { 
                        sumPol++;

                    }
                    if (array[i,j]==0)
                    {
                        sumNull++;
                    }
                    if (i == j)
                    {
                        sumDiag += array[i, j];
                    }

                }
                Console.WriteLine("\n");
            }
           
            Console.WriteLine($"Количество отрицательных элементов в массиве= {sumOtr} ");
            Console.WriteLine($"Количество положительных элементов в массиве= {sumPol} ");
            Console.WriteLine($"Количество нулевых элементов в массиве= {sumNull} ");
            Console.WriteLine($"Сумма элементов по диагонали= {sumDiag} ");
            Console.ReadKey();
        }
    }
}
