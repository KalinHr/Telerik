using System;
using System.Numerics;

class Program
{
    static string MagicTransformation(string number, int length)
    {
        BigInteger result = 1;
        int x = 1;
        int z = length;
        while (z + 1 > x)
        {
            int sum = 0;
            for (int i = 0; i < length - 1; i++)
                if (i % 2 != 0)
                    sum += number[i] - '0';
            x++;
            if (sum != 0)
                result = result * sum;
            length--;
        }
        return Convert.ToString(result);
    }

    static void Main()
    {
        string number = Console.ReadLine();
        int length = number.Length;
        int counter = 0;
        while (number.Length > 1 && counter < 10)
        {
            number = MagicTransformation(number, length);
            length = number.Length;
            counter++;
        }
        if (counter < 10)
            Console.WriteLine(counter);
        Console.WriteLine(number);
    }
}
