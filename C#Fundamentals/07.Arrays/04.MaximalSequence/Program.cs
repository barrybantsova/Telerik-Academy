using System;

namespace _04.MaximalSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            int sequence = 0;
            int finalSequence = 0;
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 1; i < n; i++)
            {
                if (array[i] == array[i - 1])
                {
                    sequence++;
                    if (sequence > finalSequence)
                    {
                        finalSequence = sequence;
                    }
                }
                else
                {
                    sequence = 1;
                }
            }
            Console.WriteLine(finalSequence);
        }
    }
}
