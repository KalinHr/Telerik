using System;

/*Write a program that prints the first 10 members of the sequence: 2, -3, 4, -5, 6, -7, ...*/

class PrintASequence
{
    static void Main()
    {
        for (int i = 2; i < 12; i++)
        {
            int n = i;
            if (n % 2 != 0)
                n = -n;
            Console.Write(n + " ");
        }
    }
}

