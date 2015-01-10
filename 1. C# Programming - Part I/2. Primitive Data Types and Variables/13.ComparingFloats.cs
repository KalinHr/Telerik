using System;

/*Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001.
  Note: Two floating-point numbers a and b cannot be compared directly by a == b because of the nature of the floating-point arithmetic. 
  Therefore, we assume two numbers are equal if they are more closely to each other than a fixed constant eps.*/

class ComparingFloats
{
    static void Main()
    {
        const float eps = 0.000001F;
        Console.Write("a = ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.Write("b = ");
        double b = Convert.ToDouble(Console.ReadLine());
        bool equal = false;
        if (Math.Abs(a - b) <= eps)
            equal = true;
        Console.WriteLine(equal);
    }
}
