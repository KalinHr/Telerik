using System;

/*Write a program that, for a given two integer numbers n and x, calculates 
  the sum S = 1 + 1!/x + 2!/x2 + … + n!/x^n.
  Use only one loop. Print the result with 5 digits after the decimal point.*/

class CalculateSum
{
    static int Fact(int n)
    {
        if (n <= 1)
            return 1;
        return n * Fact(n - 1);
    }

    static void Main()
    {
        Console.Write("N = ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.Write("X = ");
        int x = Convert.ToInt32(Console.ReadLine());
        double sum = 0;
        for (int i = 0; i <= n; i++)
            sum = sum + Fact(i) / Math.Pow(x, i);
        Console.WriteLine("{0:0.00000}", sum);
    }
}
