using System;


namespace PR2__3_
    /*Используя Visual Studio, создайте проект по шаблону Console Application.
Создайте константу с именем -pi(число π «пи»), создайте переменную радиус с именем – r.Используя формулу πR2, вычислите площадь круга и выведите результат на экран.*/
{
    internal class Program
    {
        static void Main()
        {

            const double pi = 3.14;
            Console.WriteLine("Введите радиус");
            int R = int.Parse(Console.ReadLine());
            double S = pi * R * R;
            Console.WriteLine("Площадь круга радиусом {0} равна {1}", R, Math.Round(S, 3));
            Console.ReadKey();

        }
    }
}
