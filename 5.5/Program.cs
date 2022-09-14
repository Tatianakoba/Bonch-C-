using System;
/*Упражнение 5
Гражданин 1 марта открыл счет в банке, вложив 1000 руб. Через каждый месяц размер
вклада увеличивается на 2% от имеющейся суммы. Определить:
а) за какой месяц величина ежемесячного увеличения вклада превысит 30 руб.;
б) через сколько месяцев размер вклада превысит 1200 руб.*/

namespace _5._5
{
    internal class Program
    {
        static void Main()
        {
            int month = 0;
            int monthsum = 0;
            bool y = true; 
            double vkl = 1000; //вклад 1000р
            double proc = 0; //ежемесячное увеличение
            double sum = 1000; //общая сумма вклада

            while (proc < 30)
            {
                month++;
                proc = vkl * 0.02;
                vkl += proc;
                if ((vkl > 1200)&&(y == true))
                {
                    sum = vkl;
                    monthsum = month;
                    y = false;

                }
            }
            Console.WriteLine($"За {month} месяц сумма ежемесячного увеличения вклада превысит 30 руб и составит {Math.Round(proc, 2)} руб");

           
            Console.WriteLine($"Через {monthsum} месяцев размер вклада превысит 1200 руб и составит {Math.Round(sum, 2)} руб");

            
            // Delay.
            Console.ReadKey();
        }
    }
}
