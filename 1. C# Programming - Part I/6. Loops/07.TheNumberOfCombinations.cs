using System;
using System.Numerics;

/*Your task is to write a program that calculates n! / (k! * (n-k)!) 
  for given n and k (1 < k < n < 100).*/

class TheNumberOfCombinations
{
    static BigInteger Fact(long n)
    {
        if (n <= 1)
            return 1;
        return n * Fact(n - 1);
    }

    static void Main()
    {
        Console.WriteLine("(1 < k < n < 100)");
        Console.Write("k = ");
        int k = Convert.ToInt32(Console.ReadLine());
        Console.Write("n = ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(Fact(n) / (Fact(k) * Fact(n - k)));
    }
}
