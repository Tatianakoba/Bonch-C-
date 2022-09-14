using System;


namespace U3
{
    internal class Program
    {
        static void Main()
        {
            string s1 = "Доброго";
            string s2 = "утра";
            string s3 = "хорошего";
            string s4 = "настроения";
            string s5 = "и веселья";
            string s6 = " ";

            // задаем массив, каждый элемент которого- строка
            string[] array = new string[] { s1, s2, s3, s4, s5 };
            string S = String.Join(s6, array);
            Console.WriteLine(S);
            Console.ReadKey();

        }
    }
}
