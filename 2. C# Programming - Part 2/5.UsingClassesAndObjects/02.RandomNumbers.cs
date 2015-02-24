using System;

/*Write a program that generates and prints to the console 10 random values in the range [100, 200].*/

class Program
{
    static void Main()
    {
        Random random = new Random();
        int randomNumber = random.Next(100, 201);
        Console.WriteLine(randomNumber);
    }
}