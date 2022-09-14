using System;


namespace While
{
    internal class Program
    {
        static void Main()
        {
            int a = 0;
            while (a<3)
            {
                a++;
                Console.WriteLine("a = {0}", a);
                //break;
               //continue;
                Console.WriteLine("Эта строка не выполнится");
            }
            Console.WriteLine("Произведено {0} итераций", a);
            Console.ReadKey();

        }
    }
}
