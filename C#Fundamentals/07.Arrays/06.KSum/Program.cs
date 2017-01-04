using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.KSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(array);
            for (int j = array.Length -1; j >= array.Length - k; j--)
            {
                sum += array[j];
            }
            Console.WriteLine(sum);
        }
    }
}
