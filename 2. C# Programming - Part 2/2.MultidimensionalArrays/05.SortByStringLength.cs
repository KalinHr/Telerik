using System;

/*You are given an array of strings. Write a method that sorts the array by the length of its elements 
  (the number of characters composing them).*/

class Program
{
    static void Print(string[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
            Console.Write(arr[i] + " ");
        Console.WriteLine();
    }

    static void Sort(string[] arr)
    {
        int length = arr.Length;
        int counter = 0;
        while (length > counter + 1)
        {
            string min = arr[counter];
            int position = counter;
            for (int i = counter + 1; i < length; i++)
            {
                if (arr[i].Length < min.Length)
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
        Console.Write("Length: ");
        int length = int.Parse(Console.ReadLine());
        string[] arr = new string[length];
        for (int i = 0; i < length; i++)
        {
            Console.Write("arr[{0}] = ", i);
            arr[i] = Console.ReadLine();
        }
        Print(arr);
        Sort(arr);
        Print(arr);
    }
}
