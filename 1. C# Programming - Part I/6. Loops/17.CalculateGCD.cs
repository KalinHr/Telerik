using System;

/*Write a program that calculates the greatest common divisor (GCD) of given two integers a and b.
  Use the Euclidean algorithm (find it in Internet).*/

class CalculateGCD
{
    static void Main()
    {
        Console.Write("a = ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("b = ");
        int b = Convert.ToInt32(Console.ReadLine());
        if (Math.Max(a, b) == b)
        {
            int c = a;
            a = b;
            b = c;
        }
        int remainder = 0;
        if (a % b == 0)
            remainder = b;
        while (a % b > 0)
        {
            remainder = a % b;
            a = b;
            b = remainder;
        }
        Console.WriteLine(remainder);
    }
}