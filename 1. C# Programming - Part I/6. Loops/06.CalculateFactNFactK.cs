using System;
using System.Numerics;

/*Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
Use only one loop.
*/

class CalculateFactNFactK
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
        Console.WriteLine("(1 < k < n < 100)");
        Console.Write("k = ");
        int k = Convert.ToInt32(Console.ReadLine());
        Console.Write("n = ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(Fact(n)/Fact(k));
    }
}