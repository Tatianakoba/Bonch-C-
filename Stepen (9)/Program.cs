using System;
/*Задание 9
Используя VisualStudio, создайте проект по шаблону ConsoleApplication.
Вычислите число x6 при помощи трех операций умножения, если дано число x, которое пользователь вводит с клавиатуры.*/

namespace Stepen__9_ 
{
    internal class Program
    {
        static void Main()

        {
            Console.WriteLine("Введите x");
            double x = double.Parse(Console.ReadLine());
            double y = Math.Pow(x, 2);
            double z = y * y * y;
            Console.WriteLine("Значение {0} в степени 6 равно {1}", x, z);
            //double y = x*x;
           //double z = y * y * y;


           //x*=x;
           //double y = x*x*x;

            double d = Math.Pow(x, 6);
            Console.WriteLine(d);
            Console.ReadKey();
        }
    }
}
