using System;

/*Write a program that finds the biggest of five numbers by using only five if statements.*/

class TheBiggestOfFiveNumbers
{
    static void Main()
    {
        Console.Write("a = ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.Write("b = ");
        double b = Convert.ToDouble(Console.ReadLine());
        Console.Write("c = ");
        double c = Convert.ToDouble(Console.ReadLine());
        Console.Write("d = ");
        double d = Convert.ToDouble(Console.ReadLine());
        Console.Write("e = ");
        double e = Convert.ToDouble(Console.ReadLine());
        double biggest = e;
        if (a >= b && a >= c && a >= d && a >= e)
            biggest = a;
        if (b >= a && b >= c && b >= d && b >= e)
            biggest = b;
        if (c >= a && c >= b && c >= d && c >= e)
            biggest = c;
        if (d >= a && d >= b && d >= c && d >= e)
            biggest = d;
        Console.WriteLine(biggest);
    }
}