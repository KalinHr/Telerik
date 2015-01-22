using System;

/*Write a program that gets two numbers from the console and prints the greater of them.
  Try to implement this without if statements.*/

class NumberComparer
{
    static void Main()
    {
        Console.Write("First number = ");
        double firstNumber = Convert.ToDouble(Console.ReadLine());
        Console.Write("Second number = ");
        double secondNumber = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(Math.Max(firstNumber, secondNumber));
    }
}

