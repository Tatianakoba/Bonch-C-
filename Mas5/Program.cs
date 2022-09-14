using System;


namespace Mas5
{
    internal class Program
    {
        static void Main()
        {
            int[,] array = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    array[i, j] = 2 * i - 3 * j;
                   
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
