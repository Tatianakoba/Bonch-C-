using System;
//7.	Ввести с клавиатуры строку. Посчитать, сколько раз встречается буква «а» в строке.

namespace Attest__7_
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите строку");
            string text = Console.ReadLine();
            int j = 0;
            
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == 'a')

                {
                    j++;
                }
                
            }
            Console.WriteLine($"Количество символов a в тексте {j}");
            Console.ReadKey();
        }
    }
}
