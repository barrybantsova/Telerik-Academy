using System;

namespace _07.SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int[] arr = new int[length];
            int temp = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i; j < arr.Length - 1; j++)
                {
                    if (arr[j + 1] < arr[i])
                    {
                        temp = arr[i];
                        arr[i] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

        }
    }
}
