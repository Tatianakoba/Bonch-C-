using System;
//1.Пример инициализации и вывод на экран массива daysOfWeek, определяющего дни  недели. 

namespace DZ_string1
{
    internal class Program
    {
        static void Main()
        {
            // Инициализация массива строк 
            string[] daysOfWeek = { "Sunday", "Monday", "Tuersday",
 "Wednesday", "Thirsday", "Friday", "Saturday" };
            // Вывод массива строк AS в цикле 
            for (int i = 0; i < daysOfWeek.Length; i++)
                Console.WriteLine("AS[{0}] = {1}", i, daysOfWeek[i]);
            Console.ReadKey();

        }
    }
}
