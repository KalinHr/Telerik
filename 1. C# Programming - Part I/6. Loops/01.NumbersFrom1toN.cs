using System;

/*Write a program that enters from the console a positive integer n and prints all the numbers 
  from 1 to n, on a single line, separated by a space.*/

class NumbersFrom1toN
{
    static void Main()
    {
        Console.Write("number = ");
        int number = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= number; i++)
            Console.Write(i + " ");
        Console.WriteLine();
    }
}