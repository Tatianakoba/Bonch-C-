using System;


namespace AVG
    /*Используя Visual Studio, создайте проект по шаблону Console Application.
Вычислите среднее арифметическое трех целочисленных значений и выведите его на экран.С какой проблемой вы столкнулись? Какой тип переменных лучше использовать для корректного отображения результата?*/

{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите 3 целых числа");
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                int c = int.Parse(Console.ReadLine());
            double result = (a + b + c) / 3.0;
            Console.WriteLine("Среднее арифметическое чисел {0},{1},{2} равно {3}", a,b,c, Math.Round(result,2));
           
            Console.ReadKey();
        }
    }
}
