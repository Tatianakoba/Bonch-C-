using System;

namespace Task_2
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите число a");
            int a = int.Parse(Console.ReadLine());
            
            if (a%2 == 0)
            {
              
                    Console.WriteLine("Число {0} четное", a);
             }


            
            else
            {
                Console.WriteLine("Число {0} нечетное", a);

            }


            Console.ReadKey();
        }
    }
}
