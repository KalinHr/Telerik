using System;

/*Using loops write a program that converts an integer number to its hexadecimal representation.
The input is entered as long. The output should be a variable of type string.
Do not use the built-in .NET functionality.*/

class DecimalToHexadecimalNumber
{
    static void Main()
    {
        Console.Write("number = ");
        long number = Convert.ToInt64(Console.ReadLine());
        string hexadecimal = "";
        while (number > 15)
        {
            if (number % 16 < 10)
                hexadecimal = Convert.ToString(number % 16) + hexadecimal;
            else
                hexadecimal = (char)(number % 16 + 55) + hexadecimal;
            number = number / 16;
        }
        if (number < 10)
            hexadecimal = Convert.ToString(number) + hexadecimal;
        else
            hexadecimal = (char)(number + 55) + hexadecimal;
        Console.WriteLine(hexadecimal);
    }
}
