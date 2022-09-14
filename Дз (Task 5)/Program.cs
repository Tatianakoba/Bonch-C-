using System;
//Задание 5
//Даны два числа. Вывести вначале большее, а затем меньшее из них

namespace Дз__Task_5_
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите два целых числа a и b");
            int a = int.Parse(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            int max = Math.Max(a, b);
            int min = Math.Min(a, b);

            
            
            Console.WriteLine("Максимальное число = {0}", max);
            Console.WriteLine("Минимальное число = {0}", min);




            Console.ReadKey();
        }
    }
}
