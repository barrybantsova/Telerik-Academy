using System;
using System.Linq;

namespace _14.IntegerCalculations
{
    class Program
    {
        static void Main(string[] args)
        { 
            decimal[] arr = Console.ReadLine().Split(' ').Select(decimal.Parse).ToArray();
            decimal[] result = new decimal[5];
            Calculate(arr, ref result);
            
            Console.WriteLine(result[0]);
            Console.WriteLine(result[1]);
            Console.WriteLine("{0:F2}", result[2]); 
            Console.WriteLine(result[3]);
            Console.WriteLine(result[4]);
        }

        static void Calculate(decimal[] arr, ref decimal[] result)
        {
            result[0] = arr.Min();
            result[1] = arr.Max();
            result[2] = arr.Average();
            result[3] = arr.Sum();
            result[4] = arr[0] * arr[1] * arr[2] * arr[3] * arr[4];
        }
    }
}
