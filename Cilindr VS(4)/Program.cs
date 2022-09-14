using System;
/*Используя Visual Studio, создайте проект по шаблону Console Application.
Напишите программу расчета объема - V и площади поверхности -S цилиндра.
Объем V цилиндра радиусом – R и высотой – h, вычисляется по формуле: V = πR2h
Площадь S поверхности цилиндра вычисляется по формуле: S = 2πR2 + 2πRh Результаты расчетов выведите на экран.*/

namespace Cilindr_VS_4_
{
    internal class Program
    {
        static void Main()
        {
            const double pi = 3.14;

            Console.WriteLine("Введите радиус цилиндра");
            double R = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите высоту цилиндра");
            double h = double.Parse(Console.ReadLine());

            double V = pi * R * R * h;
            double S = 2 * pi * R * R + 2* pi * R * h;


            Console.WriteLine("Объем цилиндра радиусом {0} и высотой {1} равен {2}", R, h, V);
            Console.WriteLine("Площадь цилиндра радиусом {0} и высотой {1} равна {2}", R, h, S);

            Console.ReadKey();

        }
    }
}
