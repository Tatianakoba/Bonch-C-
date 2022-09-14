using System;
/*Имеется 3 переменные типа int x = 10, y = 12, и z = 3;
Выполните и рассчитайте результат следующих операций для этих переменных:
• x += y - x++ * z;
• z = --x – y * 5; ·
• y /= x + 5 % z;
• z = x++ + y * 5;
• x = y - x++ * z;
Сформулируйте вывод о порядке действий*/

namespace Homework_11._06
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите 3 целых числа x = 10, y = 12, z = 3");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());
            Console.WriteLine(x += y - x++ * z);
            Console.WriteLine("Результатом выражения x += y - x++ * z будет: ");
            Console.WriteLine(x += y - x++ * z);
            Console.WriteLine("Результатом выражения z = --x - y * 5 будет: ");
            Console.WriteLine(z = --x - y * 5);
            Console.WriteLine("Результатом выражения y /= x + 5 % z будет: ");
            Console.WriteLine(y /= x + 5 % z);
            Console.WriteLine(z = x++ + y * 5);
            Console.WriteLine("Результатом выражения z = x++ + y * 5 будет: ");
            Console.WriteLine(z = x++ + y * 5);
            Console.WriteLine(x = y - x++ * z);
            Console.WriteLine("Результатом выражения x = y - x++ * z будет: ");
            Console.WriteLine(x = y - x++ * z);
            Console.ReadKey();
        }
    }
}
