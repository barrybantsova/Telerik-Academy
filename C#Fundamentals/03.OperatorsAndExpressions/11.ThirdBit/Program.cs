using System;

class Bit3rd
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int mask = 1 << 3;
        int andMask = n & mask;
        int bit3 = andMask >> 3;
        Console.WriteLine(bit3);
    }
}
