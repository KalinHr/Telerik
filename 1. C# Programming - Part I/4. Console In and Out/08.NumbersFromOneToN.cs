﻿using System;

/*Write a program that reads an integer number n from the console and prints all the numbers 
  in the interval [1..n], each on a single line.*/

class NumbersFromOneToN
{
    static void Main()
    {
        Console.Write("n = ");
        int n = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= n; i++)
            Console.WriteLine(i);
    }
}

