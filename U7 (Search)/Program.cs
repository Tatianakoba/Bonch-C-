using System;


namespace U7__Search_
{
    internal class Program
    {
        static void Main()
        {
            string text = "Хороший день";
            string name = "Заммечательный ";

            int index = text.IndexOf("д");
            int index1 = name.IndexOf("д");
            Console.WriteLine(text);
            Console.WriteLine(name);
            Console.WriteLine(index);
            Console.WriteLine(index1);
            Console.ReadKey();
        }
    }
}
