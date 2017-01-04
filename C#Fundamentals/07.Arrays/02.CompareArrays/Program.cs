using System;
using System.Linq;

namespace _02.CompareArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[] firstArray = new int[size];
            int[] secondArray = new int[size];

            for (int i = 0; i < size; i++)
            {
                firstArray[i] = int.Parse(Console.ReadLine());
            }
            for (int j = 0; j < size; j++)
            {
                secondArray[j] = int.Parse(Console.ReadLine());
            }
            bool isequal = firstArray.SequenceEqual(secondArray);
            if (isequal)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not equal");
            }
        }
    }
}
