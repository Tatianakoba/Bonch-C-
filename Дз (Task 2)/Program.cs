using System;
//Задание 2
//Напишите консольную программу, в которую пользователь вводит с клавиатуры два числа.
//А программа сравнивает два введенных числа и выводит на консоль результат сравнения
//(два числа равны, первое число больше второго или первое число меньше второго).

namespace Дз__Task_2_
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

                Console.WriteLine("Число {0} больше числa {1}", a, b);
            }
            if (a == b)
            {
                    Console.WriteLine("Число {0} = числу {1}", a, b);
            }
            
            else
            {
                Console.WriteLine("Число {0} меньше числa {1}", a, b);

            }
            

            Console.ReadKey();
        }
    }
}
