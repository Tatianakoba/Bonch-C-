using System;
//2.В заданном массиве действительных чисел найдите разность между
//максимальным и минимальным числом.

namespace DZ_dop2
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите размерность массива");
            int N = int.Parse(Console.ReadLine());
            int[] array = new int[N];
            Random r = new Random();
            int razn = 0;
            int maxim = 0;
            int minim = 0;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = r.Next(-10, 10);

                
                Console.WriteLine(array[i]);

            }
            maxim = array[0];
            minim = array[0];
            for (int i = 0; i<array.Length; i++)
            {
                if (array[i] < minim)
                    
                {
                    minim = array[i];

                }
                if (array[i] > maxim)
                {
                    maxim = array[i];
                }

           }

            Console.WriteLine();
            Console.WriteLine(maxim);
            Console.WriteLine(minim);

            razn = maxim - minim;

            Console.WriteLine($"разность между максимальным и минимальным числом = {razn} ");
            Console.ReadKey();
        }
    }
}
