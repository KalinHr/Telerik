using System;

/*Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
  Use the Selection sort algorithm: Find the smallest element, move it at the first position, find the smallest 
  from the rest, move it at the second position, etc.*/

class Program
{
    static void SelectionSort(int[] arr, int length)
    {
        int counter = 0;
        while(length > counter + 1)
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
        Console.Write("lenght = ");
        int length = int.Parse(Console.ReadLine());

        int[] arr = new int[length];
        for (int i = 0; i < length; i++)
        {
            Console.Write("arr[{0}] = ", i);
            arr[i] = int.Parse(Console.ReadLine());
        }

        SelectionSort(arr, length);

        for (int i = 0; i < length; i++)
            Console.Write(arr[i] + " ");
        Console.WriteLine();
    }
}

