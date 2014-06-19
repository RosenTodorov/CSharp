using System;




class FindingTheBit3Is1Or9
{
    static void Main()
    {
        Console.Write("Put your number:");
        int p = 3;
        int n = int.Parse(Console.ReadLine());
        int mask = 1 << p;
        int nAndMask = n & mask;
        int bit = nAndMask >> p;
        Console.WriteLine(bit);
    }
}
