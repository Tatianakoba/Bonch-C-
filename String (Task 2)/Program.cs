using System;
/*Дана строка:  Login1,LOgin2,login3,LoGin4.  Разбить строку на массив, перевести 
 * в нижний регистр
 */


namespace String__Task_2_
{
    internal class Program
    {
        static void Main()
        {
            string text = "Login1,LOgin2,login3,LoGin4";
            //перевод регистра
            text = text.ToLower();
            Console.WriteLine(text);
            //text = text.ToUpper();
            //Console.WriteLine(text);

            //разбиваем массив по запятой
            string[] textArray = text.Split(',');
            foreach (string VrPer in textArray)
            {
                Console.WriteLine(VrPer);
            }
            Console.ReadKey();

        }
    }
}
