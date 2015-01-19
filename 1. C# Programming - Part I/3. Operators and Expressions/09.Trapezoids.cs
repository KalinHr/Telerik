using System;

/*Write an expression that calculates trapezoid's area by given sides a and b and height h.*/

class Trapezoids
{
    static void Main()
    {
        Console.Write("a = ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.Write("b = ");
        double b = Convert.ToDouble(Console.ReadLine());
        Console.Write("h = ");
        double h = Convert.ToDouble(Console.ReadLine());
        double area = (a + b) / 2 * h;
        Console.WriteLine(area);
    }
}

