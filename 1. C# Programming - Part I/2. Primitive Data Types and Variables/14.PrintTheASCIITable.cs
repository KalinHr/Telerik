using System;

/*Find online more information about ASCII (American Standard Code for Information Interchange)
  and write a program that prints the entire ASCII table of characters on the console (characters from 0 to 255).*/

class PrintTheASCIITable
{
    static void Main()
    {
        for(int i = 0; i <= 255; i++)
        {
            char c = (char) i;
            Console.Write(c + " ");
        }
        Console.WriteLine();
    }
}

