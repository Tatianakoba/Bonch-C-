using System;


namespace U8__Split_
{
    internal class Program
    {
        static void Main()
        {
            string text = "Хороший день сегодня был бы, да дождь пошел";
            string[] array = text.Split(new char[] {' '});
            foreach (string vivod in array)
            {
                Console.WriteLine(vivod);
            }

            string[] array2 = text.Split(new char[] { ',' });
            foreach (string vivod2 in array2)
            {
                Console.WriteLine(vivod2);
            }

            Console.ReadKey();

        }
    }
}
