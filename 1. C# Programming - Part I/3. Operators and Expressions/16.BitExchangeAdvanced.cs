using System;

/*Write a program that exchanges bits {p, p+1, …, p+k-1} with bits {q, q+1, …, q+k-1} of a given 32-bit unsigned integer.
  The first and the second sequence of bits may not overlap.*/

class BitExchangeAdvanced
{
    static void Main()
    {
        Console.Write("number = ");
        uint number = Convert.ToUInt32(Console.ReadLine());
        Console.Write("p = ");
        int p = Convert.ToInt32(Console.ReadLine());
        Console.Write("q = ");
        int q = Convert.ToInt32(Console.ReadLine());
        Console.Write("k = ");
        int k = Convert.ToInt32(Console.ReadLine());
        if (p + k <= 32 && q + k <= 32 && Math.Abs(q - p) >= k)
            for (int i = 0; i < k; i++)
            {
                int positionOne = p + i;
                uint mask = Convert.ToUInt32(1) << positionOne;
                uint numberAndMask = number & mask;
                uint firstBit = numberAndMask >> positionOne;

                int positionTwo = q + i;
                mask = Convert.ToUInt32(1) << positionTwo;
                numberAndMask = number & mask;
                uint secondBit = numberAndMask >> positionTwo;

                if (firstBit == 0)
                {
                    mask = ~(Convert.ToUInt32(1) << positionTwo);
                    number = number & mask;
                }
                if (firstBit == 1)
                {
                    mask = Convert.ToUInt32(1) << positionTwo;
                    number = number | mask;
                }

                if (secondBit == 0)
                {
                    mask = ~(Convert.ToUInt32(1) << positionOne);
                    number = number & mask;
                }
                if (secondBit == 1)
                {
                    mask = Convert.ToUInt32(1) << positionOne;
                    number = number | mask;
                }
            }
    }
}

