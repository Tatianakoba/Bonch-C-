using System;


namespace lesson_2_part2
{
    internal class Program
    {
        static void Main()
        {
            byte a = 2;
            int result1 = a * a * a * a * a;
            Console.WriteLine(result1);

            int c = 3, b = 10;
            double result = Math.Pow(c, b); 
            Console.WriteLine(result);


            Console.ReadKey();
        }
    }
}
