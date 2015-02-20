using System;

/*Write a method that counts how many times given number appears in given array.
  Write a test program to check if the method is workings correctly.
 */

class Program
{
    static int NumberInArray(int[] arr, int number)
    {
        int counter = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == number)
                counter++;
        }
        return counter;
    }
    static void Main()
    {
        Console.Write("number = ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("Write an array like \"2, 1, 1, 2, 3, 3, 2, 2, 2, 1\"");
        string s = Console.ReadLine();
        string[] arrHelper = s.Split(',');
        int length = arrHelper.Length;
        int[] arr = new int[length];
        for (int i = 0; i < length; i++)
            arr[i] = int.Parse(arrHelper[i]);

        Console.WriteLine(NumberInArray(arr, number));
    }
}
