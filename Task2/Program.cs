using System;

/*Начав тренировки, лыжник в первый день пробежал 10 км.
 * Каждый следующий день он увеличивал пробeг на 10% от пробега предыдущего дня.
 * Определить в какой день суммарный пробег за все дни превысит 100 км
*/
namespace Task2
{
    internal class Program
    {
        static void Main()
        {
            double s = 10; //изменение по дням
            int day = 1;
            double AllS = 10; // сумма расстояния за все дни

            while (AllS < 100)
            {
                s +=s * 0.1;
                AllS = AllS + s;
                day++;
                Console.WriteLine($"За {day} день пробег составит {s}. Общее расстояние {AllS} ");
            }    

            Console.WriteLine(day);
            Console.ReadKey();

        }
    }
}
