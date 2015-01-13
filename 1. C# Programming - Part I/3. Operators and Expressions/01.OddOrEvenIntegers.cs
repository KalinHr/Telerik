using System;

/*Write an expression that checks if given integer is odd or even.*/

class OddOrEvenIntegers
{
    static void Main()
    {
        Console.Write("number = ");
        int number = Convert.ToInt32(Console.ReadLine());
        bool even;
        if (number % 2 == 0)
            even = true;
        else
            even = false;
        Console.WriteLine(even);
    }
}

