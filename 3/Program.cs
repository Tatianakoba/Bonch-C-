using System;


namespace Lesson3
{
    internal class Program
    {
        static void Main()
        {
            string login = "Admin";
            string password = "P@ssw0rd";

            Console.Write("Введите login: ");

            string usersLogin = Console.ReadLine();

            if (login == usersLogin)
            {
                Console.Write("Введите пароль: ");

                string usersPassword = Console.ReadLine();

                if (password == usersLogin)
                {
                    Console.Write("Здравствуйте {0}, Вы вошли в систему", usersLogin);

                }

                else
                {
                    Console.WriteLine("Вы ввели неверный пароль");

                }
            }
            else
            {
                Console.WriteLine("Нет пользователя с таким именем");

            }
                

            Console.ReadKey();
        }
    }
}
