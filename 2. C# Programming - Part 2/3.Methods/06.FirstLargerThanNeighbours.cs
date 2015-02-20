using System;

/*Write a method that returns the index of the first element in array that is larger than its neighbours,
  or -1, if there’s no such element.
  Use the method from the previous exercise.*/

class Program
{
    static bool LargerThanNeighbours(int[] arr, int index)
    {
        if (index > 0 && index < arr.Length - 1)
            if (arr[index] > arr[index + 1] && arr[index] > arr[index - 1])
                return true;
        return false;
    }

    static int FirstLargerThanNeighbours(int[] arr)
    {
        for (int i = 1; i < arr.Length - 1; i++)
            if (LargerThanNeighbours(arr, i))
                return i;
        return -1;
    }

    static void Main()
    {
        Console.WriteLine("Write an array like \"2, 1, 4, 2, 3, 3, 2, 2, 2, 1\"");
        string s = Console.ReadLine();
        string[] arrHelper = s.Split(',');
        int length = arrHelper.Length;
        int[] arr = new int[length];
        for (int i = 0; i < length; i++)
            arr[i] = int.Parse(arrHelper[i]);

        Console.WriteLine(FirstLargerThanNeighbours(arr));
    }
}