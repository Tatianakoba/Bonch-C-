using System;


namespace lesson_2_part3_sqrt
{
    internal class Program
    {
        static void Main()
        {
            //Вычисление квадратного корня sqrt

            int x = 256;
            double result = Math.Sqrt(x);
            Console.WriteLine(result);

            double y = 1.44;
            double result2 = Math.Sqrt(y);
            Console.WriteLine(result2);

            float d = 16.9F;
            double result3 = Math.Sqrt(d);
            Console.WriteLine(result3);

            Console.ReadKey();
        }
    }
}
