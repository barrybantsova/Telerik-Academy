﻿using System;

namespace _06.LongSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i=0;i<=1002 ;i++)
            {
                if(i%2==0)
                    Console.WriteLine(i);
                else
                    Console.WriteLine(-i);
            }
        }
    }
}
