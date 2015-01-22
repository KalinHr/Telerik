using System;

/*Write a program that reads the radius r of a circle and prints its perimeter and 
  area formatted with 2 digits after the decimal point.*/

class CirclePerimeterAndArea
{
    static void Main()
    {
        Console.Write("radius = ");
        double r = Convert.ToDouble(Console.ReadLine());
        double perimeter = 2 * Math.PI * r;
        Console.WriteLine("perimeter = {0:0.00}", perimeter);
        double area = Math.PI * r * r;
        Console.WriteLine("area = {0:0.00}", area);
    }
}

