﻿using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(new string(':', n));
        for (int i = 0; i < n - 2; i++)
            Console.WriteLine(":" + new string(' ', n - 2) + ":" + new string('|', i) + ":");
        Console.WriteLine(new string(':', n) + new string('|', n - 2) + ":");
        for (int i = 1; i <= n - 2; i++)
            Console.WriteLine(new string(' ', i) + ":" + new string('-', n - 2) + ":" + new string('|', n - 2 - i) + ":");
        Console.WriteLine(new string(' ', n - 1) + new string(':', n));

    }
}
