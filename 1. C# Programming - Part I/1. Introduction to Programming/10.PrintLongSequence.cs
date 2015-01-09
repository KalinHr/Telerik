using System;

/*Write a program that prints the first 1000 members of the sequence: 2, -3, 4, -5, 6, -7, …*/

class LongSequence
{
    static void Main()
    {
        for (int i = 2; i < 1002; i++)
        {
            int n = i;
            if (n % 2 != 0)
                n = -n;
            Console.Write(n + " ");
        }
    }
}