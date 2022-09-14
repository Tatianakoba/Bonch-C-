using System;


namespace lesson2
{
    internal class Program
    {
        static void Main()
        {
            //Задание пернеменной в коде (не соответсвует стандартом кодирования, только для констант)
            byte perem = 1;
            byte per = 5;
            //Задание переменной выражением
            int s = 2*perem - per;
            Console.WriteLine(s);

            //Задание переменной с клавиатуры
            int aS = int.Parse(Console.ReadLine());
            int bS = int.Parse(Console.ReadLine());

            Console.WriteLine(aS/bS);
            Console.WriteLine(aS%bS);

            double aSS = double.Parse(Console.ReadLine());
            double bSS = double.Parse(Console.ReadLine());
            Console.WriteLine(Math.Round((aSS / bSS),3));
            Console.WriteLine(aSS % bSS);
            //Возведение в степень Math.Pow(x,y)

            double x = 2, y = 8;
            double result = Math.Pow(x,y);
            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
