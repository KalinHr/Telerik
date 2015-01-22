using System;

/*Write a program that reads two positive integer numbers and prints how many numbers p 
  exist between them such that the reminder of the division by 5 is 0.*/

class NumbersInInterval
{
    static void Main()
    {
        Console.Write("start = ");
        int start = Convert.ToInt32(Console.ReadLine());
        Console.Write("end = ");
        int end = Convert.ToInt32(Console.ReadLine());
        int p = 0;
        for (int i = start; i <= end; i++)
            if (i % 5 == 0)
                p++;
        Console.WriteLine(p);
    }
}