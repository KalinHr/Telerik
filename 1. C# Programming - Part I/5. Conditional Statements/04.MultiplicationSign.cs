using System;

/*Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
  Use a sequence of if operators.*/

class MultiplicationSign
{
    static void Main()
    {
        Console.Write("a = ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.Write("b = ");
        double b = Convert.ToDouble(Console.ReadLine());
        Console.Write("c = ");
        double c = Convert.ToDouble(Console.ReadLine());
        if (a == 0 || b == 0 || c == 0)
            Console.WriteLine("0");
        else if ((a > 0 && b > 0 && c > 0) ||
                 (a < 0 && b < 0 && c > 0) ||
                 (a < 0 && b > 0 && c < 0) ||
                 (a > 0 && b < 0 && c < 0))
            Console.WriteLine("+");
        else
            Console.WriteLine("-");
    }
}
