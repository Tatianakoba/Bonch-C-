using System;


namespace Test10
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите имя");
            string vvod = Console.ReadLine();
            string vvod2 = Console.ReadLine();

            Console.WriteLine("Мое имя {0}", vvod); //Вывод переменной  с меткой
            Console.WriteLine("Привет! {0}", vvod);
            Console.WriteLine("Как дела, {0}? {1}", vvod, vvod2);

            Console.ReadKey();// Задержка экрана для просмотра
        }
    }
}
