using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Reverse_number
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToArray();
            ReverseOrder(input);

        }
        static void ReverseOrder(char[] input)
        {
            for (int i = input.Length - 1; i >= 0; --i)
            {
                Console.Write(input[i]);
            }

        }
    }
}
