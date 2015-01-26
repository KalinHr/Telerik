using System;

/*Using loops write a program that converts a binary integer number to its decimal form.
The input is entered as string. The output should be a variable of type long.
Do not use the built-in .NET functionality.*/

class BinaryToDecimalNumber
{
    static void Main()
    {
        Console.Write("binary number: ");
        string binary = Console.ReadLine();
        long dec = 0;
        int helper = 0;
        for (int i = binary.Length - 1; i >= 0; i--)
        {
            if (binary[i] == '1')
                dec = dec + (int)Math.Pow(2, helper);
            helper++;
        }
        Console.WriteLine(dec);
    }
}
