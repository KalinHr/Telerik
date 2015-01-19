using System;

/*Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2).*/

class PointInACircle
{
    static void Main()
    {
        Console.Write("x = ");
        double x = Convert.ToDouble(Console.ReadLine());
        Console.Write("y = ");
        double y = Convert.ToDouble(Console.ReadLine());
        bool inside = false;
        if (Math.Sqrt(Math.Abs(x) * Math.Abs(x) + Math.Abs(y) * Math.Abs(y)) <= 2)
            inside = true;
    }
}

