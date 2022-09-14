using System;
//1.  В строке, введенной с клавиатуры, удалите символ с позицией 10. 

namespace HomeWork_18._06._2022
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите строку");
            string text = Console.ReadLine();
            text = text.Remove(10,1);
            Console.WriteLine(text);


            Console.ReadKey();
        }
    }
}
