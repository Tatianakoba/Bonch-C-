using System;


namespace Strings_18._06._2022
{
    internal class Program
    {
        static void Main()
        {
            //Задаем строку
            string s1 = "Привет, мир!!!";
            Console.WriteLine(s1);

            string s2 = "";
            Console.WriteLine(s2);
            String s3 = null;
            Console.WriteLine(s3);

            //Обращаемся как к массиву
            Console.WriteLine(s1[0]);

            //Размер строки

            Console.WriteLine(s1.Length);

            //Проверка на null
            Console.WriteLine(string.IsNullOrEmpty(s3));
            Console.WriteLine(string.IsNullOrEmpty(s2));

            // Проверка на пробелы
            Console.WriteLine(string.IsNullOrWhiteSpace(s3));



            Console.ReadKey();
        }
    }
}
