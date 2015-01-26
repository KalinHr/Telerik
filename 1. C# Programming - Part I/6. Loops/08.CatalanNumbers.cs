using System;
using System.Numerics;

/*Write a program to calculate the nth Catalan number 
  by given n (1 <= n <= 100).*/

class CatalanNumbers
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
        Console.WriteLine("(1 <= n <= 100)");
        Console.Write("n = ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(Fact(2 * n) / (Fact(n + 1) * Fact(n)));
    }
}
