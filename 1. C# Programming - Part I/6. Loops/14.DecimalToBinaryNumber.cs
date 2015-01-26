using System;

/*Using loops write a program that converts an integer number to its binary representation.
The input is entered as long. The output should be a variable of type string.
Do not use the built-in .NET functionality.*/

class DecimalToBinaryNumber
{
    static void Main()
    {
        Console.Write("number = ");
        long number = Convert.ToInt64(Console.ReadLine());
        string binary = "";
        if (number == 0)
            binary = '0' + binary;
        else
            while (number > 0)
            {
                int remainder = (int)number % 2;
                if (remainder == 1)
                    binary = '1' + binary;
                else
                    binary = '0' + binary;
                number /= 2;
            }
        Console.WriteLine(binary);
    }
}