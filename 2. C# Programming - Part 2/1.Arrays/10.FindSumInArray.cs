using System;
using System.Collections.Generic;

/*Write a program that finds in given array of integers a sequence of given sum S (if present).
  Example:

  array	                  S	     result
  4, 3, 1, 4, 2, 5, 8	  11	 4, 2, 5*/

class Program
{
    static int Sum(List<int> list)
    {
        int sum = 0;
        for (int i = 0; i < list.Count; i++)
            sum += list[i];
        return sum;
    }

    static void Main()
    {
        Console.WriteLine("Write an array like in the example:");
        string s = Console.ReadLine();
        string[] arrHelper = s.Split(',');
        int length = arrHelper.Length + 1;

        int[] arr = new int[length];
        for (int i = 0; i < length - 1; i++)
            arr[i] = int.Parse(arrHelper[i]);
        arr[length - 1] = 0;

        Console.Write("sum = ");
        int sum = int.Parse(Console.ReadLine());

        List<int> result = new List<int>();
        result.Add(arr[0]);
        int counter = 1;
        while (counter < length)
        {
            if (Sum(result) < sum)
            {
                result.Add(arr[counter]);
                counter++;
            }
            else if (Sum(result) > sum)
                result.RemoveAt(0);
            if (Sum(result) == sum)
            {
                for (int i = 0; i < result.Count - 1; i++)
                    Console.Write(result[i] + ", ");
                Console.WriteLine(result[result.Count - 1]);
                break;
            }
        }
    }
}