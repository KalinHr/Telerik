using System;

/*Write an expression that extracts from given integer n the value of given bit at index p.*/

class ExtractBitFromInteger
{
    static void Main()
    {
        Console.Write("number = ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.Write("position = ");
        int p = Convert.ToInt32(Console.ReadLine());
        int mask = 1 << p;
        int numberAndMask = n & mask;
        int bit = numberAndMask >> p;
	Console.WriteLine(bit);
    }
}

