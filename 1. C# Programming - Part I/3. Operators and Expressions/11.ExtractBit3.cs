using System;

/*Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer.
  The bits are counted from right to left, starting from bit #0.
  The result of the expression should be either 1 or 0.*/

class ExtractBit3
{
    static void Main()
    {
        Console.Write("number = ");
        uint number = Convert.ToUInt32(Console.ReadLine());
        int position = 3;
        uint mask = Convert.ToUInt32(1) << position;
        uint numberAndMask = number & mask;
        uint bit = numberAndMask >> position;
        Console.WriteLine(bit);
    }
}
