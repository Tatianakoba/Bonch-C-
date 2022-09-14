using System;


namespace Mas3
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите размерность массива");
            int n = int.Parse(Console.ReadLine());
            int [] array = new int [n];
            Random r = new Random();
            
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = r.Next(-100,100);
                Console.WriteLine(array[i]);

            }
            Console.ReadKey();

        }
    }
}
