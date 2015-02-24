using System;

/*Write methods that calculate the surface of a triangle by given:
  Side and an altitude to it;
  Three sides;
  Two sides and an angle between them;
  Use System.Math.*/

class Program
{
    static double SideAndAltitude()
    {
        Console.Write("side = ");
        double side = double.Parse(Console.ReadLine());
        Console.Write("altitude = ");
        double altitude = double.Parse(Console.ReadLine());
        return (side * altitude) / 2;
    }
    static double ThreeSides()
    {
        Console.Write("side = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("side = ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("side = ");
        double c = double.Parse(Console.ReadLine());
        double p = (a + b + c) / 2;
        return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
    }
    static double TwoSidesAndAngle()
    {
        Console.Write("side = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("side = ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("angle = ");
        double gamma = double.Parse(Console.ReadLine());
        return (a * b * Math.Sin(Math.PI * (gamma / 180))) / 2;
    }

    static void Main()
    {
        Console.WriteLine("1. Side and an altitude to it.");
        Console.WriteLine("2. Three sides.");
        Console.WriteLine("3. Two sides and an angle between them.");
        Console.WriteLine("Press 1, 2 or 3 and then Enter.");
        int method = int.Parse(Console.ReadLine());
        double surface = 0;
        if (method == 1)
            surface = SideAndAltitude();
        if (method == 2)
            surface = ThreeSides();
        if (method == 3)
            surface = TwoSidesAndAngle();
        Console.WriteLine("surface = {0}", surface);
    }
}
