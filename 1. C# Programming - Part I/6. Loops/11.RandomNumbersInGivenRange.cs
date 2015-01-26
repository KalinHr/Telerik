using System;

/*Write a program that enters 3 integers n, min and max (min != max) and prints n random numbers 
  in the range [min...max].*/

class RandomNumbersInGivenRange
{
    static void Main()
    {
        Console.Write("n = ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.Write("min = ");
        int min = Convert.ToInt32(Console.ReadLine());
        Console.Write("max = ");
        int max = Convert.ToInt32(Console.ReadLine());
        Random randomGenerator = new Random();
        for (int i = 0; i < n; i++)
        {
            Console.Write(randomGenerator.Next(min, max + 1) + " ");
        }

    }
}
