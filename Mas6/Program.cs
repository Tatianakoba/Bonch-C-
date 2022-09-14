using System;


namespace Mas6
{
    internal class Program
    {
        static void Main()
        {
            int[,] array = new int[3, 3];
            Random rnd = new Random();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    array[i, j] = rnd.Next(-10,10);

                }
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("{0} \t", array[i, j]);

                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
