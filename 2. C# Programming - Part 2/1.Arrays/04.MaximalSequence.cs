using System;

/*Write a program that finds the maximal sequence of equal elements in an array.
 
 Example:
 input	                           result
 2, 1, 1, 2, 3, 3, 2, 2, 2, 1	   2, 2, 2 */

class Program
{
    static void Main()
    {
        Console.WriteLine("Write an array like in the example!");
        string s = Console.ReadLine();
        string[] arrHelper = s.Split(',');
        int length = arrHelper.Length;

        int[] arr = new int[length];
        for (int i = 0; i < length; i++)
            arr[i] = int.Parse(arrHelper[i]);

        int counter = 1;
        int maxSequence = 1;
        int digit = arr[0];
        for (int i = 1; i < length; i++)
        {
            if (arr[i - 1] == arr[i])
                counter++;
            else
                counter = 1;
            if (counter > maxSequence)
            {
                digit = arr[i - 1];
                maxSequence = counter;
            }
        }
        for (int i = 0; i < maxSequence - 1; i++)
            Console.Write(digit + ", ");
        Console.WriteLine(digit);
    }
}
