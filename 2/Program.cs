using System;


namespace Lesson3
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите целые значения a и b");
            int a = int.Parse(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            if (a < b)
            {
                Console.WriteLine("a<b");
            }
            else
            {
                Console.WriteLine("a не меньше b");
            }
            Console.ReadKey();

            //или : int b = Convert.ToInt32(Console.ReadLine());
            //if (a < b)
            
            //    Console.WriteLine("a<b");
            
            //else
            
            //    Console.WriteLine("a не меньше b");
            
        }
    }
}
