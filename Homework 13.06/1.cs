using System;


namespace Homework_13._06
{
    internal class Program
    {
        static void Main()
        {

            Console.WriteLine("Введите два целых числа a и b");
            int a = int.Parse(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            if (a > b)
            {
                if (a == b)
                {
                    Console.WriteLine("Максимальное число = {0}", a);
                }
               

            }
            else 
            {
                Console.WriteLine("Максимальное число = {0}", b);

            }
           
           
            Console.ReadKey();
        }
    }
}
