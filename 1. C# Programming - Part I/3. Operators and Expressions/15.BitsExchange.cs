using System;

/*Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.*/

class BitsExchange
{
    static void Main()
    {
        Console.Write("number = ");
        uint number = Convert.ToUInt32(Console.ReadLine());
        for (int i = 0; i < 3; i++)
        {
            int positionOne = 3 + i;
            uint mask = Convert.ToUInt32(1) << positionOne;
            uint numberAndMask = number & mask;
            uint firstBit = numberAndMask >> positionOne;

            int positionTwo = 24 + i;
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
