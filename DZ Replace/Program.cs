using System;
//Замена

namespace DZ_Replace
{
    internal class Program
    {
        static void Main()
        {
            string text = "хороший день";
            text = text.Replace("хороший", "плохой");
            Console.WriteLine(text);
            text = text.Replace("о", "");
            Console.WriteLine(text);
            Console.ReadKey();
        }
    }
}
