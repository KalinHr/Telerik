using System;

/*Write a program that reads 3 real numbers from the console and prints their sum.*/

class SumOf3Numbers
{
    static void Main()
    {
        Console.Write("a = ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("b = ");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.Write("c = ");
        int c = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("sum = {0}", a + b + c);
    }
}

