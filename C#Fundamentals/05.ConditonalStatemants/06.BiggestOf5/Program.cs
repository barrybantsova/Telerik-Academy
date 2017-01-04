using System;

namespace _06.BiggestOf5
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] array = new double[5];
            for(int i = 0; i < array.Length; i++)
            {
                array[i] = double.Parse(Console.ReadLine());
            }
            Array.Sort(array);
            Console.WriteLine(array[4]);

        }
    }
}
