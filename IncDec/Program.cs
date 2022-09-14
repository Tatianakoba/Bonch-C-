using System;


namespace IncDec
{
    internal class Program
    {
        static void Main()
        {

            int a = 3, b = 6, c = 10;

            //Инкремент x = x+1 (x++)

            Console.WriteLine("Постфиксный инкремент");
            byte number1 = 0;
            Console.WriteLine(number1++); //сначала выводится на экран
            Console.WriteLine(number1);

            Console.WriteLine("Префиксный инкремент");
            byte number2 = 0;
            Console.WriteLine(++number2); //сразу вывод на экран


            //Декремент x = x-1 (x--)


            Console.WriteLine("Постфиксный декремент");
            byte number3 = 0;
            Console.WriteLine(number3--); //сначала выводится на экран
            Console.WriteLine(number3);

            Console.WriteLine("Префиксный инкремент");
            byte number4 = 0;
            Console.WriteLine(--number4); //сразу вывод на экран

            int result = a++ + 3 * b - c;
            Console.WriteLine(result);
            Console.WriteLine(a);

            int result2 = ++a + 3 * b - c;
            Console.WriteLine(result2);
            Console.ReadKey();
        }
    }
}
