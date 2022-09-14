using System;
//6.	Составить программу, которая из некоторой строки  уберет все пропуски.

namespace Attest__6_
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите строку");
            string text = Console.ReadLine();
            text = text.Replace("  ", string.Empty);
            text = text.Trim().Replace(" ", string.Empty);

            Console.WriteLine(text);
            Console.ReadKey();
        }
    }
}
