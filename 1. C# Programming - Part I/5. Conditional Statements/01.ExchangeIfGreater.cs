﻿using System;

/*Write an if-statement that takes two double variables a and b and exchanges their values 
  if the first one is greater than the second one. As a result print the values a and b, 
  separated by a space.*/

class ExchangeIfGreater
{
    static void Main()
    {
        Console.Write("a = ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.Write("b = ");
        double b = Convert.ToDouble(Console.ReadLine());
        if (a > b)
        {
            double c = a;
            a = b;
            b = c;
        }
        Console.WriteLine("{0} {1}", a, b);
    }
}
