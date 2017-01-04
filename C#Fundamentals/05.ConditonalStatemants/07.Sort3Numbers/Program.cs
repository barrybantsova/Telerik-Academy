using System;

namespace _07.Sort3Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());

           if( first > second)
            {
                if (second > third)
                {
                     Console.WriteLine("{0} {1} {2}", first,second, third);
                   
                }
                if(third > second)
                {
                    Console.WriteLine("{0} {1} {2}", first,third,second);

                }
            }

        }
    }
}
