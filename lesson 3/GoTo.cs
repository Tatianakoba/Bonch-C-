using System;


namespace lesson_3
{
    internal class GoTo
    {
        static void Main()
        {
            int counter = 0;

        Label:
            counter++;

            Console.WriteLine("Counter = {0}", counter);

            if (counter < 3)
            {

                GoTo Label;
            }
            Console.WriteLine("End");
            Console.ReadKey();

        }
    }
}
