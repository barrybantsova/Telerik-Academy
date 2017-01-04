using System;
using System.Linq;


namespace _02.GetLargestNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int maxValue = GetMax(input);
            Console.WriteLine(maxValue);
        }

        static int GetMax(int[] input)
        {
            int temp = int.MinValue;
            for (int i = 0; i < input.Length; i++)
            {
               if(temp < input[i])
                {
                    temp = input[i];
                }
            }
            return temp;
        }
    }
}
