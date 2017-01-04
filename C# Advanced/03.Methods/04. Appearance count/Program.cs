using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Appearance_count
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int num = int.Parse(Console.ReadLine());
            int count = AppearanceCount(array, num);
            Console.WriteLine(count);

        }
        static int AppearanceCount(int[] array, int num)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if(num == array[i])
                {
                    count++;
                }   
            }
            return count;
        }
    }
}
