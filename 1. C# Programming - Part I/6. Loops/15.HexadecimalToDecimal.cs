using System;

/*Using loops write a program that converts a hexadecimal integer number to its decimal form.
  The input is entered as string. The output should be a variable of type long.
  Do not use the built-in .NET functionality.*/

class HexadecimalToDecimal
{
    static void Main()
    {
        Console.Write("hexadecimal number: ");
        string hex = Console.ReadLine();
        long dec = 0;
        int counter = 0;
        for (int i = hex.Length - 1; i >= 0; i--)
        {
            if (hex[counter] >= '0' && hex[counter] <= '9')
                dec = dec + (long)Math.Pow(16, i) * ((long)hex[counter] - 48);
            else
                dec = dec + (long)Math.Pow(16, i) * ((long)hex[counter] - 55);
            counter++;
        }
        Console.WriteLine(dec);
    }
}