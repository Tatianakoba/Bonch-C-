using System;

//Задание 1
//Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
//Напишите программу русско-английский переводчик. Программа знает 10 слов о погоде.
//Требуется, чтобы пользователь вводил слово на русском языке, а программа давала ему
//перевод этого слова на английском языке. Если пользователь ввел слово, для которого
//отсутствует перевод, то следует вывести сообщение, что такого слова нет.
namespace Дз__Task_1_
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите руссокое слово: ");
            string num = Console.ReadLine();
            
          
            switch (num)
            {
                case "один":
                    Console.WriteLine("One");
                    break;
                case "два":
                    Console.WriteLine("Two");
                    break;
                case "три":
                    Console.WriteLine("Three");
                    break;
                case "четыре":
                    Console.WriteLine("Four");
                    break;
                case "пять":
                    Console.WriteLine("Five");
                    break;
                case "шесть":
                    Console.WriteLine("Six");
                    break;
                case "семь":
                    Console.WriteLine("Seven");
                    break;
                case "восемь":
                    Console.WriteLine("Eight");
                    break;
                case "девять":
                    Console.WriteLine("Nine");
                    break;
                case "десять":
                    Console.WriteLine("Ten");
                    break;
                default:
                    Console.WriteLine("Неизвестное слово");
                    break;
            }
            // Delay.
            Console.ReadKey();
        }
    }
}
