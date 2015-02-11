using System;
using System.Collections.Generic;

/*Write a program that finds the sequence of maximal sum in given array.
  Example:
  input	                                            result
  2, 3, -6, -1, 2, -1, 6, 4, -8, 8	                2, -1, 6, 4
  Can you do it with only one loop (with single scan through the elements of the array)?*/

class Program
{
    static void Main()
    {
        Console.WriteLine("Write an array like the example!");
        string s = Console.ReadLine();
        string[] arrHelper = s.Split(',');
        int length = arrHelper.Length;

        int[] arr = new int[length];
        for (int i = 0; i < length; i++)
            arr[i] = int.Parse(arrHelper[i]);

        // Kadane's algorithm
        int result = int.MinValue;
        int sum = 0;
        int start = 0;
        int tempStart = 0;
        int end = 0;
        for (int i = 0; i < length; i++)
        {
            sum += arr[i];
            if (result < sum)
            {
                result = sum;
                start = tempStart;
                end = i;
            }
            if (sum < 0)
            {
                sum = 0;
                tempStart = i+1;
            }
        }

        // print
        for (int i = start; i < end; i++)
            Console.Write(arr[i] + ", ");
        Console.WriteLine(arr[end]);
    }
}
