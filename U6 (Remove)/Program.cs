using System;


namespace U6__Remove_
{
    internal class Program
    {
        static void Main()
        {
            string text = "Хороший день";
            string name = "Заммечательный ";
            text = text.Remove(4);
            name = name.Remove(3,2);
           
            Console.WriteLine(text);
            Console.WriteLine(name);
            
            Console.ReadKey();
        }
    }
}
