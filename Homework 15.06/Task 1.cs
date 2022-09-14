using System;
/*Разработать программу - аналог умножения без операции умножения
 * Входные данные  - два числа
 * Выходные данные  - произведение этих чисел
*/

namespace Homework_15._06
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите множители");
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int result = 0;
            for (int i = 0; i < n; i++)
            {
                result += m;

            }
            Console.WriteLine("Результатом умножения числа {0} на число {1} является {2}",m,n,result);
           Console.ReadKey();

        }
    }
}
