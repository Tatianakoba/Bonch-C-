using System;

namespace Mas2
{
    internal class Program
    {
        static void Main()
        {
            int[] array = new int[5];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = 2*i-3;

            }
            Console.WriteLine(array[0]);
            Console.WriteLine(array[1]);
            Console.WriteLine(array[2]);
            Console.WriteLine(array[3]);
            Console.WriteLine(array[4]);

            // Delay.
            Console.ReadKey();
        }
    }
}
