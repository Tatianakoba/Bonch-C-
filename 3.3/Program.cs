using System;
/*Упражнение 3
Получить таблицу температур по Цельсию tc от -50 до +50 градусов, а также их
эквивалентов по шкале Фаренгейта tf, используя соотношение
Для вывода используйте форматированный вывод*/

namespace _3._3
{
    internal class Program
    {
        static void Main()
        {
            double tf = 0;
            for (int tc= -50; tc < 50; tc++)//строка
            {
                tf = tc*1.8 + 32;

                Console.WriteLine($" цельсий {tc}\t фаренгейт {tf}\t");
                              
                
            }

            // Delay.
            Console.ReadKey();
        }
    }
}
