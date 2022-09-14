using System;
//Задание 4
//Дано значение температуры T в градусах Цельсия. Определить значение этой же
//температуры в градусах Фаренгейта. Температура по Цельсию T C и температура по
//Фаренгейту T F связаны следующим соотношением:
//T C = (T F − 32)·5 / 9.

namespace Дз__Task_4_
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите температуру в градусах цельсия");

            double TC = double.Parse(Console.ReadLine());
            double TF = 0;
            TF = (TC / (5.0 / 9.0)) + 32.0;
            

                Console.WriteLine("Температура в градусах цельсия {0} соответствует {1} по Фаренгейту", TC,TF );
            


            Console.ReadKey();
        }
    }
}
