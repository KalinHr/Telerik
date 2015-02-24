using System;

/*You are given a sequence of positive integer values written into a string, separated by spaces.
  Write a function that reads these values from given string and calculates their sum.
  Example:
  input	                output
  "43 68 9 23 318"      461
*/

class Program
{
    static void Main()
    {
        Console.WriteLine("Write an array like the example!");
        string s = Console.ReadLine();
        string[] arrHelper = s.Split(' ');
        int length = arrHelper.Length;

        int[] arr = new int[length];
        for (int i = 0; i < length; i++)
            arr[i] = int.Parse(arrHelper[i]);

        int sum = 0;
        for (int i = 0; i < arr.Length; i++)
            sum += arr[i];

        Console.WriteLine(sum);
    }
}
