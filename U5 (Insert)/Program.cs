using System;


namespace U5__Insert_
{
    internal class Program
    {
        static void Main()
        {
            string text = "Хороший день";
            string name = "Заммечательный ";
            string newtext = text.Insert(0, "очень ");//индекс и текст вставки
            Console.WriteLine(text);
            Console.WriteLine(name);
            Console.WriteLine(newtext);
            text = text.Insert(8, name);
            Console.WriteLine(text);
            Console.ReadKey();
        }
    }
}
