using System;
//Смена регистра

namespace DZ_Registr
{
    internal class Program
    {
        static void Main()
        {
            string hello = "Hello world!";
            Console.WriteLine(hello.ToLower()); // hello world! 
            Console.WriteLine(hello.ToUpper()); // HELLO WORLD! 
            Console.ReadKey();

        }
    }
}
