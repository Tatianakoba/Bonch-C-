using System;

namespace Casting
{
    internal class Program
    {
        static void Main()
        {

            //byte, short: в int
            byte a = 4, b = 7;
            int sum = a + b;
            Console.WriteLine(sum);

            //int: int, float, double
            int c = 3455, g = 6526;
            double result = c * g;
            Console.WriteLine(result);

            Console.ReadKey();
        }
            

        }
    }
}
