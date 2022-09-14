using System;


namespace DZ_Remove
{
    internal class Program
    {
        static void Main()
        {
            string text = "Хороший день"; // индекс последнего символа 
            int ind = text.Length - 1;
            // вырезаем последний символ 
            text = text.Remove(ind);
            Console.WriteLine(text);
            text = text.Remove(0, 2);
            Console.WriteLine(text);
            Console.ReadKey();
        }
    }
}
