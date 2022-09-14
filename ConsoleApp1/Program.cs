using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя");
            string vvod = Console.ReadLine();
            Console.WriteLine("Как дела? {0}", vvod);
            string vvod2 = Console.ReadLine();
            
                       
           Console.WriteLine("У {0} дела {1}", vvod, vvod2);

            Console.ReadKey();// Задержка экрана для просмотра
        }
    }
}
