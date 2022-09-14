using System;
//1.Задан массив действительных чисел размерности 10х10. Найти суммы
//элементов каждой строки, произведения элементов каждого столбца, и
//максимальный элемент главной диагонали (подсказка: все элементы, для
//которых номер строки совпадает с номером столбца)

namespace DZ_dop_1
{
    internal class Program
    {
        static void Main()
        {
            int[,] array = new int[10, 10];
            Random r = new Random();
                    
            int maxel = 0;  


            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    array[i, j] = r.Next(0,10);

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
                int sumstr = 0;
                for (int j = 0; j < 10; j++)
                {
                    sumstr += array[i, j];

                }
                Console.WriteLine($"Сумма элементов {i} строки = {sumstr} ");
            }
            for (int j = 0; j < 10; j++)
            {
                int proizstolb = 0;
                for (int i = 0; i < 10; i++) 
                {
                    proizstolb *= array[i, j];

                }
                Console.WriteLine($"Произведение элементов {j} столбца = {proizstolb} ");
            }
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (i==j)
                    {
                        if (array[i,j]>maxel)
                        maxel = array[i, j];

                    }


                }
                
                Console.WriteLine();

            }
            Console.WriteLine($"максимальный элемент главной диагонали = {maxel} ");

            Console.ReadKey();
        }
    }
}
