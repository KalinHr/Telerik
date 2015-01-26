using System;
using System.Numerics;

/*Write a program that calculates with how many zeroes the factorial of a given number n has at its end.
Your program should work well for very big numbers, e.g. n=100000.*/

class TrailingZeroesInNFactorial
{
    static BigInteger Fact(int x)
    {
        BigInteger fact = new BigInteger(1);
        for (int i = 1; i <= x; i++)
            fact = fact * i;
        return fact;
    }

    static void Main()
    {
        Console.Write("n = ");
        int n = Convert.ToInt32(Console.ReadLine());
        BigInteger fact = Fact(n);
        int counter = 0;
        while (fact % 10 == 0)
        {
            counter++;
            fact = fact / 10;
        }
        Console.WriteLine(counter);
    }
}
