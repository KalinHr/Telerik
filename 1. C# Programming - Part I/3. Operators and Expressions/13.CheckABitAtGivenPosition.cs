using System;

/*Write a Boolean expression that returns if the bit at position p 
  (counting from 0, starting from the right) in given integer number n, has value of 1.*/

class BitAtGivenPosition
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
        bool isTheValueEqualToOne = Convert.ToBoolean(bit);
        Console.WriteLine(isTheValueEqualToOne);
    }
}

