using System;


namespace Task_3
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите двузнаяное число a");
            int a = int.Parse(Console.ReadLine());
            
            if (a % 10 == a/10)
            {

                Console.WriteLine("Цифры одинаковые");
            }



            else
            {
                Console.WriteLine("Цифры разные");

            }


            Console.ReadKey();
        }
    }
}
