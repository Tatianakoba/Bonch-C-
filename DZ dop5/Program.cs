using System;
//5.Найдите сумму и произведение элементов квадратной матрицы
//размерности 10х10

namespace DZ_dop5
{
    internal class Program
    {
        static void Main()
        {
            int[,] array = new int[10, 10];
            Random r = new Random();

            int sumel = 0;
            int proizv = 0;


            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    array[i, j] = r.Next(-3, 3);

                }
            }

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write("{0} \t", array[i, j]);

                }
                Console.WriteLine();

            }
            for (int i = 0; i < 10; i++)
            {
                
                for (int j = 0; j < 10; j++)
                {
                    sumel += array[i, j];

                }
                
            }
            Console.WriteLine($"Сумма элементов матрицы = {sumel} ");
            for (int j = 0; j < 10; j++)
            {
               
                for (int i = 0; i < 10; i++)
                {
                    proizv *= array[i, j];

                }
               
            }
            Console.WriteLine($"Произведение элементов матрицы  = {proizv} ");
            Console.ReadKey();
        }
    }
}
