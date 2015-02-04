using System;

class Program
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        string text = Console.ReadLine();
        long result = 0;

        for (int i = 0; i <= text.Length; i++)
            if (text[i] == '@')
            {
                Console.WriteLine(result);
                break;
            }
            else if (text[i] >= '0' && text[i] <= '9')
                result = result * (text[i] - '0');
            else if (text[i] >= 'a' && text[i] <= 'z')
                result += text[i] - 'a';
            else if (text[i] >= 'A' && text[i] <= 'Z')
                result += text[i] - 'A';
            else
                result = result % number;
    }
}
