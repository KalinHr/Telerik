using System;

/*Declare a character variable and assign it with the symbol that has Unicode code 42 (decimal) using the \u00XX syntax, and then print it.*/

class UnicodeCharacter
{
    static void Main()
    {
        char c = '\u002A';
        Console.WriteLine(c);
    }
}

