using System;

/*Write a program that creates an array containing all letters from the alphabet (A-Z).
  Read a word from the console and print the index of each of its letters in the array.*/

class Program
{
    static void Main()
    {
        char[] alphabet = { 'A', 'B', 'C', 'D', 'E', 'F', 'G',
                            'H', 'I', 'J', 'K', 'L', 'M', 'N',
                            'O', 'P', 'Q', 'R', 'S', 'T', 'U',
                            'V', 'W', 'X', 'Y', 'Z'};

        Console.Write("Word (A-Z): ");
        string word = Console.ReadLine();
        int length = word.Length;
        int[] indexOFLetters = new int[length];

        for (int i = 0; i < length; i++)
        {
            int index = -1;
            for (int j = 0; j < alphabet.Length; j++)
                if (word[i] == alphabet[j])
                    index = j;
            indexOFLetters[i] = index;
        }

        for (int i = 0; i < length; i++)
            Console.Write(indexOFLetters[i] + " ");
        Console.WriteLine();
    }
}
