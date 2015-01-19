using System;

/**/

class Rectangles
{
    static void Main()
    {
        Console.Write("width = ");
        double width = Convert.ToDouble(Console.ReadLine());
        Console.Write("height = ");
        double height = Convert.ToDouble(Console.ReadLine());
        double perimeter = width * 2 + height * 2;
        double area = width * height;
    }
}

