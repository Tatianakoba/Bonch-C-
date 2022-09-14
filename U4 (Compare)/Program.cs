using System;

namespace U4__Compare_
{
    internal class Program
    {
        static void Main()
        {
            string s1 = "пир";
            string s2 = "мир";
            int result = String.Compare(s1, s2);
            Console.WriteLine(result);

            if (result > 0)
            {
                Console.WriteLine("Строка 1 лежит после строки 2");
            }
            else
            if (result < 0)
            {
                Console.WriteLine("Строка 1 лежит перед строкой 2");
            }
            else 
            {
                Console.WriteLine("Строки равны");
            }
            Console.ReadKey();
        }
    }
}
