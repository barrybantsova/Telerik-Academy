﻿using System;
using System.Numerics;

namespace _07.OneSystemToAnyOther
{
    class OneSystemToAnyOther
    {
        static uint s_NumSystem;
        static string value;
        static uint d_NumSystem;
        static ulong valueToDecimal;
        static string result;

        static void Main(string[] args)
        {  
            s_NumSystem = uint.Parse(Console.ReadLine());
            value = Console.ReadLine();
            d_NumSystem = uint.Parse(Console.ReadLine());
         
            S_NumeralSystemToDecimal();
            DecimalToD_NumeralSystem();
            
            Console.WriteLine(result);
        }

        static void S_NumeralSystemToDecimal()
        {
            int digit = 0;
            int position = 0;
            ulong tempSum = 0;
            for (int i = 0; i < value.Length; i++)
            {
                if (value[i] >= 'A' && value[i] <= 'Z')
                {
                    digit = value[i] - 'A' + 10;
                    position = value.Length - i - 1;
                    tempSum += (ulong)digit * (ulong)BigInteger.Pow(s_NumSystem, position); 
                }
                else 
                {
                    digit = int.Parse(value[i].ToString());
                    position = value.Length - i - 1;
                    tempSum += (ulong)digit * (ulong)BigInteger.Pow(s_NumSystem, position);
                }
            }
            valueToDecimal = tempSum;
        }

        static void DecimalToD_NumeralSystem()
        {
            ulong tempSum = 0;
            if (valueToDecimal == 0)
            {
                result = "0";
            }
            else
            {
                while (valueToDecimal != 0)
                {
                    tempSum = valueToDecimal % d_NumSystem;
                    valueToDecimal = valueToDecimal / d_NumSystem;
                    if (tempSum > 9)
                    {
                        char letter = (char)((tempSum - 9 - 1) + 'A');
                        result = (letter.ToString()) + result;
                    }
                    else
                    {
                        result = tempSum + result;  
                    }
                }
            }
        }
    }
}
