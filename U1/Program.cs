using System;


namespace U1
{
    internal class Program
    {
        static void Main()
        {
            string s1 = "Привет";
            string s2 = "мир";
            string s3 = "!";
            string s4 = s1 + " " + s2 + s3;
            Console.WriteLine(s4);
            string s5 = String.Concat(s1," ", s2, s3);
            Console.WriteLine(s5);
            Console.ReadKey();
        }
    }
}
