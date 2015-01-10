using System;

/*Which of the following values can be assigned to a variable of type float 
and which to a variable of type double: 34.567839023, 12.345, 8923.1234857, 3456.091?*/

class FloatOrDouble
{
    static void Main()
    {
        double n1 = 34.567839023;
        float n2 = 12.345F;
        double n3 = 8923.1234857;
        float n4 = 3456.091F;
        Console.WriteLine(n1);
        Console.WriteLine(n2);
        Console.WriteLine(n3);
        Console.WriteLine(n4);
    }
}
