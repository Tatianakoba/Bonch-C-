using System;
/*Задание 5
Используя VisualStudio, создайте проект по шаблону ConsoleApplication.
Создайте три строковые переменные и присвойте им значения:
"\nмоя строка 1"
"\tмоя строка 2"
"\aмоя строка 3"
Выведите значение каждой переменной на экран.*/

namespace String__5_
{
    internal class Program
    {
        static void Main()
        {
            string n;
            string t;
            string a;
            
            n = "\nмоя строка 1";
            t = "\tмоя строка 2";
            a = "\aмоя строка 3";

            Console.WriteLine(n);
            Console.WriteLine(t);  
            Console.WriteLine(a);
            Console.ReadKey();

        }
    }
}
