using System;
using System.Collections.Generic;

/*Write a program that finds the most frequent number in an array.

  Example:
  input	                                      result
  4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3	      4 (5 times)*/

class Program
{
    static void SelectionSort(int[] arr, int length)
    {
        int counter = 0;
        while (length > counter + 1)
        {
            int min = arr[counter];
            int position = counter;
            for (int i = counter + 1; i < length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                    position = i;
                }
            }
            arr[position] = arr[counter];
            arr[counter] = min;
            counter++;
        }
    }

    static void Main()
    {
        Console.WriteLine("Write an array like in the example!");
        string s = Console.ReadLine();
        string[] arrHelper = s.Split(',');
        int length = arrHelper.Length;

        int[] arr = new int[length];
        for (int i = 0; i < length; i++)
            arr[i] = int.Parse(arrHelper[i]);

        SelectionSort(arr, length);

        int repeat = 1;
        int number = arr[0];
        int counter = 1;
        int helper = arr[0];

        for (int i = 1; i < length; i++)
        {
            if (helper == arr[i])
                counter++;
            else
            {
                helper = arr[i];
                counter = 1;
            }
            if (counter > repeat)
            {
                repeat = counter;
                number = helper;
            }
        }
        Console.WriteLine("{0} ({1} times)", number, repeat);
    }
}