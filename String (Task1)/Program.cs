using System;
// Введите строку с клавиатуры, замените "пир" на "мир"


namespace String__Task1_
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите строку");
            string text = Console.ReadLine();

            string s1 = "пир";
            string s2 = "мир";

            string newtext = text.Replace(s1, s2);
            //string newtext = text.Replace("пир","мир");
            Console.WriteLine(newtext);


            Console.ReadKey();
        }
    }
}
