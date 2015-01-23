using System;

/*Write a program that finds the biggest of three numbers.*/

class TheBiggestOf3Numbers
{
    static void Main()
    {
        Console.Write("a = ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.Write("b = ");
        double b = Convert.ToDouble(Console.ReadLine());
        Console.Write("c = ");
        double c = Convert.ToDouble(Console.ReadLine());
        if (a >= b && a >= c)
            Console.WriteLine(a);
        else if (b >= a && b >= c)
            Console.WriteLine(b);
        else if (c >= a && c >= b)
            Console.WriteLine(c);
    }
}