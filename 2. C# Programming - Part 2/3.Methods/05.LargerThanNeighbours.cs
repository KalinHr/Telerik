using System;

/*Write a method that checks if the element at given position in given array of integers is larger than its two neighbours
  (when such exist).*/

class Program
{
    static bool LargerThanNeighbours(int[] arr, int index)
    {
        if (index > 0 && index < arr.Length - 1)
            if (arr[index] > arr[index + 1] && arr[index] > arr[index - 1])
                return true;
        return false;
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
        Console.Write("index = ");
        int index = int.Parse(Console.ReadLine());

        Console.WriteLine(LargerThanNeighbours(arr, index));
    }
}
