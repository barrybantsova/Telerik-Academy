using System;

namespace _02.NotVisibleNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            uint input = uint.Parse(Console.ReadLine());
            for(int i = 0; i <= input; i++)
            {
                if(!(i%3==0) && !(i % 7 == 0)){
                    Console.Write(i+" ");
                }
            }
        }
    }
}
