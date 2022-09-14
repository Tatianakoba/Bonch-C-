using System;
//2.В заданной с клавиатуры строке текста определите количество слов. Каждое слово отделено друг от  друга пробелом


namespace DZ_string___Task_2_
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите строку");
            string text = Console.ReadLine();
            int i = 0;
            string[] array = text.Split(new char[] { ' ' });
            foreach (string vivod in array)
            {
                i++;
                Console.WriteLine(vivod);
            }
            Console.WriteLine($"Количество слов в тексте {i}");
            Console.ReadKey();
        }
        
    }
}
