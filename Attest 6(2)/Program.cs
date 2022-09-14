using System;
//6.	Составить программу, которая из некоторой строки  уберет все пропуски.

namespace Attest_6_2_
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите строку");
            string text = Console.ReadLine();

            for (int i = 0; i < text.Length; i++)
            {

                if (text[i] == ' ') 
                {
                    text = text.Remove(i, 1);
                }
            }

            Console.WriteLine(text);
            Console.ReadKey();
        }
    }
}
