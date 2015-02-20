using System;

/*Write a method GetMax() with two parameters that returns the larger of two integers.
  Write a program that reads 3 integers from the console and prints the largest of them 
  using the method GetMax().*/

class Program
{
    static int GetMax(int integer1, int integer2)
    {
        int result = 0;
        if (integer1 >= integer2)
            result = integer1;
        else
            result = integer2;
        return result;
    }
    static void Main()
    {
        Console.Write("First integer: ");
        int integer1 = int.Parse(Console.ReadLine());
        Console.Write("Second integer: ");
        int integer2 = int.Parse(Console.ReadLine());
        Console.WriteLine(GetMax(integer1, integer2));
    }
}
