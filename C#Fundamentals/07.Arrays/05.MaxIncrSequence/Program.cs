﻿using System;

class MaximalIncreasingSequence
{
   
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] numbersArr = new int[n];
        int sequence = 1;
        int bestSequence = 1;

        for (int i = 0; i < n; i++)
        {
            numbersArr[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 1; i < numbersArr.Length; i++)
        {
            if (numbersArr[i - 1] < numbersArr[i])
            {
                sequence++;
                if (sequence > bestSequence)
                {
                    bestSequence = sequence;
                }
            }
            else
            {
                sequence = 1;
            }
        }
        Console.WriteLine(bestSequence);
    }
}