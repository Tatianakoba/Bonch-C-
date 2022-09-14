using System;


namespace _5
{
    internal class Program
    {
        static void Main()
        {

            Console.WriteLine("Введите число 1 или 2");
            string number = Console.ReadLine();

            switch (number)
            {
               
                case "1":
                { 
                    Console.WriteLine("Один");
                    break;
                }
                
                case "2":
                {
                        Console.WriteLine("Два");
                        break;
                }
                
                default:
                { 
                        Console.WriteLine("Вы ввели отличное значение");
                        break;
                }
            }
            Console.ReadKey();
        }
    }
}
