using System;
//4.Рассчитать значение у при заданном значении х:
//y = sin(x) при x>0 или y=cos(x) в противном случае.


namespace Attest__4_
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите  x");
            double x = double.Parse(Console.ReadLine());

            if (x > 0)
            {
                double y = Math.Sin(x);
                Console.WriteLine($"При x = {x} y = {Math.Round(y,2)}");
            }
            else
            {
                double y = Math.Cos(x);
                Console.WriteLine($"При x = {x} y = {Math.Round(y, 2)}");
            }
            Console.ReadKey();

        }
    }
}
