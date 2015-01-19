using System;

/*Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) 
  and out of the rectangle R(top=1, left=-1, width=6, height=2).*/

class PointInsideACircleAndOutsideOfARectangle
{
    static void Main()
    {
        Console.Write("x = ");
        double x = Convert.ToDouble(Console.ReadLine());
        Console.Write("y = ");
        double y = Convert.ToDouble(Console.ReadLine());
        bool insideKoutsideR = false;
        if (((x - 1) * (x - 1) + (y - 1) * (y - 1) <= 1.5 * 1.5) && !(x >= -1 && x <= 5 && y >= -1 && y <= 1))
            insideKoutsideR = true;
    }
}
