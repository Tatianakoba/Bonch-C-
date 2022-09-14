using System;


namespace U9__Trim_
{
    internal class Program
    {
        static void Main()
        {
           string text = " Хороший день сегодня был бы, да дождь пошел "; 
           text = text.Trim();
            
            Console.WriteLine(text);
            string text2 = "Хороший день сегодня был бы, да дождь пошел";
            text2 = text.Trim('Х',' ','л');
            Console.WriteLine(text2);
            Console.ReadKey();
        }
    }
}
