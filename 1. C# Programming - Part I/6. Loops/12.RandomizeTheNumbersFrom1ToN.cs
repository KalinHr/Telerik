using System;
using System.Collections.Generic;

/*Write a program that enters in integer n and prints the numbers 1, 2, …, n in random order.*/

class RandomizeTheNumbersFrom1ToN
{
    static void Main()
    {
        Console.Write("n = ");
        int n = Convert.ToInt32(Console.ReadLine());
        List<int> numbers = new List<int>();
        for (int i = 1; i <= n; i++)
            numbers.Add(i);
        Random randomGenerator = new Random();
        int counter = numbers.Count;
        while (counter > 1)
        {
            counter--;
            int rand = randomGenerator.Next(counter + 1);
            int value = numbers[rand];
            numbers[rand] = numbers[counter];
            numbers[counter] = value;
        }
        foreach (int item in numbers)
            Console.Write(item + " ");
        Console.WriteLine();
    }
}