using System;

/*Write a program that compares two char arrays lexicographically (letter by letter).*/

class Program
{
    static void Main()
    {
        Console.Write("length = ");
        int length = int.Parse(Console.ReadLine());
        char[] arr1 = new char[length];
        char[] arr2 = new char[length];
        for (int i = 0; i < length; i++)
        {
            Console.Write("arr1[{0}] = ", i);
            arr1[i] = char.Parse(Console.ReadLine());
        }
        for (int i = 0; i < length; i++)
        {
            Console.Write("arr2[{0}] = ", i);
            arr2[i] = char.Parse(Console.ReadLine());
        }
        for (int i = 0; i < length; i++)
            if (arr1[i] > arr2[i])
                Console.WriteLine("{0} > {1}", arr1[i], arr2[i]);
            else if (arr1[i] == arr2[i])
                Console.WriteLine("{0} = {1}", arr1[i], arr2[i]);
            else
                Console.WriteLine("{0} < {1}", arr1[i], arr2[i]);
    }
}
