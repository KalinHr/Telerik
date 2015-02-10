using System;

/*Write a program that finds the index of given element in a sorted array of integers by 
  using the Binary search algorithm.
  Example:
  input 
  1, 2, 3, 5, 8, 13 */

class Program
{
    static int BinarySearch(int[] arr, int min, int max, int key)
    {
        while (max >= min)
        {
            int mid = (max + min) / 2;
            if (arr[mid] == key)
                return mid;
            else if (arr[mid] > key)
                max = mid - 1;
            else
                min = mid + 1;
        }
        return -1;
    }

    static void Main()
    {
        Console.WriteLine("Write an array like in the example:");
        string s = Console.ReadLine();
        string[] arrHelper = s.Split(',');
        int length = arrHelper.Length;

        int[] arr = new int[length];
        for (int i = 0; i < length; i++)
            arr[i] = int.Parse(arrHelper[i]);

        Console.WriteLine("element:");
        int key = int.Parse(Console.ReadLine());
        
        int result = BinarySearch(arr, 0, length - 1, key);
        if (result == -1)
            Console.WriteLine("Element was not found!");
        else
            Console.WriteLine(result);
    }
}
