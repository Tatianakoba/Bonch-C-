using System;
//5.Составить программу возведения натурального числа в квадрат, учитывая следующую закономерность: Ввод n c клавиатуры 
//12 = 1
//22  = 1 + 3
//32  = 1 + 3  + 5
//42  = 1 + 3 + 5  + 7
//…
//n2  = 1 + 3 + 5 + 7 + 9 + … + (2n — 1) . 


namespace Attest__5_
{
    internal class Program
    {
        static void Main()
        {

            Console.WriteLine("Введите  n");
            int n = int.Parse(Console.ReadLine());
            int m = 0;
            for (int i = 1; i <= n; i+=2)
            {
                m += i;
                Console.WriteLine(i);
                               
            }
            m = m+ (2 * n - 1);
            Console.WriteLine($"Число {n} в квадрате равно {m}");
            Console.ReadKey();
        }
    }
}
