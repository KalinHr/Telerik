using System;

/*Write a program that reads two integer arrays from the console and compares them element by element.*/

class Program
{
    static void Main()
    {
        Console.Write("length = ");
        int length = int.Parse(Console.ReadLine());
        int[] arr1 = new int[length];
        int[] arr2 = new int[length];
        for (int i = 0; i < length; i++)
        {
            Console.Write("arr1[{0}] = ", i);
            arr1[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < length; i++)
        {
            Console.Write("arr2[{0}] = ", i);
            arr2[i] = int.Parse(Console.ReadLine());
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
