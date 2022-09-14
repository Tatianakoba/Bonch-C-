using System;


namespace DoWhile
{
    internal class Program
    {
        static void Main()
        {
            int counter = 5;

            do
            {
                counter++;
                Console.WriteLine("Counter {0}", counter);
            }
            while (counter < 3);

            Console.WriteLine("Произведено {0} итераций.", counter);

            // Delay.
            Console.ReadKey();

        }
    }
}
