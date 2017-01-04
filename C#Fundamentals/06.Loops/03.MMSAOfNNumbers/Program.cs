using System;
using System.Linq;

namespace _03.MMSAOfNNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
          double [] array = new double[n];
            for(int i = 0; i< array.Length; i++)
            {
                array[i] = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("min={0:F2}",array.Min());
            Console.WriteLine("max={0:F2}",array.Max());
            Console.WriteLine("sum={0:F2}",array.Sum());
            Console.WriteLine("avg={0:F2}",array.Average());

        }

    }
}
