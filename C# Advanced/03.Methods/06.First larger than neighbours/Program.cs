using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.First_larger_than_neighbours
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int index = ReturnIndex(array, n);
            Console.WriteLine(index);
        }
        static int ReturnIndex(int[] array, int n)
        {
            int index = -1;
            for(int i = 1; i < n - 1; i++)
            {
                if (array[i - 1] < array[i] && array[i] > array[i + 1])
                {
                    index = i;
                    break;
                }
            }
            return index;
        }
    }
}
