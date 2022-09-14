//Задание 3
//Напишите консольную программу, в которую пользователь вводит с клавиатуры число.
//Если число одновременно больше 5 и меньше 10, то программа выводит "Число больше 5
//и меньше 10". Иначе программа выводит сообщение "Неизвестное число".
using System;
namespace Дз__Task_3_
{
    internal class Program
    {
        static void Main()
        {

            Console.WriteLine("Введите целое число a");

            int a = int.Parse(Console.ReadLine());

            if ((5<a)&&(a<10))
            {

                Console.WriteLine("Число {0} больше 5 и меньше 10", a);
            }



            else
            {
                Console.WriteLine("Неизвестное число");

            }


            Console.ReadKey();
        }
    }
}
