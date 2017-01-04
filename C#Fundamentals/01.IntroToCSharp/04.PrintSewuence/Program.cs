using System;


namespace PrintSequence
{
    class Program
    {
        static void Main()
        {
            for (short i = 2; i < 12; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    Console.WriteLine(-i);
                }

            }
        }
    }
}
